using Rakuten.RMS.Api.ShopAPI;
using System;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.XML
{
    public abstract class RakutenApiXmlClientBase
    {
        ServiceProvider provider;
        protected RakutenApiXmlClientBase(ServiceProvider provider)
        {
            this.provider = provider;
        }
        protected TResult Get<TResult>(string url, NameValueCollection queryParameters = null )
        {
            var qs = queryParameters != null ? string.Join("&", queryParameters.Keys.Cast<string>()
                        .Where(k => !string.IsNullOrEmpty(queryParameters[k]))
                        .Select(k => k + "=" + queryParameters[k])) : null;
            if (!string.IsNullOrEmpty(qs))
                url += "?" + qs;
            return GetInternal<TResult>(url);

        }
        protected TResult Get<TResult>(NameValueCollection queryParameters = null, [System.Runtime.CompilerServices.CallerMemberName] string methodName = null)
        {
            var method = GetType().GetMethod(methodName, System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            var endpoint = (EndpointDefinitionAttribute)method.GetCustomAttributes(typeof(EndpointDefinitionAttribute), true).First();
            var qs = queryParameters != null ? string.Join("&", queryParameters.Keys.Cast<string>()
                        .Where(k => !string.IsNullOrEmpty(queryParameters[k]))
                        .Select(k => k + "=" + queryParameters[k])) : null;
            var url = string.IsNullOrEmpty(qs) ? endpoint.Url : endpoint.Url + "?" + qs;

            return GetInternal<TResult>(url);
        }
        protected TResult GetInternal<TResult>(string url, string dateFormtString = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'+0900'")
        {
            var req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "GET";
            req.Headers.Add("Authorization", provider.AuthorizationHeaderValue);
            req.Accept = "application/xml";
            var sz = new XmlSerializer(typeof(TResult));
            HttpWebResponse response;
            try
            {
                response = (HttpWebResponse)req.GetResponse();
            }
            catch (WebException wex)
            {
                response = (HttpWebResponse)wex.Response;
                if (response == null)
                    throw wex;
            }
            if (response != null && response.ContentType != null && 
                new[] { "application/xml", "text/xml" }.Any( m => response.ContentType.StartsWith(m)))
            {
                using (var rst = response.GetResponseStream())
                using (var _rd = new System.IO.StreamReader(rst))
                {
                    if (response.StatusCode == HttpStatusCode.OK 
                        || response.StatusCode == HttpStatusCode.BadRequest
                        || response.StatusCode == HttpStatusCode.Unauthorized )
                    {
                        return (TResult)sz.Deserialize(_rd);
                    }
                    else
                    {
                        sz = new XmlSerializer(typeof(ErrorResult));
                        var errorResult = (ErrorResult)sz.Deserialize(_rd);
                        throw new ErrorResponseException(errorResult);
                    }
                }
            }
            else
            {
                using (var rst = response.GetResponseStream())
                using (var _rd = new StreamReader(rst))
                {
                    throw new Exception(_rd.ReadToEnd());
                }
            }

        }
        protected virtual XmlSerializerNamespaces GetNamespaces() => null;
        protected TResult Post<TResult>(object request, [System.Runtime.CompilerServices.CallerMemberName] string methodName = null, XmlSerializerNamespaces namespaces = null)
        {
            var method = GetType().GetMethod(methodName, System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            var endpoint = (EndpointDefinitionAttribute)method.GetCustomAttributes(typeof(EndpointDefinitionAttribute), true).First();
            return PostInternal<TResult>(endpoint.Url, request, namespaces ?? GetNamespaces() );
        }

        private TResult PostInternal<TResult>(string url, object request, XmlSerializerNamespaces namespaces )
        {
            var req = (HttpWebRequest)WebRequest.Create(url);
            req.ContentType = "application/xml; charset=utf-8";
            req.Method = "POST";
            req.Headers.Add("Authorization", provider.AuthorizationHeaderValue);
            var sz = new XmlSerializer(request.GetType());
#if DEBUG
            var sb = new StringBuilder();
            using (var sw = new System.IO.StringWriter(sb))
            {
                sz.Serialize(sw, request, namespaces);
                sw.Flush();
                sw.Close();
            }
#endif

            using (var st = req.GetRequestStream())
            {
                using (var wt = new System.IO.StreamWriter(st, new UTF8Encoding(false)))
                {
                    sz.Serialize(wt, request, namespaces);
                    wt.Flush();
                    wt.Close();
                }
                HttpWebResponse response;
                try
                {
                    response = (HttpWebResponse)req.GetResponse();

                }
                catch (WebException wex)
                {
                    if (wex.Response == null)
                        throw wex;
                    response = (HttpWebResponse)wex.Response;
                }
                using (var rst = response.GetResponseStream())
                using (var sr = new StreamReader(rst))
                {
                    if( response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.BadRequest)
                    {
                        sz = new XmlSerializer(typeof(TResult));
                        return (TResult)sz.Deserialize(sr);
                    }
                    else
                    {
                        sz = new XmlSerializer(typeof(ErrorResult));
                        var errorResult = (ErrorResult)sz.Deserialize(sr);
                        throw new Exception(string.Join(", ", errorResult.Errors.Select(e => e.ToString())));
                    }
                }
            }
        }


        protected TResult PostFile<TResult>(string url, Stream fileStream /*string file*/, string paramName, string contentType, NameValueCollection nvc)
        {
            string boundary = "---------------------------" + DateTime.Now.Ticks.ToString("x");
            byte[] boundarybytes = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundary + "\r\n");

            HttpWebRequest wr = (HttpWebRequest)WebRequest.Create(url);
            wr.ContentType = "multipart/form-data; boundary=" + boundary;
            wr.Method = "POST";
            wr.KeepAlive = true;
            wr.Credentials = System.Net.CredentialCache.DefaultCredentials;

            Stream rs = wr.GetRequestStream();

            string formdataTemplate = "Content-Disposition: form-data; name=\"{0}\"\r\n\r\n{1}";
            foreach (string key in nvc.Keys)
            {
                if (key == paramName) continue;
                rs.Write(boundarybytes, 0, boundarybytes.Length);
                string formitem = string.Format(formdataTemplate, key, nvc[key]);
                byte[] formitembytes = System.Text.Encoding.UTF8.GetBytes(formitem);
                rs.Write(formitembytes, 0, formitembytes.Length);
            }
            rs.Write(boundarybytes, 0, boundarybytes.Length);

            string headerTemplate = "Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n";
            string header = string.Format(headerTemplate, paramName, nvc[paramName], contentType);
            byte[] headerbytes = System.Text.Encoding.UTF8.GetBytes(header);
            rs.Write(headerbytes, 0, headerbytes.Length);

#if true
            byte[] buffer = new byte[4096];
            int bytesRead = 0;
            while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0)
            {
                rs.Write(buffer, 0, bytesRead);
            }
#else
            FileStream fileStream = new FileStream(file, FileMode.Open, FileAccess.Read);
            byte[] buffer = new byte[4096];
            int bytesRead = 0;
            while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0)
            {
                rs.Write(buffer, 0, bytesRead);
            }
            fileStream.Close();
#endif

            byte[] trailer = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundary + "--\r\n");
            rs.Write(trailer, 0, trailer.Length);
            rs.Close();

            WebResponse wresp = null;
            TResult result;

            wresp = wr.GetResponse();
            using (var rst = wresp.GetResponseStream())
            {
                var sz = new XmlSerializer(typeof(TResult));
                result = (TResult)sz.Deserialize(rst);
            }
            wr = null;

            return result;
        }
    }
}
