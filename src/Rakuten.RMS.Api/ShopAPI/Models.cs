using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Rakuten.RMS.Api.XML;

namespace Rakuten.RMS.Api.ShopAPI
{
    public abstract class BizResponseResultBase
    {
        internal ShopBizApiResponse response;
        public ShopBizApiResponse GetResponse() => response;
    }
    [XmlRoot("shopBizApiResponse", Namespace = "http://rakuten.co.jp/rms/mall/shop/biz/api/model/resource")]
    public class ShopBizApiResponse
    {
        [XmlElement("resultCode", Namespace = "")]
        public string resultCode { get; set; }
        [XmlArray("resultMessageList", Namespace = "")]
        [XmlArrayItem("resultMessage", Namespace = "")]
        public List<ResultMessage> resultMessageList { get; set; }
    }
    [XmlRoot("shopBizApiResponse", Namespace = "http://rakuten.co.jp/rms/mall/shop/biz/api/model/resource")]
    public class ShopBizApiResponse<TResult> : ShopBizApiResponse where TResult : BizResponseResultBase
    {
        [XmlElement("result", Namespace = "")]
        public TResult Result 
        {
            get => _result; 
            set 
            {
                _result = value;
                if( _result is BizResponseResultBase)
                    ((BizResponseResultBase)_result).response = this; 
            }
        }
        protected TResult _result;
    }

}
