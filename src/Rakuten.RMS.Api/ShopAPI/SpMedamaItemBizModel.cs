using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.ShopAPI
{
    [XmlType("spMedamaItemBizModel", Namespace = ShopAPI.ModelNamespace)]
    public class SpMedamaItemBizModel
    {
        public SpMedamaItem replaceModel { get;set; }
    }
}
