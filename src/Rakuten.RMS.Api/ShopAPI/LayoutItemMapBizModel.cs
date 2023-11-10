using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.ShopAPI
{
    [XmlType("layoutItemMapBizModel", Namespace = ShopAPI.ModelNamespace)]
    public class LayoutItemMapBizModel
    {
        public List<LayoutItemMap> layoutItemMapList {  get; set; }
    }
    public class LayoutItemMap
    {
        public long itemMapId { get; set; }
        public string name { get; set; }
        public int defaultFlag { get; set; }
        public DateTime? lastUpdate { get; set; }
    }
}
