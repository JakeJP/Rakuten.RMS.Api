using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.CabinetAPI
{
    public class FileModel
    {
        public long FolderId { get; set; }
        public string FolderName { get; set; }
        /// <summary>
        /// 1 or 2 or 3
        /// </summary>
        public int FolderNode { get; set; }
        public string FolderPath { get; set; }
        public int FileId { get; set; }
        public string FileName { get; set; }
        public string FileUrl { get; set; }
        public string FilePath { get; set; }
        public int FileType { get; set; }
        public decimal FileSize { get; set; }
        public int FileWidth { get; set; }
        public int FileHeight { get; set; }
        [XmlIgnore]
        public DateTime FileAccessDate
        {
            get
            {
                DateTime _dt;
                return DateTime.TryParse(_FileAccessDateRaw, out _dt) ? _dt : DateTime.MinValue;
            }
        }
        [XmlElement("FileAccessDate")]
        public string _FileAccessDateRaw { get; set; }
        [XmlIgnore]
        public DateTime TimeStamp { get { DateTime _dt; return DateTime.TryParse(_TimeStampRaw, out _dt) ? _dt : DateTime.MinValue; } }
        [XmlElement("TimeStamp")]
        public string _TimeStampRaw { get; set; }

    }
}
