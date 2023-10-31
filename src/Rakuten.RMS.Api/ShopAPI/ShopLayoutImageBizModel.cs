using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.ShopAPI
{
    [XmlType(TypeName = "shopLayoutImageBizModel", Namespace = "http://rakuten.co.jp/rms/mall/shop/biz/api/model/resource")]
    public class ShopLayoutImageBizModel
    {
        [XmlElement(Namespace = "")]
        public ShopLayoutImage shopLayoutImage { get; set; }
    }
    public class ShopLayoutImage
    {
        public string signboardPath { get; set; }
    }

    [XmlRoot("shopLayoutImageBizModel", Namespace = "http://rakuten.co.jp/rms/mall/shop/biz/api/model/resource")]
    public class ShopLayoutImageBizModelForEdit
    {
        [XmlElement(Namespace = "")]
        public ShopLayoutImage insertModel { get; set; }

    }
}
