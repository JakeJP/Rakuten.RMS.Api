using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Rakuten.RMS.Api.XML;

namespace Rakuten.RMS.Api.CouponAPI
{
    [XmlRoot("request")]
    public class RequestContainer<TRequestBody>
    {
        internal RequestContainer() { }
        public RequestContainer(TRequestBody requestBody)
        {
            Content = requestBody;
        }
        public TRequestBody Content {  get; set; }
    }
    [XmlRoot("result")]
    public class ResultContainer<TResponseBody> : ResultWithErrorsBase
    {
        internal ResultContainer() { }
        public ResultContainer( TResponseBody responseBody)
        {
            Content = responseBody;
        }

        public TResponseBody Content { get; set; }
    }

    [XmlRoot("result")]
    public class ResultWithErrorsBase : ResultBase
    {
        [XmlArray("errors")]
        [XmlArrayItem("error")]
        public List<Error> Errors { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            if (Errors != null)
                sb.Append(string.Join(", ", Errors.Select(m => string.Format("{0}:{1}", m.code, m.message))));
            sb.Append(base.ToString());
            return sb.ToString();
        }
    }
    public class Error
    {
        public string code { get; set; }
        public string message { get; set; }
    }

    [XmlRoot("couponIssueRequest")]
    public class CouponIssueRequest
    {
        public CouponToIssue coupon { get; set; }
    }
    [XmlRoot("coupon")]
    public class IssuedCoupon
    {
        /// <summary>
        /// クーポンコード
        /// </summary>
        public string couponCode { get; set; }
        /// <summary>
        /// 取得URL (PC)
        /// </summary>
        public string pcGetUrl { get; set; }
    }
    [DecodableObject]
    public class CouponToIssue
    {
        public string couponName { get; set;}
        public string couponCaption { get; set;}
        [XmlElement(DataType = "dateTime")]
        public DateTime couponStartDate { get; set; }
        [XmlElement(DataType = "dateTime")]
        public DateTime couponEndDate {  get; set; }
        public string couponImage { get; set;}
        public int issueCount {  get; set; }
        /// <summary>
        /// discountTypeによって、値が異なります。
        /// 1： 単一商品
        /// 3： 複数商品
        /// 4： 受注
        /// 5： 送料無料
        /// </summary>
        public int itemType {  get; set; }
        /// <summary>
        /// 1： 定額値引き
        /// 2： 定率値引き
        /// 4： 送料無料
        /// </summary>
        public int discountType {  get; set; }
        public int discountFactor {  get; set; }
        public int memberAvailMaxCount {  get; set; }
        /// <summary>
        /// 0： 条件なし
        /// 1： レギュラー
        /// 2： シルバー
        /// 3： ゴールド
        /// 4： プラチナ
        /// 5： ダイヤモンド
        /// </summary>
        [XmlArrayItem("rankCond")]
        public int[] multiRankCond { get; set; }

        public int combineFlag {  get; set; }
        public int displayFlag {  get; set; }
        /// <summary>
        /// 対象商品は3000個まで指定可能です。
        /// </summary>
        [XmlArrayItem("item")]
        public Item[] items { get; set; }
        public OtherConditions otherConditions { get; set; }
    }
    public class Item
    {
        public string itemUrl { get; set; }
    }
    public class OtherConditions
    {
        public OtherCondition otherCondition { get; set; }
    }
    public class OtherCondition
    {
        /// <summary>
        /// RS001： デバイス指定（設定のない場合は自動的に設定される）
        /// RS002： 販売方法(設定のない場合は自動的に設定される）
        /// RS003： 利用金額
        /// RS004： 利用個数
        /// ※39ショップに限り、 利用個数(RS004) を設定した場合、複数商品(「itemType」に「3」)が設定可能です。
        /// ※ 対象商品リストが設定されている場合はクーポン発行条件を参照ください。
        /// </summary>
        public string conditionTypeCode { get; set; }
        /// <summary>
        /// 0： PC （設定のない場合は自動的に設定される）
        /// 1： モバイル （設定のない場合は自動的に設定される）
        /// RS002	0： 通常購入
        /// RS003	1 ～ 999999999： 金額
        /// RS004	0 ～ 999999999： 個数
        /// </summary>
        public string startValue { get; set; }
    }
    [XmlRoot("coupon")]
    public class Coupon : CouponToIssue
    {
        public string couponCode {  get; set; }
        //[XmlArrayItem("rankCond")]
        //public new List<int> multiRankCond { get; set; }

    }
    [XmlRoot("couponUpdateRequest")]
    public class CouponUpdateRequest
    {
        public Coupon coupon { get; set;}
    }
    [XmlRoot("coupon")]
    public class CouponToDelete
    {
        public string couponCode { get; set; }
    }
    [XmlRoot("couponDeleteRequest")]
    public class CouponDeleteRequest
    {
        public CouponToDelete coupon { get; set; }
    }
    [DecodableObject]
    public class SearchCondition
    {
        public string couponName { get; set; }
        public string couponCode { get; set; }
        public string itemUrl { get; set; }
        public DateTime? couponStartDate { get; set; }
        public DateTime? couponEndDate { get; set; }
        public int? hits { get; set; }
        public int? page { get; set; }
    }
    [XmlRoot("result")]
    public class SearchResponse : ResultContainer<SearchedCoupons>
    {
        public int allCount { get; set; }
    }
    [XmlRoot("coupons")]
    public class SearchedCoupons 
    {
        [XmlElement("coupon")]
        public List<Coupon> coupons { get; set; }
    }
    [DecodableObject]
    public class SearchThanksCouponCondition
    {
        /// <summary>
        /// 3: 期間前 4: 期間中 5: 停止 6: 終了
        /// </summary>
        public int? issueStats { get; set; }
        public DateTime? grantStartDate { get; set; }
        public DateTime? grantEndDate { get; set; }
        public DateTime? regDate { get; set; }
        /// <summary>
        /// デフォルト： 30         最大値：100
        /// </summary>
        public int? hits { get; set; }
        /// <summary>
        /// デフォルト： 1
        /// </summary>
        public int? page { get; set; }
    }
    [XmlRoot("result")]
    public class SearchThanksCouponResponse : ResultContainer<SearchedThanksCoupons>
    {
        public int allCount { get; set; }
    }
    [XmlRoot("thanksCoupons")]
    public class SearchedThanksCoupons
    {
        [XmlElement("thanksCoupon")]
        public List<ThanksCoupon> thanksCoupons { get; set; }
    }
}
