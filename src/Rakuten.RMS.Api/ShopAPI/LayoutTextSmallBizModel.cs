using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.ShopAPI
{
    [XmlType(TypeName = "layoutTextSmallBizModel", Namespace = ShopAPI.ModelNamespace)]

    public class LayoutTextSmallBizModel
    {
        public LayoutTextSmallList layoutTextSmallList { get; set; }
    }
    public class LayoutTextSmallList
    {
        public LayoutTextSmall layoutTextSmall { get; set; }
    }
    public class LayoutTextSmall
    {
        public int? textSmallId { get; set; }
        public string name { get; set; }
        public string text { get; set; }
        public string textLink { get; set; }
        /// <summary>
        /// 0: 自動選択しない 1: 自動選択対象
        /// </summary>
        public int? defaultFlag { get; set; }
        public DateTime? lastUpdate { get; set; }
    }
}
