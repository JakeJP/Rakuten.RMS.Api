using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.ShopAPI
{
    [XmlType(TypeName = "signboardBizModel", Namespace = ShopAPI.ModelNamespace)]
    public class SignboardBizModel
    {
        [XmlElement(Namespace = "")]
        public Signboard signboard {  get; set; }
    }
    public class Signboard
    {
        public string spSignboardUrl { get; set; }
        public string pcSignboardUrl { get; set; }
    }
}
