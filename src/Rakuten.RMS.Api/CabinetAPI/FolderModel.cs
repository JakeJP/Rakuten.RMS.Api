using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.CabinetAPI
{
    public class FolderModel
    {
        [XmlElement("FolderId")]
        public long FolderId { get; set; }
        [XmlElement("FolderName")]
        public string FolderName { get; set; }
        [XmlElement("FolderNode")]
        public int FolderNode { get; set; }
        [XmlElement("FolderPath")]
        public string FolderPath { get; set; }
        [XmlElement("FileCount")]
        public int FileCount { get; set; }
        [XmlElement("FileSize")]
        public decimal FileSize { get; set; }
        [XmlIgnore]
        public DateTime TimeStamp { get => DateTime.Parse(_TimeStampRaw); }
        [XmlElement("TimeStamp")]
        public string _TimeStampRaw { get; set; }

    }

}
