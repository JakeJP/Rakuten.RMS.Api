using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.CouponAPI
{
    [XmlRoot("thanksCoupon")]
    [DecodableObject]
    public  class ThanksCouponToIssue
    {
        public string couponImage { get; set; }
        public string couponName { get; set; }
        public string couponCaption { get; set; }

        /// <summary>
        /// 1： 定額値引き
        /// 2： 定率値引き
        /// 4： 送料無料
        /// </summary>
        public int discountType { get; set; }
        public int discountFactor { get; set; }

        public int couponUnavailableTerm {  get; set; }
        public int couponTerm {  get; set; }
        public int memberAvailMaxCount { get; set; }
        public int combineFlag {  get; set; }
        [XmlArrayItem("thanksOtherCondition")]
        public List<ThanksOtherCondition> thanksOtherConditions {  get; set; }
        [XmlArrayItem("thanksAutoGetCondition")]
        public List<ThanksAutoGetCondition> thanksAutoGetConditions {  get; set; }

    }
    public class ThanksCoupon : ThanksCouponToIssue
    {
        public long thanksCouponId { get;set; }
        public string shopId { get; set; }
        public string shopName { get; set; }
        public string shopUrl { get; set; }
    }
    [XmlRoot("thanksCoupon")]
    public class ThanksCouponId
    {
        public long thanksCouponId { get; set; }

    }
    public class ThanksOtherCondition
    {
        public string conditionTypeCode { get; set; }
        public string startValue { get; set; }
    }
    [DecodableObject]
    public class ThanksAutoGetCondition
    {
        /// <summary>
        /// クーポン獲得金額条件："totalPrice" - 必須項目
        /// クーポン獲得期間："grantTerm" - 必須項目
        /// 初回購入ユーザー限定："serviceUseHistory" - 任意項目
        /// </summary>
        public string getCondCd {  get; set; }
        public string startValue { get; set; }
        public string endValue { get; set; }
        public int compOperatorCd {  get; set; }
    }
}
