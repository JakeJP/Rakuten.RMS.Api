using Newtonsoft.Json;
using System;
using System.Net;
using System.Text;
using System.Collections.Specialized;
using System.Linq;

namespace Rakuten.RMS.Api.JSON
{
    public class RakutenApiJsonClientBase
    {
        protected ServiceProvider provider;
        protected RakutenApiJsonClientBase(ServiceProvider provider)
        {
            this.provider = provider;
        }

        protected TResult GetRequest<TResult>(string url, string method = "GET", NameValueCollection queryParameters = null)
        {
            if( queryParameters != null && queryParameters.Count > 0)
            {
                var qs = string.Join("&", queryParameters.Keys.Cast<string>()
                        .Where(k => !string.IsNullOrEmpty(queryParameters[k]))
                        .Select(k => k + "=" + queryParameters[k]));
                url += "?" + qs;
            }
            var req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = method;
            req.Headers.Add("Authorization", provider.AuthorizationHeaderValue);
            var sz = new JsonSerializer();

            {
                HttpWebResponse response;
                try
                {
                    response = (HttpWebResponse)req.GetResponse();

                }
                catch (WebException wex)
                {
                    response = (HttpWebResponse)wex.Response;
                }
                using (var rst = response.GetResponseStream())
                using (var _rd = new System.IO.StreamReader(rst))
                using (var rd = new JsonTextReader(_rd))
                {
                    if (response.StatusCode == HttpStatusCode.OK || typeof(TResult).IsAssignableFrom(typeof(ResultBase)))
                        return sz.Deserialize<TResult>(rd);
                    else
                        throw new ErrorResponseException(sz.Deserialize<ResultBase>(rd));
                }
            }

        }
        protected TResult PostRequest<TResult>(string url, object request, string method = "POST", string dateFormtString = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'+0900'")
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
                WebResponse response;
                try
                {
                    response = req.GetResponse();

                }
                catch (WebException wex)
                {
                    response = wex.Response;
                }
                using (var rst = response.GetResponseStream())
                using (var _rd = new System.IO.StreamReader(rst))
                {
                    if (response.ContentType == "text/html")
                    {
                        var text = _rd.ReadToEnd();
                        throw new Exception(text);
                    }
                    else
                    {
                        using (var rd = new JsonTextReader(_rd))
                        {
                            return sz.Deserialize<TResult>(rd);
                        }
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

