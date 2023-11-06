using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Rakuten.RMS.Api.JSON;
using Rakuten.RMS.Api.NavigationAPI20;
using Rakuten.RMS.Api.RakutenPayOrderAPI;

namespace Rakuten.RMS.Api.PurchaseItemAPI
{
    /// <summary>
    /// 購入商品API（PurchaseItemAPI）
    /// </summary>
    public class PurchaseItemAPI : RakutenApiJsonClientBase
    {
        internal PurchaseItemAPI(ServiceProvider provider) : base(provider)
        {
        }
        /// <summary>
        /// 注文検索
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public SearchOrderResponse SearchOrderItem(SearchOrderItemRequest request)
            => PostRequest<SearchOrderResponse>("https://api.rms.rakuten.co.jp/es/2.0/purchaseItem/searchOrderItem/", request);
        /// <summary>
        /// 購入された商品に関連する情報の取得
        /// </summary>
        /// <param name="orderNumberList"></param>
        /// <returns></returns>
        public GetOrderResponse GetOrderItem( IList<string> orderNumberList)
            => PostRequest<GetOrderResponse>("https://api.rms.rakuten.co.jp/es/2.0/purchaseItem/getOrderItem/",
                new { orderNumberList = orderNumberList });
    }
}
