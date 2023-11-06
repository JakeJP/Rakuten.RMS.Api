using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Rakuten.RMS.Api.XML;

namespace Rakuten.RMS.Api.ShopAPI
{
    public class ShopBizApiException : RakutenRMSApiException
    {
        public ShopBizApiResponse Response { get; set; }
        public ShopBizApiException(ShopBizApiResponse response) : base(string.Format("[{0}] {1}", response.resultCode, 
            string.Join(", ", response.resultMessageList.Select(s => string.Format("{0}:{1}", s.code, s.message )))))
        {
            Response = response;
        }
    }
#if false
    public abstract class BizResponseResultBase
    {
        internal ShopBizApiResponse response;
        public ShopBizApiResponse GetResponse() => response;
    }
#endif
    [XmlRoot("shopBizApiResponse", Namespace = "http://rakuten.co.jp/rms/mall/shop/biz/api/model/resource")]
    public class ShopBizApiResponse<TResultMessage> where TResultMessage : ResultMessage
    {
        [XmlElement("resultCode", Namespace = "")]
        public string resultCode { get; set; }
        [XmlArray("resultMessageList", Namespace = "")]
        [XmlArrayItem("resultMessage", Namespace = "")]
        public List<TResultMessage> resultMessageList { get; set; }
    }
    [XmlRoot("shopBizApiResponse", Namespace = "http://rakuten.co.jp/rms/mall/shop/biz/api/model/resource")]
    public class ShopBizApiResponse : ShopBizApiResponse<ResultMessage>
    {
    }
    [XmlRoot("shopBizApiResponse", Namespace = "http://rakuten.co.jp/rms/mall/shop/biz/api/model/resource")]
    public class ShopBizApiResponseWithResult<TResult,TResultMessage> : ShopBizApiResponse<TResultMessage> where TResultMessage : ResultMessage 
    {
        [XmlElement("result", Namespace = "")]
        public TResult Result { get; set; }
    }
    [XmlRoot("shopBizApiResponse", Namespace = "http://rakuten.co.jp/rms/mall/shop/biz/api/model/resource")]
    public class ShopBizApiResponseWithResult<TResult> : ShopBizApiResponseWithResult<TResult,ResultMessage>
    {
    }
}
