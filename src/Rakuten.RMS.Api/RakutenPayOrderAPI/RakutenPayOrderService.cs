using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using Rakuten.RMS.Api.JSON;

namespace Rakuten.RMS.Api.RakutenPayOrderAPI
{
    public class RakutenPayOrderService : RakutenApiJsonClientBase
    {
        internal RakutenPayOrderService(ServiceProvider provider) : base(provider) { }

        public SearchOrderResponse SearchOrder(SearchOrderRequest request)
        {
            return PostRequest<SearchOrderResponse>("https://api.rms.rakuten.co.jp/es/2.0/order/searchOrder/", request);
        }
        /// <summary>
        /// version:
        /// 3: 消費税増税対応
        /// 4: 共通の送料込みライン対応
        /// 5: 領収書、前払い期限版
        /// 6: 顧客・配送対応注意表示詳細対応
        /// 7: SKU対応
        /// </summary>
        /// <param name="orderNumberList"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        public GetOrderResponse GetOrder(IEnumerable<string> orderNumberList, int version = 7)
        {
            return PostRequest<GetOrderResponse>(
                "https://api.rms.rakuten.co.jp/es/2.0/order/getOrder/",
                new { orderNumberList = orderNumberList, version = version.ToString() });
        }
        /// <summary>
        /// この機能を利用すると、楽天ペイ注文の「注文確認」を行うことができます。こちらは同期処理となります。
        /// </summary>
        /// <param name="orderNumberList">注文番号リスト 最大 100 件まで指定可能</param>
        /// <returns></returns>
        public IEnumerable<OrderMessageModel> ConfirmOrder(IEnumerable<string> orderNumberList)
        {
            var res = PostRequest<ConfirmOrderResponse>("https://api.rms.rakuten.co.jp/es/2.0/order/confirmOrder/",
                new { orderNumberList = orderNumberList });
            return res?.MessageModelList;
        }
        /// <summary>
        /// １注文の配送情報の更新が可能。発送が完了した注文の、伝票番号、出荷日を登録して、注文を締める。
        /// </summary>
        /// <param name="orderNumber"></param>
        /// <param name="BasketidModelList"></param>
        /// <returns></returns>
        public IEnumerable<OrderShippingMessageModel> UpdateOrderShipping(string orderNumber, IEnumerable<BasketidModel> BasketidModelList)
        {
            return PostRequest<UpdateOrderShippingResponse>("https://api.rms.rakuten.co.jp/es/2.0/order/updateOrderShipping/",
                new { orderNumber = orderNumber, BasketidModelList = BasketidModelList },
                dateFormtString: "yyyy'-'MM'-'dd")?.MessageModelList;
        }
        /// <summary>
        /// 以下の情報を更新可能
        /// ・配送方法（宅急便・国際配送・ゆうパック・自社配送・バイク便・その他配送方法１・その他配送方法２・その他配送方法３
        /// </summary>
        /// <param name="orderNumber"></param>
        /// <param name="deliveryName"></param>
        public IEnumerable<OrderMessageModel> UpdateOrderDelivery(string orderNumber, string deliveryName)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 以下の情報を更新可能
        /// ・注文者 - 名前
        /// ・注文者 - フリガナ
        /// ・注文者 - 住所
        /// ・注文者 - 電話番号
        /// ・注文者 - メールアドレス
        /// ・注文者 - 性別
        /// ・注文者 - 誕生日
        /// </summary>
        /// <param name="orderNumber"></param>
        /// <param name="ordererModel"></param>
        /// <returns></returns>
        public IEnumerable<OrderMessageModel> UpdateOrderOrderer(string orderNumber, OrdererModel ordererModel)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 以下の情報を更新可能・備考・ギフト配送（希望する・希望しない）
        /// </summary>
        /// <param name="orderNumber">注文番号</param>
        /// <param name="remarks">コメント</param>
        /// <param name="giftCheck">ギフト配送 0: 希望しない 1: 希望する</param>
        public IEnumerable<OrderMessageModel> UpdateOrderRemarks(string orderNumber, string remarks, int giftCheck = -1)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<OrderMessageModel> UpdateOrderSender()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 以下の情報を更新可能
        /// ・ひとことメモ
        /// ・担当者
        /// ・利用サービス名（配送区分）
        /// ・お客様へのメッセージ
        /// ・お届け日指定
        /// ・お届け時間帯
        /// ・サブステータスID
        /// </summary>
        public void UpdateOrderMemo()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 注文番号を指定して、支払明細情報を取得する。
        /// </summary>
        /// <param name="orderNumber"></param>
        /// <returns></returns>
        public GetPaymentResponse GetPayment(string orderNumber)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 次のステータスの注文にのみ有効
        /// ・100: 注文確認待ち
        /// ・200: 楽天処理中
        /// ・300: 発送待ち
        /// </summary>
        /// <param name="orderNumber">注文番号 キャンセル申請対象の受注番号。</param>
        /// <param name="inventoryRestoreType">在庫連動区分 0: 商品設定に合わせる 1: 在庫連動する 2: 在庫連動しない</param>
        /// <param name="changeReasonDetailApply">キャンセル理由
        /// (お客様都合による)
        /// 1: キャンセル
        /// 2: 受取後の返品
        /// 3: 長期不在による受取拒否
        /// 4: 未入金
        /// 5: 代引決済の受取拒否
        /// 6: その他
        /// (店舗都合による)
        /// 8: 欠品
        /// 10: その他
        /// 13: 発送遅延
        /// 14: 顧客・配送対応注意表示
        /// 15: 返品（破損・品間違い） </param>
        /// <returns></returns>
        public IEnumerable<OrderMessageModel> CancelOrder(string orderNumber, int inventoryRestoreType, int changeReasonDetailApply)
        {
            throw new NotImplementedException();
        }
        public GetSubStatusListResponse GetSubStatusList()
        {
            return PostRequest<GetSubStatusListResponse>("https://api.rms.rakuten.co.jp/es/2.0/order/getSubStatusList/", null);
        }
        public IEnumerable<OrderMessageModel> UpdateOrderSubStatus(int subStatusId, IEnumerable<string> orderNumberList)
        {
            return PostRequest<UpdateOrderSubStatusResponse>("https://api.rms.rakuten.co.jp/es/2.0/order/updateOrderSubStatus/",
                new { subStatusId = subStatusId, orderNumberList = orderNumberList })?.MessageModelList;
        }
        /// <summary>
        /// 発送完了報告（非同期）
        /// 「発送完了報告」処理を複数件一括で非同期更新する。
        ///  機能呼び出しの返却値としてrequestId が発行され、この値を元に発送完了報告（非同期結果確認）を実行し、処理結果を確認する。
        /// </summary>
        public UpdateOrderShippingAsyncResponse UpdateOrderShippingAsync(IEnumerable<OrderMessageModel> messageModelList)
        {
            return PostRequest<UpdateOrderShippingAsyncResponse>("https://api.rms.rakuten.co.jp/es/2.0/order/updateOrderShippingAsync/",
                new { OrderShippingModelList = messageModelList });
        }
        /// <summary>
        /// 注文キャンセル（発送後）
        /// 発送完了報告後の受注に対してキャンセルを要求する。
        /// 次のステータスの注文にのみ有効
        /// ・500: 発送済
        /// ・600: 支払手続き中
        /// ・700: 支払手続き済
        /// ・800: キャンセル確定待ち
        /// ※キャンセル確定までを一括で行いますので、商品が返品されたことを確認後に実施してください。 
        /// </summary>
        /// <param name="orderNumber">注文番号 キャンセル申請対象の受注番号。</param>
        /// <param name="inventoryRestoreType">在庫連動区分
        /// 以下のいずれか
        /// 0: 商品設定に合わせる
        /// 1: 在庫連動する
        /// 2: 在庫連動しない</param>
        /// <param name="changeReasonDetailApply">
        /// キャンセル理由
        /// 以下のいずれか
        /// (お客様都合による)
        /// 1: キャンセル
        /// 2: 受取後の返品
        /// 3: 長期不在による受取拒否
        /// 4: 未入金
        /// 5: 代引決済の受取拒否
        /// 6: その他
        /// (店舗都合による)
        /// 8: 欠品
        /// 10: その他
        /// 13: 発送遅延
        /// 14: 顧客・配送対応注意表示
        /// 15: 返品（破損・品間違い） 
        /// </param>
        public IEnumerable<OrderMessageModel> CancelOrderAfterShipping(string orderNumber, int inventoryRestoreType, int changeReasonDetailApply)
        {
            return PostRequest<CancelOrderAfterShippingResponse>("https://api.rms.rakuten.co.jp/es/2.0/order/cancelOrderAfterShipping/",
                new
                {
                    orderNumber = orderNumber,
                    inventoryRestoreType = inventoryRestoreType,
                    changeReasonDetailApply = changeReasonDetailApply
                })?.MessageModelList;
        }
    }
}
