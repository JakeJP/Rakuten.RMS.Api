using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.ShopAPI
{
    [XmlType("shopAreaSoryoWrapperBizModel", Namespace = ShopAPI.ModelNamespace)]
    public class ShopAreaSoryoWrapperBizModel
    {
        public ShopAreaSoryoWrapper insertModel { get; set; }
        public ShopAreaSoryoWrapper updateModel { get; set; }
    }
    [XmlType("shopAreaSoryoWrapperBizModel", Namespace = ShopAPI.ModelNamespace)]
    public class ShopAreaSoryoWrapperModel
    {
        [XmlElement(Namespace ="")]
        public ShopAreaSoryoWrapper shopAreaSoryoWrapper { get; set; }
    }
    public class ShopAreaSoryoWrapper
    {
        [XmlArrayItem("shopAreaSoryoPattern")]
        public List<ShopAreaSoryoPattern> shopAreaSoryoPatternList { get; set; }
    }
    public class ShopAreaSoryoPattern
    {
        public int patternId { get; set; }
        public string patternName { get; set;}
        [XmlArrayItem("shopAreaSoryoCharge")]
        public List<ShopAreaSoryoCharge> shopAreaSoryoChargeList { get; set; }
    }
    public class ShopAreaSoryoCharge
    {
        /// <summary>
        /// 地域ID
        /// 1: 北海道
        /// 2: 北東北
        /// 3: 南東北
        /// 4: 関東
        /// 5: 信越
        /// 6: 北陸
        /// 7: 東海
        /// 8: 関西
        /// 9: 中国
        /// 10: 四国
        /// 11: 北九州
        /// 12: 南九州
        /// 13: 沖縄
        /// </summary>
        public int regionId { get; set; }
        /// <summary>
        /// 送料
        /// </summary>
        public int charge { get; set; }
    }
}
