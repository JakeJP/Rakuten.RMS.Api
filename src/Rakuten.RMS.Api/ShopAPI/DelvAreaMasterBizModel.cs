using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.ShopAPI
{
    [XmlType("delvAreaMasterBizModel", Namespace = ShopAPI.ModelNamespace)]
    public class DelvAreaMasterBizModel
    {
        [XmlArrayItem("delvAreaMaster")]
        public List<DelvAreaMaster> delvAreaMasterList { get; set; }
    }
    public class DelvAreaMaster
    {
        public int delvAreaId { get; set; }// あす楽配送管理番号   Integer	10	Yes	
        public string delvAreaName { get; set; }// あす楽管理用名称    String	150	Yes	
        public string delvAreaCaption { get; set; }// 配送に関する説明文   String	383	No	
        public string delvAreaLimit { get; set; }// 締め切り時間
    }
}
