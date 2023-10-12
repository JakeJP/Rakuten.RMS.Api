using System;
using System.Collections.Generic;

namespace Rakuten.RMS.Api.RakutenPayOrderAPI
{

    public class SearchOrderRequest
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
        public List<int> orderProgressList { get; set; }
        public List<int> subStatusIdList { get; set; }
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
        public DateTime startDatetime { get; set; }
        public DateTime endDatetime { get; set; }
        public List<int> orderTypeList { get; set; }
        public int? settlementMethod { get; set; }
        public string deliveryName { get; set; }
        /// <summary>
        /// 以下のいずれか
        /// 0: お荷物伝票番号の指定の有無によらず取得
        /// 1: お荷物伝票番号が未指定のものだけを取得
        /// </summary>
        public int? shippingNumberBlankFlag { get; set; }
        /// 以下のいずれか
        /// 0: なし
        /// 1: 商品名
        /// 2: 商品番号
        /// 3: ひとことメモ
        /// 4: 注文者お名前
        /// 5: 注文者お名前フリガナ
        /// 6: 送付先お名前
        public int? searchKeywordType { get; set; }
        /// <summary>
        /// 以下の入力チェックが適用されます
        /// ・機種依存文字などの不正文字以外
        /// ・全角、半角にかかわらず32文字以下
        /// </summary>
        public string searchKeyword { get; set; }
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
        public PaginationRequestModel PaginationRequestModel { get; set; }
    }
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
        public List<SortModel> SortModelList { get; set; }
    }
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
        public List<MessageModel> MessageModelList { get; set; }
        public List<string> orderNumberList { get; set; }
        public PaginationResponseModel PaginationResponseModel { get; set; }
    }
    public class MessageModel
    {
        /// <summary>
        /// 以下のいずれか
        /// ・INFO
        /// ・ERROR
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
        public int totalRecordsAmount { get; set; }
        /// <summary>
        /// 総ページ数
        /// </summary>
        public int totalPages { get; set; }
        /// <summary>
        /// リクエストページ番号
        /// リクエストされたページ数
        /// </summary>
        public int requestPage { get; set; }

    }

    // GetOrder

    public class GetOrderResponse
    {
        public List<OrderMessageModel> MessageModelList { get; set; }
        public List<OrderModel> OrderModelList { get; set; }
    }
    public class OrderMessageModel : MessageModel
    {
        public string orderNumber { get; set; }
    }
    public class OrderModel
    {
        public string orderNumber { get; set; }
        public int orderProgress { get; set; }
        public int? subStatusId { get; set; }
        public string subStatusName { get; set; }
        public DateTime orderDatetime { get; set; }
        public DateTime? shopOrderCfmDatetime { get; set; }
        public DateTime? orderFixDatetime { get; set; }
        public DateTime? shippingInstDatetime { get; set; }
        public DateTime? shippingCmplRptDatetime { get; set; }
        public DateTime? cancelDueDate { get; set; }
        public DateTime? deliveryDate { get; set; }
        public int? shippingTerm { get; set; }
        public string remarks { get; set; }
        public int giftCheckFlag { get; set; }
        public int severalSenderFlag { get; set; }
        public int equalSenderFlag { get; set; }
        public int isolatedIslandFlag { get; set; }
        public int rakutenMemberFlag { get; set; }
        public int carrierCode { get; set; }
        public int emailCarrierCode { get; set; }
        public int orderType { get; set; }
        public string reserveNumber { get; set; }
        public int? reserveDeliveryCount { get; set; }
        public int cautionDisplayType { get; set; }
        public int rakutenConfirmFlag { get; set; }
        public int goodsPrice { get; set; }
        public int goodsTax { get; set; }
        public int postagePrice { get; set; }
        public int deliveryPrice { get; set; }
        /// <summary>
        /// version=2
        /// </summary>
        public int paymentCharge { get; set; }
        public int totalPrice { get; set; }
        public int requestPrice { get; set; }
        public int couponAllTotalPrice { get; set; }
        public int couponShopPrice { get; set; }
        public int couponOtherPrice { get; set; }
        /// <summary>
        /// versiion=2
        /// </summary>
        public int additionalFeeOccurAmountToUser { get; set; }
        /// <summary>
        /// versiion=2
        /// </summary>
        public int additionalFeeOccurAmountToShop { get; set; }
        public int asurakuFlag { get; set; }
        public int drugFlag { get; set; }
        public int dealFlag { get; set; }
        public int membershipType { get; set; }
        public string memo { get; set; }
        public string _operator { get; set; }
        public string mailPlugSentence { get; set; }
        public int modifyFlag { get; set; }
        public int isTaxRecalc { get; set; }
        public OrdererModel OrdererModel { get; set; }
        public SettlementModel SettlementModel { get; set; }
        public DeliveryModel DeliveryModel { get; set; }
        public PointModel PointModel { get; set; }
        public WrappingModel WrappingModel1 { get; set; }
        public WrappingModel WrappingModel2 { get; set; }
        public List<PackageModel> PackageModelList { get; set; }
        public List<CouponModel> CouponModelList { get; set; }
        public List<ChangeReasonModel> ChangeReasonModelList { get; set; }
    }
    public class OrdererModel
    {
        public string zipCode1 { get; set; }
        public string zipCode2 { get; set; }
        public string prefecture { get; set; }
        public string city { get; set; }
        public string subAddress { get; set; }
        public string familyName { get; set; }
        public string firstName { get; set; }
        public string familyNameKana { get; set; }
        public string firstNameKana { get; set; }
        public string phoneNumber1 { get; set; }
        public string phoneNumber2 { get; set; }
        public string phoneNumber3 { get; set; }
        public string emailAddress { get; set; }
        public string sex { get; set; }
        public int? birthYear { get; set; }
        public int? birthMonth { get; set; }
        public int? birthDay { get; set; }
    }
    public class SettlementModel
    {
        public string settlementMethod { get; set; }
        /// <summary>
        /// version=2
        /// </summary>
        public int rpaySettlementFlag { get; set; }
        public string cardName { get; set; }
        public string cardNumber { get; set; }
        public string cardOwner { get; set; }
        public string cardYm { get; set; }
        public int? cardPayType { get; set; }
        public string cardInstallmentDesc { get; set; }
    }
    public class DeliveryModel
    {
        /// <summary>
        /// 以下のいずれか
        /// ・宅配便
        /// ・小型宅配便
        /// ・大型宅配便
        /// ・クール便
        /// ・メール便
        /// ・国際配送
        /// ・コンビニ受取
        /// ・ロッカー受取
        /// ・店頭受取
        /// ・発送を伴わない
        /// ・郵便局受取
        /// </summary>
        public string deliveryName { get; set; }
        /// <summary>
        /// 配送区分
        /// 0: 選択なし
        /// 1: 普通
        /// 2: 冷蔵
        /// 3: 冷凍
        /// 4: その他１
        /// 5: その他２
        /// 6: その他３
        /// 7: その他４
        /// 8: その他５
        /// </summary>
        public int? deliveryClass { get; set; }
    }
    public class PointModel
    {
        /// <summary>
        /// ポイント利用額
        /// </summary>
        public int usedPoint { get; set; }
    }
    public class WrappingModel
    {
        /// <summary>
        /// 以下のいずれか
        /// 1: 包装紙
        /// 2: リボン
        /// </summary>
        public int title { get; set; }
        public string name { get; set; }
        public int? price { get; set; }
        /// <summary>
        /// 税込別
        /// 0: 税別
        /// 1: 税込
        /// </summary>
        public int includeTaxFlag { get; set; }
        /// <summary>
        /// ラッピング削除フラグ
        /// </summary>
        public int deleteWrappingFlag { get; set; }
    }
    public class PackageModel
    {
        /// <summary>
        /// 送付先ID
        /// </summary>
        public int basketId { get; set; }
        /// <summary>
        /// 送料
        /// </summary>
        public int postagePrice { get; set; }
        /// <summary>
        /// 代引料
        /// </summary>
        public int deliveryPrice { get; set; }
        /// <summary>
        /// 消費税
        /// </summary>
        public int goodsTax { get; set; }
        /// <summary>
        /// 商品合計金額
        /// </summary>
        public int goodsPrice { get; set; }
        /// <summary>
        /// 合計金額
        /// 送付先に紐付く 商品代金((価格×個数)の商品合計)+のし・ラッピング代+送料+消費税+代引手数料
        /// ※未確定の場合、-9999になります。
        /// </summary>
        public int totalPrice { get; set; }
        public string noshi { get; set; }
        /// <summary>
        /// 0: 送付先モデルを削除しない
        /// 1: 送付先モデルを削除する
        /// </summary>
        public int packageDeleteFlag { get; set; }
        /// <summary>
        /// 送付者モデル
        /// </summary>
        public SenderModel SenderModel { get; set; }
        /// <summary>
        /// 商品モデルリスト
        /// </summary>
        public List<ItemModel> ItemModelList { get; set; }
        /// <summary>
        /// 発送モデルリスト
        /// </summary>
        public List<ShippingModel> ShippingModelList { get; set; }
        /// <summary>
        /// コンビニ配送モデル 
        /// 配送方法がコンビニ、郵便局受取の場合、参照可能
        /// </summary>
        public DeliveryCVSModel DeliveryCvsModel { get; set; }
    }
    public class SenderModel
    {
        public string zipCode1 { get; set; }
        public string zipCode2 { get; set; }
        public string prefecture { get; set; }
        public string city { get; set; }
        public string subAddress { get; set; }
        public string familyName { get; set; }
        public string firstName { get; set; }
        public string familyNameKana { get; set; }
        public string firstNameKana { get; set; }
        public string phoneNumber1 { get; set; }
        public string phoneNumber2 { get; set; }
        public string phoneNumber3 { get; set; }
        /// <summary>
        /// version=2
        /// </summary>
        public int isolatedIslandFlag { get; set; }
    }
    public class ItemModel
    {
        public int itemDetailId { get; set; }
        public string itemName { get; set; }
        public int itemId { get; set; }
        /// <summary>
        /// 商品番号
        /// 項目選択肢別在庫が指定された商品の場合、以下のルールで値が表示されます
        ///     SKU移行前注文：商品番号（店舗様が登録した番号）＋項目選択肢ID（横軸）＋項目選択肢ID（縦軸）
        ///     SKU移行後注文：商品番号（店舗様が登録した番号）
        /// </summary>
        public string itemNumber { get; set; }
        public string manageNumber { get; set; }
        public int price { get; set; }
        public int units { get; set; }
        public int includePostageFlag { get; set; }
        /// <summary>
        /// 0: 税別
        /// 1: 税込み
        /// </summary>
        public int includeTaxFlag { get; set; }
        /// <summary>
        /// 0: 代引手数料別
        /// 1: 代引手数料込み
        /// </summary>
        public int includeCashOnDeliveryPostageFlag { get; set; }
        public string selectedChoice { get; set; }
        public int pointRate { get; set; }
        public int pointType { get; set; }
        public int inventoryType { get; set; }
        public string delvdateInfo { get; set; }
        /// <summary>
        /// 在庫連動オプション
        /// 0: 商品の設定に従う
        /// 1: 在庫連動する
        /// 2: 在庫連動しない
        /// </summary>
        public int restoreInventoryFlag { get; set; }
        /// <summary>
        /// version=2
        /// </summary>
        public int dealFlag { get; set; }
        /// <summary>
        /// version=2
        /// </summary>
        public int drugFlag { get; set; }
        /// <summary>
        /// 商品削除フラグ
        /// 0: 商品を削除しない
        /// 1: 商品を削除する
        /// </summary>
        public int deleteItemFlag { get; set; }
        /// <summary>
        /// 商品税率
        /// </summary>
        public decimal taxRate { get; set; }
        /// <summary>
        /// 商品毎税込価格
        /// ・税込商品の場合：
        /// 商品単価＝商品毎税込価格
        /// ・税別商品の場合：
        /// 商品単価＝税別価格
        /// 商品毎税込単価＝税込価格（商品単価* (1+税率））
        /// 端数処理は、店舗設定に準ずる
        /// </summary>
        public int priceTaxIncl { get; set; }
        /// <summary>
        /// 以下のいずれか
        /// 0: 単品配送ではない
        /// 1: 単品配送である
        /// ※Request Parameterの「version」に「4」以降の値を指定すると取得可能
        /// </summary>
        public int isSingleItemShipping { get; set; }
        public List<SkuModel> SkuModelList { get; set; }
    }
    public class ShippingModel
    {
        public long shippingDetailId { get; set; }
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
        public string deliveryCompanyName { get; set; }
        public DateTime? shippingDate { get; set; }
    }
    public class DeliveryCVSModel
    {
        /// <summary>
        /// 1: ファミリーマート
        /// 20: ミニストップ
        /// 40: サークルK
        /// 41: サンクス
        /// 50: ローソン
        /// 60: 郵便局
        /// 70: スリーエフ
        /// 71: エブリワン
        /// 72: ココストア
        /// 74: セーブオン
        /// 80: デイリーヤマザキ
        /// 81: ヤマザキデイリーストア
        /// 82: ニューヤマザキデイリーストア
        /// 85: ニューデイズ
        /// 90: ポプラ
        /// 91: くらしハウス
        /// 92: スリーエイト
        /// 93: 生活彩家
        /// </summary>

        public int? cvsCode { get; set; }
        public string storeGenreCode { get; set; }
        public string storeCode { get; set; }
        public string storeName { get; set; }
        public string storeZip { get; set; }
        public string storePrefecture { get; set; }
        public string storeAddress { get; set; }
        public string areaCode { get; set; }
        public string depo { get; set; }

        public string openTime { get; set; }
        public string closeTime { get; set; }
        public string cvsRemarks { get; set; }

    }
    public class CouponModel
    {
        public string couponCode { get; set; }
        public int itemId { get; set; }
        public string couponName { get; set; }
        public string couponSummary { get; set; }
        public string couponCapital { get; set; }
        public DateTime expiryDate { get; set; }
        public int couponPrice { get; set; }
        public int couponUnit { get; set; }
        /// <summary>
        /// クーポン利用金額
        /// クーポン割引単価 × クーポン利用数
        /// ※クーポン割引単価もしくはクーポン利用数がnullの場合、-9999になります。
        /// </summary>
        public int couponTotalPrice { get; set; }
        /// <summary>
        /// 商品明細ID
        /// </summary>
        public long itemDetailId { get; set; }
    }
    public class ChangeReasonModel
    {
        public long changeId { get; set; }
        public int? changeType { get; set; }
        public int? changeTypeDetail { get; set; }
        public int? changeReason { get; set; }
        public int? changeReasonDetail { get; set; }
        public DateTime? changeApplyDatetime { get; set; }
        public DateTime? changeFixDatetime { get; set; }
        public DateTime? changeCmplDatetime { get; set; }

    }

    // ConfirmOrder
    public class ConfirmOrderResponse
    {
        public List<OrderMessageModel> MessageModelList { get; set; }
    }
    ///

    // UpdateOrderShipping
    public class UpdateOrderShippingResponse
    {
        public List<OrderShippingMessageModel> MessageModelList { get; set; }
    }

    public class BasketidModel
    {
        public int basketId { get; set; }
        public List<ShippingModel> ShippingModelList { get; set; }
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
    public class GetPaymentResponse
    {
        public List<OrderMessageModel> MessageModelList { get; set; }
        public OrderModel OrderModel { get; set; }

    }
    //
    public class GetSubStatusListResponse
    {
        public List<MessageModel> MessageModelList { get; set; }
        public List<StatusModel> StatusModelList { get; set; }
    }
    public class StatusModel
    {
        public int orderProgress { get; set; }
        public List<SubStatusModel> SubStatusModelList { get; set; }
    }
    public class SubStatusModel
    {
        public int subStatusId { get; set; }
        public string subStatusName { get; set; }
        public int? orderby { get; set; }
    }
    // UpdateOrderSubStatus
    public class UpdateOrderSubStatusResponse
    {
        public List<OrderMessageModel> MessageModelList { get; set; }
    }

    // UpdateOrderShippingAsync
    public class UpdateOrderShippingAsyncResponse
    {
        public List<MessageModel> MessageModelList { get; set; }
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
        public List<BasketidModel> BasketidModelList { get; set; }
    }

    // CancelOrderAfterShipping
    public class CancelOrderAfterShippingResponse
    {
        public List<OrderMessageModel> MessageModelList { get; set; }
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
}
