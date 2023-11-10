using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.ShopAPI
{
    [XmlType("layoutTextLargeBizModel", Namespace = ShopAPI.ModelNamespace)]
    public class LayoutTextLargeBizModel
    {
        [XmlArrayItem("layoutTextLarge")]
        public List<LayoutTextLarge> insertList { get; set; }
        [XmlArrayItem("layoutTextLarge")]
        public List<LayoutTextLarge> updateList {  get; set; }
    }
    public class LayoutTextLarge
    {
        public int? textLargeId { get; set; }
        public string name { get; set; }
        public string text { get; set; }
        /// <summary>
        /// 0: 自動選択しない 1: 自動選択対象
        /// </summary>
        public int? defaultFlag { get; set; }
    }
}
