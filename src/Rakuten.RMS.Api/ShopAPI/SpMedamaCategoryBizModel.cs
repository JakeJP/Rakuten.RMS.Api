using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.ShopAPI
{
    [XmlType("spMedamaCategoryBizModel", Namespace = ShopAPI.ModelNamespace)]
    public class SpMedamaCategoryBizModel
    {
        [XmlElement(Namespace = "")]
        public SpMedamaCategoryModel replaceModel { get; set; }
    }
    public class SpMedamaCategoryModel
    {
        public SpMedamaCategoryCommon spMedamaCategoryCommon { get; set; }
        public SpMedamaCategoryList spMedamaCategoryList { get; set; }
    }
}
