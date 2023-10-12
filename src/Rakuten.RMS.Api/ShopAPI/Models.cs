using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Rakuten.RMS.Api.XML;

namespace Rakuten.RMS.Api.ShopAPI
{
    [XmlRoot("shopBizApiResponse", Namespace = "http://rakuten.co.jp/rms/mall/shop/biz/api/model/resource")]
    public class ShopBizApiResponse<TResult>
    {
        [XmlElement("resultCode", Namespace = "")]
        public string resultCode { get; set; }
        [XmlArray("resultMessageList", Namespace = "")]
        [XmlArrayItem("resultMessage", Namespace = "")]
        public List<ResultMessage> resultMessageList { get; set; }
        [XmlElement("result", Namespace = "")]
        public TResult Result { get; set; }
    }

}
