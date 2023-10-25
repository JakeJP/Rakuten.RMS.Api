using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rakuten.RMS.Api
{
    public class RakutenRMSApiException : Exception
    {
        public RakutenRMSApiException() { }
        public RakutenRMSApiException(string message) : base(message) { }
    }
}
