using System;

namespace Rakuten.RMS.Api.XML
{
    internal enum EndpointHttpMethod
    {
        GET,
        POST
    }
    [AttributeUsage(AttributeTargets.Method)]
    internal class EndpointDefinitionAttribute : Attribute
    {
        public string Url { get; set; }
        public EndpointHttpMethod Method { get; set; }
        public EndpointDefinitionAttribute(string url, EndpointHttpMethod method)
        {
            Url = url; Method = method;
        }
    }
}
