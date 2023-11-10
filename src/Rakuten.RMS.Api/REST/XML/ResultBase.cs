using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.XML
{
    [XmlRoot("result")]
    public abstract class ResultBase
    {
        [XmlElement("status")]
        public XmlStatus Status { get; set; }
        public override string ToString()
        {
            if( Status != null)
                return string.Format("{0}, {1}, {2}, {3}", Status.SystemStatus, Status.Message, Status.InterfaceId, Status.RequestId);
            return base.ToString();
        }
    }

}
