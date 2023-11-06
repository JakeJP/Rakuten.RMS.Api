using Rakuten.RMS.Api.ShopAPI;
using System;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Web;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.XML
{
    public abstract class RakutenApiXmlClientBase : REST.RakutenApiClientBaseCommon
    {
        protected RakutenApiXmlClientBase(ServiceProvider provider) : base(provider)
        {
        }
        protected virtual TResult Get<TResult>(string url, NameValueCollection queryParameters = null )
        {
            var qs = queryParameters != null ? string.Join("&", queryParameters.Keys.Cast<string>()
                        .Where(k => !string.IsNullOrEmpty(queryParameters[k]))
                        .Select(k => k + "=" + HttpUtility.UrlEncode(queryParameters[k]))) : null;
            if (!string.IsNullOrEmpty(qs))
                url += "?" + qs;
            return GetInternal<TResult>(url);

        }
        protected TResult Get<TResult>(NameValueCollection queryParameters = null, [System.Runtime.CompilerServices.CallerMemberName] string methodName = null)
        {
            var method = GetType().GetMethod(methodName, System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            var endpoint = (EndpointDefinitionAttribute)method.GetCustomAttributes(typeof(EndpointDefinitionAttribute), true).First();
            return Get<TResult>(endpoint.Url, queryParameters);
        }
        private TResult GetInternal<TResult>(string url, string dateFormtString = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'+0900'")
        {
            var req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "GET";
            req.Headers.Add("Authorization", provider.AuthorizationHeaderValue);
            req.Accept = "application/xml";

            return HandleResponse<TResult, ErrorResult>(req);
        }
        protected virtual XmlSerializerNamespaces GetNamespaces() => null;
        protected virtual TResult Post<TResult>(object request, [System.Runtime.CompilerServices.CallerMemberName] string methodName = null, XmlSerializerNamespaces namespaces = null)
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
            }
            return HandleResponse<TResult,ErrorResult>(req);
        }
        protected override TResult HandleResponse<TResult,TErrorResult>( HttpWebRequest req)
        {
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
            var ct = (response.ContentType ?? "").Split(";".ToCharArray(), 2, StringSplitOptions.RemoveEmptyEntries).FirstOrDefault();
            if (new[] { "application/xml", "text/xml" }.Any(c => c == ct))
            {
                using (var rst = response.GetResponseStream())
                using (var sr = new StreamReader(rst))
                {
                    if ((int)response.StatusCode >= 200 && (int)response.StatusCode < 300)
                    {// successful
                        var sz = new XmlSerializer(typeof(TResult));
                        return (TResult)sz.Deserialize(sr);
                    }
                    else
                    {
                        var allText = sr.ReadToEnd();
                        using (var ssr = new StringReader(allText))
                        {
                            if (typeof(ErrorResult).IsAssignableFrom(typeof(TErrorResult)))
                            {
                                var sz = new XmlSerializer(typeof(ErrorResult));
                                var errorResult = (ErrorResult)sz.Deserialize(ssr);
                                throw new RakutenRMSApiException(string.Join(", ", errorResult.Errors.Select(e => e.ToString())));
                            }
                            else
                            {
                                var sz = new XmlSerializer(typeof(TErrorResult));
                                var errorResult = (TErrorResult)sz.Deserialize(ssr);
                                throw new RakutenRMSApiException(errorResult.ToString(), errorResult);
                            }
                        }
                    }
                }
            }
            else
            {
                using (var rst = response.GetResponseStream())
                using (var _rd = new StreamReader(rst))
                {
                    throw new RakutenRMSApiException(_rd.ReadToEnd());
                }
            }
        }
    }
}
