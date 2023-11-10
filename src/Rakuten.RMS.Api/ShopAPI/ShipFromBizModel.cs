using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.ShopAPI
{
    [XmlType(TypeName = "shipFromBizModel", Namespace = ShopAPI.ModelNamespace)]
    public class ShipFromBizModel
    {
        public ShipFrom shipFromList { get; set; }
    }
    public class ShipFrom
    {
        public string shipFromId { get; set; }
        public string name { get; set; }
        public string zipcodeFrom {  get; set; }
        public string defaultFlag {  get; set; }

    }
}
