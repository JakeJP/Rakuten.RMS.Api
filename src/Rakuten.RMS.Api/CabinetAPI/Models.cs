using System.Xml.Serialization;

namespace Rakuten.RMS.Api.CabinetAPI
{

    [XmlRoot("result")]
    public class CabinetUsageGetResultModel
    {
        [XmlElement("resultCode")]
        public int ResultCode { get; set; }
        [XmlElement("MaxSpace")]
        public int MaxSpace { get; set; }
        [XmlElement("FolderMax")]
        public int FolderMax { get; set; }
        [XmlElement("FileMax")]
        public int FileMax { get; set; }
        [XmlElement("UseSpace")]
        public decimal UseSpace { get; set; }
        [XmlElement("AvailSpace")]
        public decimal AvailSpace { get; set; }
        [XmlElement("UseFolderCount")]
        public int UseFolderCount { get; set; }
        [XmlElement("AvailFolderCount")]
        public int AvailFolderCount { get; set; }
    }
}
