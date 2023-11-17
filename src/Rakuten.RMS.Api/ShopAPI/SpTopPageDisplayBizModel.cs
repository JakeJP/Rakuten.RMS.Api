using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.ShopAPI
{
    [XmlType("spTopPageDisplayBizModel", Namespace = ShopAPI.ModelNamespace)]

    public class SpTopPageDisplayBizModel
    {
        [XmlElement(Namespace = "")]
        public SpTopPageDisplay spTopPageDisplay {  get; set; }
    }
    public class SpTopPageDisplay
    {
        public int status { get;set; }
    }
}
