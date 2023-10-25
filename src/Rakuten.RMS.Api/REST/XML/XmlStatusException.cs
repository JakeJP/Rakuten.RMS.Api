using Rakuten.RMS.Api.XML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rakuten.RMS.Api.XML
{
    public class XmlStatusException : RakutenRMSApiException
    {
        public XmlStatusException( XmlStatus status) : base(status.Message )
        {
            this.Status = status;
        }
        public XmlStatus Status { get; set; }
    }
}
