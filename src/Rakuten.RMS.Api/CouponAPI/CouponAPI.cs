using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Xml.Serialization;
using Rakuten.RMS.Api.XML;

namespace Rakuten.RMS.Api.CouponAPI
{
    public class CouponAPI : RakutenApiXmlClientBase
    {
        internal CouponAPI(ServiceProvider serviceProvider) : base(serviceProvider) { }
        protected override XmlAttributeOverrides GetRequestXmlAttributeOverrides(Type oType) 
        {
            XmlAttributeOverrides overrides = null;
            if(typeof(ResultWithErrorsBase).IsAssignableFrom(oType) || 
                (oType.IsGenericType && typeof(RequestContainer<>).IsAssignableFrom(oType.GetGenericTypeDefinition())))
            {
                var piContent = oType.GetProperty("Content");
                if( piContent != null )
                {
                    var contentType = piContent.PropertyType;
                    var xmlRoot = (XmlRootAttribute)contentType.GetCustomAttributes(typeof(XmlRootAttribute), true).FirstOrDefault();
                    if (xmlRoot != null)
                    {
                        overrides = new XmlAttributeOverrides();
                        var attrs = new XmlAttributes();
                        var attr = new XmlElementAttribute(xmlRoot.ElementName);
                        attrs.XmlElements.Add(attr);
                        overrides.Add(piContent.DeclaringType, "Content", attrs);
                    }
                }
            }
            return overrides;
        }
        protected override TResult HandleResponse<TResult, TErrorResult>(HttpWebRequest req)
        {
            var result = base.HandleResponse<TResult, TErrorResult>(req);
            if( result is ResultWithErrorsBase)
            {
                var r = result as ResultWithErrorsBase;
                if (r.Errors?.Count > 0)
                    throw new RakutenRMSApiException(
                        string.Join(", ", r.Errors.Select( e => string.Format("{0}:{1}", e.code, e.message))), r.Errors);

            }
            return result;
        }
        #region Coupon
        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/coupon/issue", EndpointHttpMethod.POST)]
        public IssuedCoupon Issue( CouponToIssue coupon)
        {
            return Post<ResultContainer<IssuedCoupon>,ResultWithErrorsBase>(new RequestContainer<CouponIssueRequest>(
                new CouponIssueRequest { coupon = coupon })).Content;
        }
        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/coupon/update", EndpointHttpMethod.POST)]
        public void Update(Coupon coupon)
        {
            if (string.IsNullOrEmpty(coupon.couponCode))
                throw new ArgumentNullException("couponCode");
            var restul = Post<ResultWithErrorsBase,ResultWithErrorsBase>(new RequestContainer<CouponUpdateRequest>(new CouponUpdateRequest { coupon = coupon }));

        }
        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/coupon/delete", EndpointHttpMethod.POST)]
        public void Delete( string couponCode)
        {
            var result =Post<ResultContainer<CouponToDelete>, ResultWithErrorsBase>("https://api.rms.rakuten.co.jp/es/1.0/coupon/delete",
                new RequestContainer<CouponDeleteRequest>(new CouponDeleteRequest { coupon = new CouponToDelete { couponCode = couponCode } })
            );
            Debug.Assert(result.Content.couponCode == couponCode);
        }
        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/coupon/get",EndpointHttpMethod.GET)]
        public Coupon Get( string couponCode)
        {
            var qs = new NameValueCollection { { "couponCode", couponCode } };
            return Get<ResultContainer<Coupon>>(queryParameters: qs).Content;
        }
        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/coupon/search", EndpointHttpMethod.GET)]
        public SearchResponse Search( SearchCondition condition)
        {
            var qs = new NameValueCollection();
            foreach( var p in typeof(SearchCondition).GetProperties()) {
                var v = p.GetValue(condition, null);
                if (v != null)
                    qs.Add(p.Name, v.ToString());
            }
            return Get<SearchResponse>(qs);
        }
        public IEnumerable<Coupon> SearchAll( SearchCondition condition)
        {
            while (true)
            {
                var res = Search(condition);
                foreach (var c in res.Content.coupons)
                    yield return c;
                if (res.allCount <= (condition.hits ?? 30) * (condition.page ?? 1))
                    break;
                condition.page = (condition.page ?? 1) + 1;
            }
        }
        #endregion
        #region ThanksCoupon
        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/thankscoupon", EndpointHttpMethod.POST)]
        public long IssueThanksCoupon( ThanksCouponToIssue coupon )
            => Post<ResultContainer<ThanksCouponId>, ResultWithErrorsBase>(new RequestContainer<ThanksCouponToIssue> { Content = coupon })
                .Content.thanksCouponId;
        public long UpdateThanksCoupon( long thanksCouponId, ThanksCouponToIssue coupon )
        {
            return Post<ResultContainer<ThanksCouponId>, ResultWithErrorsBase>($"https://api.rms.rakuten.co.jp/es/1.0/thankscoupon/{thanksCouponId}",
                new RequestContainer<ThanksCouponToIssue>(coupon), httpMethod: "PUT").Content.thanksCouponId;
        }
        public long StopThanksCoupon( long thanksCouponId )
            => Get<ResultContainer<ThanksCouponId>>($"https://api.rms.rakuten.co.jp/es/1.0/thankscoupon/{thanksCouponId}/issuestatus/stop", httpMethod:"PUT")
                .Content.thanksCouponId;

        public ThanksCouponToIssue GetThanksCoupon( long thanksCouponId )
            => Get<ResultContainer<ThanksCoupon>>($"https://api.rms.rakuten.co.jp/es/1.0/thankscoupon/{thanksCouponId}").Content;
        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/thankscoupons", EndpointHttpMethod.GET)]
        public SearchThanksCouponResponse SearchThanksCoupon(SearchThanksCouponCondition condition)
        {
            var qs = new NameValueCollection();
            if( condition != null)
            {
                foreach (var p in condition.GetType().GetProperties())
                {
                    var v = p.GetValue(condition, null);
                    if (v != null)
                        qs.Add(p.Name, v.ToString());
                }
            }
            // this call returns 404 Not Found if nothing to list....
            return Get<SearchThanksCouponResponse>(qs);
        }
        public IEnumerable<ThanksCoupon> SearchAllThanksCoupon(SearchThanksCouponCondition condition)
        {
            while (true)
            {
                var res = SearchThanksCoupon(condition);
                if (res == null) 
                    break;
                foreach (var c in res.Content.thanksCoupons)
                    yield return c;
                if (res.allCount <= (condition.hits ?? 30) * (condition.page ?? 1))
                    break;
                condition.page = (condition.page ?? 1) + 1;
            }
        }
        #endregion
    }
}
