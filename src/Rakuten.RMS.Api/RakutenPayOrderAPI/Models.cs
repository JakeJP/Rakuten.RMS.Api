using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using Rakuten.RMS.Api.JSON;

namespace Rakuten.RMS.Api.RakutenPayOrderAPI
{
    [DecodableObject]
    public class SearchOrderItemRequest
    {
        /// <summary>
        /// 100: 注文確認待ち
        /// 200: 楽天処理中
        /// 300: 発送待ち
        /// 400: 変更確定待ち
        /// 500: 発送済
        /// 600: 支払手続き中
        /// 700: 支払手続き済
        /// 800: キャンセル確定待ち
        /// 900: キャンセル確定
        /// </summary>
        public IList<int> orderProgressList { get; set; }
        public IList<int> subStatusIdList { get; set; }
        /// <summary>
        /// 以下のいずれか
        /// 1: 注文日
        /// 2: 注文確認日
        /// 3: 注文確定日
        /// 4: 発送日
        /// 5: 発送完了報告日
        /// 6: 決済確定日
        /// </summary>
        public int dateType { get; set; }
        [JsonConverter(typeof(DateTimeFormatConverter), "yyyy'-'MM'-'dd'T'HH':'mm':'ss+0900")]
        public DateTime startDatetime { get; set; }
        [JsonConverter(typeof(DateTimeFormatConverter), "yyyy'-'MM'-'dd'T'HH':'mm':'ss+0900")]
        public DateTime endDatetime { get; set; }
        public IList<int> orderTypeList { get; set; }
        /// 0: なし
        /// 1: 商品名
        /// 2: 商品番号
        /// 3: ひとことメモ
        /// 4: 注文者お名前
        /// 5: 注文者お名前フリガナ
        /// 6: 送付先お名前
        public int? searchKeywordType { get; set; }
        /// <summary>
        /// ・機種依存文字などの不正文字以外
        /// ・全角、半角にかかわらず32文字以下
        /// </summary>
        public string searchKeyword { get; set; }
        public PaginationRequestModel PaginationRequestModel { get; set; }
    }
    [DecodableObject]
    public class SearchOrderRequest : SearchOrderItemRequest
    {
        public int? settlementMethod { get; set; }
        public string deliveryName { get; set; }
        /// <summary>
        /// 以下のいずれか
        /// 0: お荷物伝票番号の指定の有無によらず取得
        /// 1: お荷物伝票番号が未指定のものだけを取得
        /// </summary>
        public int? shippingNumberBlankFlag { get; set; }
        /// <summary>
        /// 以下のいずれか
        /// 0: PC/モバイル
        /// 1: PC
        /// 2: モバイル
        /// </summary>
        public int? mailSendType { get; set; }
        /// <summary>
        /// 注文者メールアドレス 完全一致
        /// </summary>
        public string ordererMailAddress { get; set; }
        /// <summary>
        /// 電話番号種別
        /// 以下のいずれか
        /// 1: 注文者
        /// 2: 送付先
        /// </summary>
        public int? phoneNumberType { get; set; }
        /// <summary>
        /// 電話番号 完全一致
        /// </summary>
        public string phoneNumber { get; set; }
        /// <summary>
        /// 申込番号 完全一致
        /// </summary>
        public string reserveNumber { get; set; }
        /// <summary>
        /// 購入サイトリスト
        /// 0: すべて
        /// 1: PCで注文
        /// 2: モバイルで注文
        /// 3: スマートフォンで注文
        /// 4: タブレットで注文
        /// </summary>
        public int? purchaseSiteType { get; set; }
        /// <summary>
        /// あす楽希望フラグ
        /// 以下のいずれか
        /// 0: あす楽希望の有無によらず取得
        /// 1: あす楽希望のものだけを取得
        /// </summary>
        public int? asurakuFlag { get; set; }
        /// <summary>
        /// クーポン利用有無フラグ
        /// 以下のいずれか
        /// 0: クーポン利用の有無によらず取得
        /// 1: クーポン利用のものだけを取得
        /// </summary>
        public int? couponUseFlag { get; set; }
        /// <summary>
        /// 医薬品受注フラグ
        /// 以下のいずれか
        /// 0: 医薬品の有無によらず取得
        /// 1: 医薬品を含む注文だけを取得
        /// </summary>
        public int? drugFlag { get; set; }
        /// <summary>
        /// 海外かご注文フラグ
        /// 以下のいずれか
        /// 0: 海外カゴ注文の有無によらず取得
        /// 1: 海外カゴ注文のものだけを取得
        /// </summary>
        public int? overseasFlag { get; set; }
    }
    [DecodableObject]
    public class PaginationRequestModel
    {
        /// <summary>
        /// 1ページあたりの取得結果数 最大 1,000 件まで指定可能
        /// </summary>
        public int requestRecordsAmount { get; set; }
        /// <summary>
        /// リクエストページ番号
        /// </summary>
        public int requestPage { get; set; }
        public IList<SortModel> SortModelList { get; set; }
    }
    [DecodableObject]
    public class SortModel
    {
        /// <summary>
        /// 並び替え項目
        /// 以下のいずれか
        /// 1: 注文日時
        /// </summary>
        public int sortColumn { get; set; }
        /// <summary>
        /// 並び替え方法
        /// 以下のいずれか
        /// 1: 昇順（小さい順、古い順）
        /// 2: 降順（大きい順、新しい順）
        /// </summary>
        public int sortDirection { get; set; }
    }

    public class SearchOrderResponse
    {
        public IList<MessageModel> MessageModelList { get; set; }
        public IList<string> orderNumberList { get; set; }
        public PaginationResponseModel PaginationResponseModel { get; set; }
        public override string ToString()
        {
            if (MessageModelList != null)
                return string.Join(", ", MessageModelList.Select(m => string.Format("{0}:{1} - {2}", m.messageType, m.messageCode, m.message)));
            else
                return base.ToString();
        }
    }
    public class MessageModel
    {
        /// <summary>
        /// ・INFO
        /// ・ERROR
        /// ・WARNING
        /// </summary>
        public string messageType { get; set; }
        /// <summary>
        /// https://webservice.rms.rakuten.co.jp/merchant-portal/view?contents=/ja/common/1-1_service_index/rakutenpayorderapi/rakutenpaymsgcodereference
        /// </summary>
        public string messageCode { get; set; }
        public string message { get; set; }
    }
    public class PaginationResponseModel
    {
        /// <summary>
        /// 総結果数
        /// </summary>
        public int? totalRecordsAmount { get; set; }
        /// <summary>
        /// 総ページ数
        /// </summary>
        public int? totalPages { get; set; }
        /// <summary>
        /// リクエストページ番号
        /// リクエストされたページ数
        /// </summary>
        public int? requestPage { get; set; }

    }

    // GetOrder

    public class GetOrderResponse
    {
        public IList<OrderMessageModel> MessageModelList { get; set; }
        public IList<OrderModel> OrderModelList { get; set; }
    }
    [DecodableObject]
    public class OrderMessageModel : MessageModel
    {
        public string orderNumber { get; set; }
    }

    // ConfirmOrder
    public class OrderMessageResponse
    {
        public IList<OrderMessageModel> MessageModelList { get; set; }
        public override string ToString()
        {
            return string.Join(", ",
                MessageModelList.Select(m => string.Format("{0}:{1},{2}", m.orderNumber, m.messageCode, m.message)));
        }
    }

    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    [DecodableObject]
    public class UpdateOrderMemoRequest
    {
        /// <summary>
        /// 注文番号 
        /// </summary>
        public string orderNumber { get; set; }
        /// <summary>
        /// サブステータスID
        /// </summary>
        public long? subStatusId { get; set; }
        /// <summary>
        ///	配送区分
        ///	0: 選択なし
        ///	1: 普通
        ///	2: 冷蔵
        ///	3: 冷凍
        ///	4: その他1
        ///	5: その他2
        ///	6: その他3
        ///	7: その他4
        ///	8: その他5
        /// </summary>
        public long? deliveryClass { get; set; }
        /// <summary>
        /// お届け日指定     no Date	10	-	YYYY-MM-DD	2017-11-30
        /// </summary>
        [JsonConverter(typeof(DateTimeFormatConverter), "yyyy'-'MM'-'dd")]
        public DateTime? deliveryDate { get; set; }
        /// <summary>
        /// お届け時間帯
        /// 0: なし
        /// 1: 午前
        /// 2: 午後
        /// 9: その他
        /// h1h2: h1時-h2時(h1は7～24まで任意で数値指定可能。h2は07～24まで任意で数値指定可能)
        /// </summary>
        public int? shippingTerm { get; set; }
        /// <summary>
        /// ひとことメモ
        /// </summary>
        public string memo { get; set; }
        /// <summary>
        /// 担当者 
        /// </summary>
        [JsonProperty("operator")]
        public string Operator { get; set; }
        /// <summary>
        /// メール差込文(お客様へのメッセージ)
        /// </summary>
        public string mailPlugSentence { get; set; }
    }
    public class UpdateOrderMemoResponse
    {
        public List<Message> MessageModelList { get; set; }
        public class Message
        {
            public string messageType { get; set; }
            public string messageCode { get; set; }
            public string message { get; set; }
            public string orderNumber { get; set; }
        }
    }
    // UpdateOrderShipping
    public class UpdateOrderShippingResponse
    {
        public IList<OrderShippingMessageModel> MessageModelList { get; set; }
        public override string ToString()
        {
            if (MessageModelList == null)
                return base.ToString();
            return string.Join(", ", MessageModelList.Select(m=>
                string.Format("{0}: {1} {2} {3} {4}", m.messageType, m.messageCode, m.message, m.dataNumber, m.shippingDetailId )));
        }
    }
    [DecodableObject]
    public class BasketidModel
    {
        public long basketId { get; set; }
        public IList<ShippingModel> ShippingModelList { get; set; }
        [DecodableObject]
        public class ShippingModel
        {
            public long? shippingDetailId { get; set; }
            public string shippingNumber { get; set; }
            /// <summary>
            /// 1000: その他
            /// 1001: ヤマト運輸
            /// 1002: 佐川急便
            /// 1003: 日本郵便
            /// 1004: 西濃運輸
            /// 1005: 西部運輸
            /// 1006: 福山通運
            /// 1007: 名鉄運輸
            /// 1008: トナミ運輸
            /// 1009: 第一貨物
            /// 1010: 新潟運輸
            /// 1011: 中越運送
            /// 1012: 岡山県貨物運送
            /// 1013: 久留米運送
            /// 1014: 山陽自動車運送
            /// 1015: 日本トラック
            /// 1016: エコ配
            /// 1017: EMS
            /// 1018: DHL
            /// 1019: FedEx
            /// 1020: UPS
            /// 1021: 日本通運
            /// 1022: TNT
            /// 1023: OCS
            /// 1024: USPS
            /// 1025: SFエクスプレス
            /// 1026: Aramex
            /// 1027: SGHグローバル・ジャパン
            /// </summary>
            public string deliveryCompany { get; set; }
            [JsonConverter(typeof(DateTimeFormatConverter), "yyyy'-'MM'-'dd")]
            public DateTime? shippingDate { get; set; }
            /// <summary>
            /// 0: 発送情報を削除しない
            /// 1: 発送情報を削除する
            /// </summary>
            public int? shippingDeleteFlag { get; set; }
        }
    }
    public class OrderShippingMessageModel : MessageModel
    {
        /// <summary>
        /// データ番号 指定データ番号。上から１～
        /// </summary>
        public int? dataNumber { get; set; }
        /// <summary>
        /// 発送明細ID ・新規の場合は採番された番号 ・更新の場合は対象の番号 ※こちらは提供時期未定
        /// </summary>
        public long? shippingDetailId { get; set; }
    }


    // GetPayment
    public class GetPaymentResponse : OrderMessageResponse
    {
        public OrderModel OrderModel { get; set; }

    }
    public class OrderModelForPayment
    {
        public string orderNumber { get; set; }
        public List<PaymentModel> PaymentModelList { get; set; }
    }
    public class PaymentModel
    {
        /// <summary>
        /// 決済番号 
        ///  yes String	392	-		502763-20171027-00006701-1
        /// </summary>
        public string orderPaymentNumber { get; set; }
        /// <summary>
        /// 決済手段 
        /// 1:  クレジットカード
        /// 2:  代金引換
        /// 3:  後払い（選択制決済）
        /// 4:  ショッピングクレジット／ローン
        /// 5:  オートローン
        /// 6:  リース
        /// 7:  請求書払い
        /// 8:  ポイント
        /// 9:  銀行振込
        /// 12: Apple Pay
        /// 13: セブンイレブン（前払）
        /// 14: ローソン、郵便局ATM等（前払）
        /// 16: Alipay
        /// 17: PayPal
        /// 21: 後払い決済（楽天市場の共通決済）
        /// 27: Alipay（支付宝）	1
        /// </summary>
        public int paymentMethod { get; set; }
        /// <summary>
        /// 決済額
        /// </summary>
        public int paymentAmount { get; set; }
        /// <summary>
        /// 決済手数料 
        /// </summary>
        public int paymentCharge { get; set; }
        /// <summary>
        /// 決済ステータス
        /// 30000: 決済なし
        /// 30100: 決済手続き待ち
        /// 30110: 決済手続き待ち（前処理待ち）
        /// 30200: 決済手続き依頼
        /// 30300: 決済手続き完了
        /// 30400: 決済手続きNG
        /// 30500: 決済依頼
        /// 30600: 決済確定
        /// 30610: 決済確定（取消NG）
        /// 30700: 決済NG
        /// 30710: 決済NG（店舗引渡）
        /// 31100: 決済手続き取消中
        /// 31110: 決済手続き取消待ち
        /// 31120: 決済手続き取消待ち（前処理待ち）
        /// 31200: 決済手続き取消完了
        /// 31300: 決済手続き取消NG
        /// 31400: 決済取消中
        /// 31410: 決済取消待ち
        /// 31420: 決済取消待ち（前処理待ち）
        /// 31500: 決済取消完了
        /// 31800: 決済取消完了（チャージバック）
        /// </summary>
        public int paymentStatus { get; set; }
        /// <summary>
        /// 決済手続き依頼日時
        /// </summary>
        public DateTime? paymentProcReqDatetime { get; set; }
        /// <summary>
        /// 決済手続きNG日時 
        /// </summary>
        public DateTime? paymentProcNgDatetime { get; set; }
        /// <summary>
        /// 決済手続き完了日時
        /// </summary>
        public DateTime? paymentProcCmplDatetime { get; set; }
        /// <summary>
        /// 決済手続き取消NG日時 
        /// </summary>
        public DateTime? paymentProcCancelNgDate { get; set; }
        /// <summary>
        /// 決済手続き取消完了日時 
        /// </summary>
        public DateTime? paymentProcCancelCmplDatetime { get; set; }
        /// <summary>
        /// 決済依頼日時
        /// </summary>
        public DateTime? paymentReqDatetime { get; set; }
        /// <summary>
        /// 決済NG日時 
        /// </summary>
        public DateTime? paymentNgDatetime { get; set; }
        /// <summary>
        /// 決済確定日時 
        /// </summary>
        public DateTime? paymentFixDatetime { get; set; }
        /// <summary>
        /// 決済確定(取消NG)日時 
        /// </summary>
        public DateTime? paymentCancelNgDatetime { get; set; }
        /// <summary>
        /// 決済取消完了日時 
        /// </summary>
        public DateTime? paymentCancelCmplDatetime { get; set; }
        /// <summary>
        /// 決済取消確定日時 
        /// </summary>
        public DateTime? paymentCancelFixDatetime { get; set; }
        /// <summary>
        /// 支払予定日
        /// </summary>
        public DateTime? payExpectDate { get; set; }
        /// <summary>
        /// マイナス支払予定日 
        /// </summary>
        public DateTime? minusPayExpectDate { get; set; }
        /// <summary>
        /// 決済機関連携番号 
        /// </summary>
        public List<string> paymentOrganizationLinkageNumberList { get; set; }
        /// <summary>
        /// カード決済モデル 
        /// </summary>
        public PaymentCardModel PaymentCardModel { get; set; }
        /// <summary>
        /// マルチ決済モデル 
        /// </summary>
        public PaymentMultiModel PaymentMultiModel { get; set; }
        /// <summary>
        /// 銀行振込決済モデル 
        /// </summary>
        public PaymentBankModel PaymentBankModel { get; set; }
        /// <summary>
        /// 後払い決済モデル 
        /// </summary>
        public PaymentPayAfterModel PaymentPayAfterModel { get; set; }
        /// <summary>
        /// 返金モデルリスト 
        /// </summary>
        public List<RefundModel> RefundModelList { get; set; }
        /// <summary>
        /// 負担金情報モデルリスト 
        /// </summary>
        public List<AdditionalFeeModel> AdditionalFeeModelList { get; set; }
        /// <summary>
        /// PayPal決済モデル 
        /// </summary>
        public PaymentPaypalModel PaymentPaypalModel { get; set; }


    }
    public class PaymentCardModel
    {
        /// <summary>
        /// 種類
        /// </summary>
        public string cardName { get; set; }
        /// <summary>
        /// 有効期限 
        /// </summary>
        public string cardYm { get; set; }
        /// <summary>
        /// 名義人 
        /// </summary>
        public string cardOwner { get; set; }
        /// <summary>
        /// 番号
        /// </summary>
        public string cardNumber { get; set; }
        /// <summary>
        /// 支払方法
        /// 0: 一括払い
        /// 1: リボ払い
        /// 2: 分割払い
        /// 3: その他払い
        /// 4: ボーナス一括払い
        /// </summary>
        public int cardPayType { get; set; }
        /// <summary>
        /// 支払回数 
        /// 103:  3回払い
        /// 105:  5回払い
        /// 106:  6回払い
        /// 110: 10回払い
        /// 112: 12回払い
        /// 115: 15回払い
        /// 118: 18回払い
        /// 120: 20回払い
        /// 124: 24回払い
        /// </summary>
        public string cardInstallmentDesc { get; set; }
    }
    public class PaymentMultiModel
    {
        /// <summary>
        /// 取引日時 
        /// </summary>
        public DateTime? eventDatetime { get; set; }
        /// <summary>
        /// 収納番号
        /// </summary>
        public string rcvgNumber { get; set; }
        /// <summary>
        /// 払込票 
        /// </summary>
        public string payInfoUrl { get; set; }
        /// <summary>
        /// 決済開始URL
        /// </summary>
        public string payStartUrl { get; set; }
    }
    public class PaymentBankModel
    {
        /// <summary>
        /// 振込日
        /// </summary>
        public DateTime? transferDate { get; set; }
        /// <summary>
        /// 振込人名カナ
        /// </summary>
        public string transferNameKana { get; set; }

    }
    public class PaymentPayAfterModel
    {
        /// <summary>
        /// 事業者名
        /// </summary>
        public string rcvgAgcyTypeName { get; set; }
        /// <summary>
        /// お問い合わせ番号
        /// </summary>
        public string rcvgNumber { get; set; }

    }
    public class AdditionalFeeModel
    {
        /// <summary>
        /// 負担金ID
        /// </summary>
        long additionalFeeId { get; set; }
        /// <summary>
        /// 負担金科目 
        /// 1: 後払い手数料 2: チャージバック手数料
        /// </summary>
        public int additionalFeeType { get; set; }
        /// <summary>
        /// 負担者
        /// 1: 注文者
        /// 2: 店舗
        /// </summary>
        public int payFrom { get; set; }
        /// <summary>
        /// 負担金発生日時
        /// </summary>
        public DateTime? additionalFeeOccurDatetime { get; set; }
        /// <summary>
        /// 負担金
        /// </summary>
        public int additionalFeeOccurAmount { get; set; }
        /// <summary>
        /// 負担金税率
        /// </summary>
        public decimal additionalFeeTaxRate { get; set; }
    }
    public class RefundModel
    {
        /// <summary>
        /// 決済額
        /// </summary>
        public int paymentAmount { get; set; }
        /// <summary>
        /// 決済ステータス
        /// </summary>
        public int paymentStatus { get; set; }
        /// <summary>
        /// 決済手続き完了日時
        /// </summary>
        public DateTime? paymentProcCmplDatetime { get; set; }
        /// <summary>
        /// 決済依頼日時
        /// </summary>
        public DateTime? paymentReqDatetime { get; set; }
        /// <summary>
        /// 決済確定日時
        /// </summary>
        public DateTime? paymentFixDatetime { get; set; }
        /// <summary>
        /// 支払予定日
        /// </summary>
        public DateTime? payExpectDate { get; set; }
    }
    public class PaymentPaypalModel
    {
        /// <summary>
        /// 取引日時
        /// </summary>
        public DateTime? eventDate { get; set; }
        /// <summary>
        /// 請求書ID
        /// </summary>
        public string billId { get; set; }
    }
    //
    public class GetSubStatusListResponse
    {
        public IList<MessageModel> MessageModelList { get; set; }
        public IList<StatusModel> StatusModelList { get; set; }
    }
    public class StatusModel
    {
        public int orderProgress { get; set; }
        public IList<SubStatusModel> SubStatusModelList { get; set; }
    }
    public class SubStatusModel
    {
        public int subStatusId { get; set; }
        public string subStatusName { get; set; }
        public int? orderby { get; set; }
    }


    // UpdateOrderShippingAsync
    public class UpdateOrderShippingAsyncResponse
    {
        public IList<MessageModel> MessageModelList { get; set; }
        public class MessageModel : OrderMessageModel
        {
            public string requestId { get; set; }
            public int? dataNumber { get; set; }
            public long? shippingDetailId { get; set; }
        }
    }

    public class OrderShippingModel
    {
        public string orderNumber { get; set; }
        public IList<BasketidModel> BasketidModelList { get; set; }
    }

    public class UpdateOrderShippingResultResponse
    {
        public List<ResultShippingModel> ResultShippingModelList { get; set; }
    }
    public class ResultShippingModel
    {
        public string orderNumber { get; set; }
        public List<OrderShippingMessageModel> MessageModelList { get; set; }
    }


    /// <summary>
    /// Level 5: skuModel
    /// </summary>
    public class SkuModel
    {
        /// <summary>
        /// SKU管理番号
        /// SKU移行前の注文の場合、値は空になります。
        /// ※Request Parameterの「version」に「7」以降の値を指定すると取得可能
        /// </summary>
        public string variantId { get; set; }
        /// <summary>
        /// システム連携用SKU番号
        /// SKU移行前の注文の場合、値は空になります。
        /// ※Request Parameterの「version」に「7」以降の値を指定すると取得可能
        /// </summary>
        public string merchantDefinedSkuId { get; set; }
        /// <summary>
        /// SKU情報
        /// 
        /// 以下のルールで値が入ります。
        /// SKU移行前注文：値は空になります。
        /// SKU移行後注文：バリエーション項目名・バリエーション選択肢（旧・項目選択肢別在庫情報）が入ります。
        /// 項目選択肢情報は入りません。Level 4: ItemModel > selectedChoiceにて取得可能です。 　 　　 　　　 　　　 　　 　　 　　　 　　　 　　 　　 　　　 　　　 　　 　
        /// 商品種別 内容
        /// シングルSKU 該当項目は無い為、データ無し
        /// マルチSKU  バリエーション項目名とバリエーション選択肢。
        /// 下記のフォーマットで返却されます。
        /// バリエーション項目名:バリエーション選択肢
        /// ※Request Parameterの「version」に「7」以降の値を指定すると取得可能
        /// </summary>
        public string skuInfo { get; set; }
    }


    public class UpdateOrderRemarksResponse
    {
        public class Message
        {
            public string messageType { get; set; }
            public string messageCode { get; set; }
            public string message { get; set; }
            public string orderNumber { get; set; }
        }

        public List<Message> MessageModelList { get; set; }
    }

    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    [DecodableObject]
    public class OrderSenderRequest
    {
        public string orderNumber { get; set; }
        public int? reductionReason { get; set; }
        public int? taxRecalcFlag { get; set; }
        public WrappingModel WrappingModel1 { get; set; }
        public WrappingModel WrappingModel2 { get; set; }
        public IList<PackageModelToUpdate> PackageModelList { get; set; }
        public IList<CouponModelBase> CouponModelList { get; set; }
        public int? afterSettlementMethodCode { get; set; }

        [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
        [DecodableObject]
        public class PackageModelToUpdate
        {
            /// <summary>
            /// 送付先ID
            /// </summary>
            public long basketId { get; set; }
            /// <summary>
            /// 送料
            /// </summary>
            public int? postagePrice { get; set; }
            /// <summary>
            /// 送料税率
            /// </summary>
            public decimal postageTaxRate { get; set; }
            /// <summary>
            /// 代引料
            /// </summary>
            public int? deliveryPrice { get; set; }
            /// <summary>
            /// 代引料税率
            /// </summary>
            public decimal deliveryTaxRate { get; set; }
            /// <summary>
            /// 消費税
            /// </summary>
            public int? goodsTax { get; set; }

            public string noshi { get; set; }
            /// <summary>
            /// 0: 送付先モデルを削除しない
            /// 1: 送付先モデルを削除する
            /// </summary>
            public int? packageDeleteFlag { get; set; }
            /// <summary>
            /// 送付者モデル
            /// </summary>
            public SenderModelToUpdate SenderModel { get; set; }
            /// <summary>
            /// 商品モデルリスト
            /// </summary>
            public IList<ItemModelToUpdate> ItemModelList { get; set; }
        }
    }
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class UpdateOrderRemarksRequest
    {
        public string orderNumber { get; set; }
        public int? giftCheck { get; set; }
        public string remarks { get; set; }
    }
}
