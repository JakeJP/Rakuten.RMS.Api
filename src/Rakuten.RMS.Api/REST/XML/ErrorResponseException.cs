using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rakuten.RMS.Api.XML
{
    public class ErrorResponseException : RakutenRMSApiException
    {
        public ErrorResult Errors { get; set; }
        public ErrorResponseException(ErrorResult error)
        {
            Errors = error;
        }
        public override string Message => string.Join(", ", Errors.Errors.Select(s => string.Format("{0} - {1}", s.code, s.message)));
    }
}
