using System.Xml;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.XML
{
    public class XmlStatus
    {
        [XmlElement("interfaceId")]
        public string InterfaceId { get; set; }
        /// <summary>
        /// OK or NG
        /// </summary>
        [XmlElement("systemStatus")]
        public string SystemStatus { get; set; }
        [XmlElement("message")]
        public string Message { get; set; }
        [XmlElement("requestId")]
        public string RequestId { get; set; }
        public object requests { get; set; }
    }
}
