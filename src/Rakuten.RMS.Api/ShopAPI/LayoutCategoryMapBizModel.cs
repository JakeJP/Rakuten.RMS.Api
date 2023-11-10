using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.ShopAPI
{
    [XmlType("layoutCategoryMapBizModel", Namespace = ShopAPI.ModelNamespace)]
    public class LayoutCategoryMapBizModel
    {
        [XmlArrayItem("layoutCategoryMap")]
        public List<LayoutCategoryMap> layoutCategoryMapList { get; set; }
    }
    public class LayoutCategoryMap
    {
        public int categoryMapId { get; set; }
        public string name {  get; set; }
        public int defaultFlag { get; set; }
        public DateTime? lastUpdate { get; set; }
    }

}
