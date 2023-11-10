using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.ShopAPI
{

    [XmlType("soryoKbnBizModel", Namespace = ShopAPI.ModelNamespace)]
    public class SoryoKbnBizModel
    {
        [XmlArrayItem("soryoKbn")]
        public List<SoryoKbn> soryoKbnList { get; set; }
    }

    public class SoryoKbn
    {
        public int kbnId { get; set; }
        public int id { get; set; }
        public string name { get; set; }
    }
}
