using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.ShopAPI
{
    [XmlType("goldTopBizModel", Namespace = ShopAPI.ModelNamespace)]
    public class GoldTopBizModel
    {
        [XmlElement(Namespace = "")]
        public GoldTop insertModel { get; set; }
        [XmlElement(Namespace = "")]
        public GoldTop updateModel { get; set; }
    }
    public class GoldTop
    {
        public int pcRedirect { get; set; }
        public int spRedirect { get; set; }

    }
}
