using System.Xml;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.XML
{
    [XmlRoot("result")]
    public abstract class ResultBase
    {
        [XmlElement("status")]
        public XmlStatus Status { get; set; }
    }
}
