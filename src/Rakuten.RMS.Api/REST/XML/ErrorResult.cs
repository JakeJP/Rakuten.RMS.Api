using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.XML
{
    [XmlRoot("errors")]
    public class ErrorResult
    {
        [XmlElement("element")]
        public List<ResultMessage> Errors { get; set; }
    }
    public class ResultMessage
    {
        public string code { get; set; }
        public string message { get; set; }
        public override string ToString()
        {
            return string.Format("{0} : {1}", code, message);
        }
    }
}
