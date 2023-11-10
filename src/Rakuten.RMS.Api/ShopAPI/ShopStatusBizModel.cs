using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.ShopAPI
{
    [XmlType("shopStatusBizModel", Namespace = ShopAPI.ModelNamespace)]
    public class ShopStatusBizModel
    {
        public ShopStatus updateModel { get; set; }

    }
    public class ShopStatus
    {
        public string statusKey { get; set; }
        public string statusValue { get; set; }
    }
}
