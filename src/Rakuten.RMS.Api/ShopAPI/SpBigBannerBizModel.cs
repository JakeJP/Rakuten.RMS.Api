using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.ShopAPI
{
    [XmlType("spBigBannerBizModel", Namespace = ShopAPI.ModelNamespace)]
    public class SpBigBannerBizModel
    {
        public SpBigBannerList replaceList { get; set; }
    }

}
