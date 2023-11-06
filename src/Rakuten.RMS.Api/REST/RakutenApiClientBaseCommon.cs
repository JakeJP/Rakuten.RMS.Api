using Rakuten.RMS.Api.JSON;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Rakuten.RMS.Api.REST
{
    public abstract class RakutenApiClientBaseCommon
    {
        protected ServiceProvider provider;
        protected RakutenApiClientBaseCommon(ServiceProvider provider)
        {
            this.provider = provider;
        }
        protected virtual TResult PostFile<TResult>(string url, Stream fileStream /*string file*/, string paramName, string contentType, NameValueCollection nvc)
            => PostFile<TResult,ResultError>(url,fileStream,paramName, contentType, nvc);
        protected virtual TResult PostFile<TResult,TErrorResult>(string url, Stream fileStream /*string file*/, string paramName, string contentType, NameValueCollection nvc)
        {
            string boundary = "---------------------------" + DateTime.Now.Ticks.ToString("x");
            byte[] firstboundarybytes = System.Text.Encoding.ASCII.GetBytes("--" + boundary + "\r\n");
            byte[] boundarybytes = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundary + "\r\n");

            var wr = (HttpWebRequest)WebRequest.Create(url);
            wr.ContentType = "multipart/form-data; boundary=" + boundary;
            wr.Method = "POST";
            wr.Headers.Add("Authorization", provider.AuthorizationHeaderValue);
            //wr.Credentials = System.Net.CredentialCache.DefaultCredentials;

            Stream rs = wr.GetRequestStream();

            string formdataTemplate = "Content-Disposition: form-data; name=\"{0}\"\r\n\r\n{1}";
            int line = 0;
            foreach (string key in nvc.Keys)
            {
                if (key == paramName) continue;
                if (line++ == 0)
                    rs.Write(firstboundarybytes, 0, firstboundarybytes.Length);
                else
                    rs.Write(boundarybytes, 0, boundarybytes.Length);
                string formitem = string.Format(formdataTemplate, key, nvc[key]);
                byte[] formitembytes = System.Text.Encoding.UTF8.GetBytes(formitem);
                rs.Write(formitembytes, 0, formitembytes.Length);
            }
            if (fileStream != null)
            {
                rs.Write(boundarybytes, 0, boundarybytes.Length);

                string headerTemplate = "Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n";
                string header = string.Format(headerTemplate, paramName, nvc[paramName], contentType);
                byte[] headerbytes = System.Text.Encoding.UTF8.GetBytes(header);
                rs.Write(headerbytes, 0, headerbytes.Length);

                fileStream.CopyTo(rs);
            }

            byte[] trailer = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundary + "--\r\n");
            rs.Write(trailer, 0, trailer.Length);
            rs.Close();

            return HandleResponse<TResult,TErrorResult>(wr);
        }
        protected abstract TResult HandleResponse<TResult,TErrorResult>(HttpWebRequest req);
    }
}
