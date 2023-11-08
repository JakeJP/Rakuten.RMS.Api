using System;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace Rakuten.RMS.Api.RakutenPayOrderAPI
{
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
        [JsonProperty("operator")]
        public string _operator { get; set; }
        [JsonIgnore]
        public string Operator { get => _operator; set => _operator = value; }
        public string mailPlugSentence { get; set; }
        public int modifyFlag { get; set; }
        public int isTaxRecalc { get; set; }
        public OrdererModel OrdererModel { get; set; }
        public SettlementModel SettlementModel { get; set; }
        public DeliveryModel DeliveryModel { get; set; }
        public PointModel PointModel { get; set; }
        public WrappingModel WrappingModel1 { get; set; }
        public WrappingModel WrappingModel2 { get; set; }
        public IList<PackageModel> PackageModelList { get; set; }
        public IList<CouponModel> CouponModelList { get; set; }
        public IList<ChangeReasonModel> ChangeReasonModelList { get; set; }
    }
    [DecodableObject]
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
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
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
        public int? deleteWrappingFlag { get; set; }
    }
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
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
        public IList<ItemModel> ItemModelList { get; set; }
        /// <summary>
        /// 発送モデルリスト
        /// </summary>
        public IList<ShippingModel> ShippingModelList { get; set; }
        /// <summary>
        /// コンビニ配送モデル 
        /// 配送方法がコンビニ、郵便局受取の場合、参照可能
        /// </summary>
        public DeliveryCVSModel DeliveryCvsModel { get; set; }
        /// <summary>
        /// 購入時配送会社
        /// 1000: その他
        /// 1001: ヤマト運輸
        /// 1002: 佐川急便
        /// 1003: 日本郵便
        /// 1004: 西濃運輸
        /// 1005: セイノースーパーエクスプレス
        /// 1006: 福山通運
        /// 1007: 名鉄運輸
        /// 1008: トナミ運輸
        /// 1009: 第一貨物
        /// 1010: 新潟運輸
        /// 1011: 中越運送
        /// 1012: 岡山県貨物運送
        /// 1013: 久留米運送
        /// 1014: 山陽自動車運送
        /// 1015: NXトランスポート
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
        /// 1028: Rakuten EXPRESS
        /// ※Request Parameterの「version」に「4」以降の値を指定すると取得可能。
        /// </summary>
        public string defaultDeliveryCompanyCode { get; set; }
    }
    [DecodableObject]
    public class SenderModelToUpdate
    {
        public string zipCode1 { get; set; }
        public string zipCode2 { get; set; }
        public string prefecture { get; set; }
        public string city { get; set; }
        public string subAddress { get; set; }
        public string familyName { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string firstName { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string familyNameKana { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string firstNameKana { get; set; }
        public string phoneNumber1 { get; set; }
        public string phoneNumber2 { get; set; }
        public string phoneNumber3 { get; set; }
    }
    public class SenderModel : SenderModelToUpdate
    {
        /// <summary>
        /// version=2
        /// </summary>
        public int? isolatedIslandFlag { get; set; }
    }

    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    [DecodableObject]
    public class ItemModelToUpdate
    {
        public int itemDetailId { get; set; }
        public string itemName { get; set; }
        /// <summary>
        /// 商品番号
        /// 項目選択肢別在庫が指定された商品の場合、以下のルールで値が表示されます
        ///     SKU移行前注文：商品番号（店舗様が登録した番号）＋項目選択肢ID（横軸）＋項目選択肢ID（縦軸）
        ///     SKU移行後注文：商品番号（店舗様が登録した番号）
        /// </summary>
        public string itemNumber { get; set; }
        public int price { get; set; }
        /// <summary>
        /// 商品税率
        /// 以下のいずれか
        /// ・0・0.0・0.08・0.1
        /// </summary>
        public decimal taxRate { get; set; }
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
        public int? restoreInventoryFlag { get; set; }
        public int? deleteItemFlag { get; set; }
        public IList<SkuModel> SkuModelList { get; set; }
    }
    public class ItemModel : ItemModelToUpdate
    {
        public int itemId { get; set; }
        public string manageNumber { get; set; }
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
        public new int restoreInventoryFlag { get; set; }
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
        public new int deleteItemFlag { get; set; }

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

    public class CouponModelBase
    {
        public string couponCode { get; set; }
        public int itemId { get; set; }
        public int couponPrice { get; set; }
        public int couponUnit { get; set; }
    }
    public class CouponModel : CouponModelBase
    {
        public string couponName { get; set; }
        public string couponSummary { get; set; }
        public string couponCapital { get; set; }
        public DateTime expiryDate { get; set; }
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

}
