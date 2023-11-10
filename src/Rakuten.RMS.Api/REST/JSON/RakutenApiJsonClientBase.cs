using Newtonsoft.Json;
using System;
using System.Net;
using System.Text;
using System.Collections.Specialized;
using System.Linq;
using Rakuten.RMS.Api.XML;
using System.IO;
using System.Xml.Serialization;
using System.Web;

namespace Rakuten.RMS.Api.JSON
{
    public class RakutenApiJsonClientBase : REST.RakutenApiClientBaseCommon
    {
        protected RakutenApiJsonClientBase(ServiceProvider provider) : base(provider)
        {
        }
        protected TResult GetRequest<TResult>(string url, string method = "GET", NameValueCollection queryParameters = null)
            => GetRequest<TResult, ResultBase>(url, method, queryParameters);

        protected TResult GetRequest<TResult,TErrorResult>(string url, string method = "GET", NameValueCollection queryParameters = null)
        {
            if( queryParameters != null && queryParameters.Count > 0)
            {
                var qs = string.Join("&", queryParameters.Keys.Cast<string>()
                        .Where(k => !string.IsNullOrEmpty(queryParameters[k]))
                        .Select(k => k + "=" + HttpUtility.UrlEncode(queryParameters[k])));
                url += "?" + qs;
            }
            var req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = method;
            req.Headers.Add("Authorization", provider.AuthorizationHeaderValue);

            return HandleResponse<TResult,TErrorResult>(req);

        }
        protected TResult PostRequest<TResult>(string url, object request, string method = "POST", string dateFormtString = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'+0900'")
            => PostRequest<TResult, ResultBase>(url, request, method, dateFormtString);

        protected TResult PostRequest<TResult,TErrorResult>(string url, object request, string method = "POST", string dateFormtString = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'+0900'")
        {
            var req = (HttpWebRequest)WebRequest.Create(url);
            req.ContentType = "application/json; charset=utf-8";
            req.Method = method;
            req.Headers.Add("Authorization", provider.AuthorizationHeaderValue);
            var sz = new JsonSerializer();
            sz.NullValueHandling = NullValueHandling.Ignore;
            sz.DateFormatString = dateFormtString;
            var sb = new StringBuilder();
            using (var sw = new System.IO.StringWriter(sb))
            {
                sz.Serialize(sw, request);
                sw.Flush();
                sw.Close();
            }

            using (var st = req.GetRequestStream())
            {
                using (var wt = new System.IO.StreamWriter(st, new UTF8Encoding(false)))
                {
                    wt.Write(sb.ToString());
                    wt.Flush();
                    wt.Close();
                }
            }
            return HandleResponse<TResult, TErrorResult>(req);
               
        }
        protected TResult HandleResponse<TResult>(HttpWebRequest req)
            => HandleResponse<TResult, ResultBase>(req);

        protected override TResult HandleResponse<TResult,TErrorResult>(HttpWebRequest req)
        {
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
            using (var rst = response.GetResponseStream())
            {
                if (typeof(TResult).IsAssignableFrom(typeof(Stream)))
                    return (TResult)(object)rst;

                using (var _rd = new StreamReader(rst))
                {
                    var ct = (response.ContentType ?? "").Split(";".ToCharArray(), 2, StringSplitOptions.RemoveEmptyEntries ).FirstOrDefault();
                    if( ct == "application/json")
                    {
                        using (var rd = new JsonTextReader(_rd))
                        {
                            var sz = new JsonSerializer();

                            if ( (int)response.StatusCode >= 200 && (int)response.StatusCode < 300 )
                                return sz.Deserialize<TResult>(rd);
                            else 
                            {
                                if( typeof(ResultBase).IsAssignableFrom(typeof(TResult)))
                                    return sz.Deserialize<TResult>(rd);
                                else if (typeof(ResultBase).IsAssignableFrom(typeof(TErrorResult)))
                                    throw new ErrorResponseException((ResultBase)(object)sz.Deserialize<TErrorResult>(rd));
                                else
                                    throw new ErrorResponseException<TErrorResult>(sz.Deserialize<TErrorResult>(rd));
                            }
                            
                        }
                    }
                    else
                    {
                        var text = _rd.ReadToEnd();
                        throw new Exception(text);
                    }
                }
            }
        }

    }
#if SYSTEMJSON // if not using Newtonsoft JSON.NET
    public class DictionaryConverter : JsonConverter
    {
        public override object ReadJson(
            JsonReader reader,
            Type objectType,
            object existingValue,
            JsonSerializer serializer)
        {
            IDictionary<string, string> result;

            if (reader.TokenType == JsonToken.StartArray)
            {
                JArray legacyArray = (JArray)JArray.ReadFrom(reader);

                result = legacyArray.ToDictionary(
                    el => el["Key"].ToString(),
                    el => el["Value"].ToString());
            }
            else
            {
                result =
                    (IDictionary<string, string>)
                        serializer.Deserialize(reader, typeof(IDictionary<string, string>));
            }

            return result;
        }

        public override void WriteJson(
            JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(IDictionary<string, string>).IsAssignableFrom(objectType);
        }

        public override bool CanWrite
        {
            get { return false; }
        }
    }
#endif
}

