using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Rakuten.RMS.Api.XML;

namespace Rakuten.RMS.Api.CabinetAPI
{
    public class CabinetUpdateFileResult
    {
        [XmlElement("resultCode")]
        public int ResultCode { get; set; }
    }
    public class CabinetInsertFileResult : CabinetUpdateFileResult
    {
        public long FileId { get; set; }
    }
    [XmlRoot("result")]
    public class InsertFileResponse : ResultBase
    {
        public CabinetInsertFileResult cabinetFileInsertResult { get; set; }
    }
    [XmlRoot("result")]
    public class UpdateFileResponse : ResultBase
    {
        public CabinetUpdateFileResult cabinetFileUpdateResult { get; set; }
    }

}
