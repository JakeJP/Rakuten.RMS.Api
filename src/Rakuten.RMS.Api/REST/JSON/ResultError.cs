using System;
using System.Linq;

namespace Rakuten.RMS.Api.JSON
{
    public class ResultError
    {
        public string code { get; set; }
        public string message { get; set; }
        public ErrorMetadata metadata { get; set; }
    }
    public class ErrorMetadata
    {
        public string propertyPath { get; set; }
    }



}
