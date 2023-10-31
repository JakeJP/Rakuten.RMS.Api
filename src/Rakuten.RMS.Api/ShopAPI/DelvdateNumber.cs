using Rakuten.RMS.Api.JSON;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.ShopAPI
{
    public class DelvdateMaster
    {
        public string delvdateNumber { get; set; }
        public string delvdateCaption { get; set; }
        public long appointDays { get; set; }
    }
    [XmlType(TypeName = "delvdateMasterBizModel", Namespace = ShopAPI.ModelNamespace)]

    public class DelvdateMasterBizModel 
    {
        [XmlArray("delvdateMasterList", Namespace = "")]
        [XmlArrayItem("delvdateMaster", Namespace = "")]
        public List<DelvdateMaster> delvdateMasterList { get; set; }
    }
}
