using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rakuten.RMS.Api.JSON
{
    public class ErrorResponseException : RakutenRMSApiException
    {
        public ResultBase Errors { get; set; }
        public ErrorResponseException(ResultBase error)
        {
            Errors = error;
        }
        public override string Message => string.Join(", ", Errors.errors.Select(s => string.Format("{0} - {1}", s.code, s.message)));
    }
    public class ErrorResponseException<TResult> : RakutenRMSApiException
    {
        public TResult Error { get; set; }
        public ErrorResponseException(TResult error)
        {
            Error = error;
        }
        public override string Message => Error.ToString();
    }
}
