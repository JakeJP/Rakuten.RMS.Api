using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.ShopAPI
{
    [XmlType("deliverySetInfoBizModel", Namespace = ShopAPI.ModelNamespace)]
    public class DeliverySetInfoBizModel
    {
        [XmlArrayItem("deliverySetInfo")]
        public List<DeliverySetInfo> deliverySetInfoList { get; set; }
    }
    public class DeliverySetInfo
    {
        public int deliverySetId { get; set; }
        public string deliverySetName { get; set; }
        public int deliverySetDefaultFlag { get; set; }
    }
}
