using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Xml.Serialization;
using Rakuten.RMS.Api.XML;

namespace Rakuten.RMS.Api.ShopAPI
{
    /// <summary>
    /// GetLastResult()
    /// </summary>
    public class ShopAPI : RakutenApiXmlClientBase
    {
        public const string ModelNamespace = "http://rakuten.co.jp/rms/mall/shop/biz/api/model/resource";
        internal ShopAPI(ServiceProvider provider) : base(provider)
        {
        }
        protected override TResult Get<TResult>(string url, NameValueCollection queryParameters = null)
        {
            var result = base.Get<TResult>(url, queryParameters);
            if (result is ShopBizApiResponse)
            {
                LastResult = result as ShopBizApiResponse;
                if (LastResult.resultCode != "N000")
                    throw new ShopBizApiException(LastResult);
            }
            return result;
        }
        public ShopBizApiResponse LastResult { get; protected set; }
        protected override XmlSerializerNamespaces GetNamespaces()
        {
            var ns = new XmlSerializerNamespaces();
            ns.Add("shopbiz", "http://rakuten.co.jp/rms/mall/shop/biz/api/model/resource");
            return ns;
        }
        public TopDisplay GetTopDisplay()
            => Get<ShopBizApiResponseWithResult<TopDisplayBizModel>>("https://api.rms.rakuten.co.jp/es/1.0/shop/topDisplay")
                .Result.topDisplay;

        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/shop/topDisplay", EndpointHttpMethod.POST)]
        public ShopBizApiResponse EditTopDisplay(TopDisplay model)
            => Post<ShopBizApiResponse>(new TopDisplayBizModelRequest { updateModel = model });

        public ShopLayoutImage GetShopLayoutImage()
            => Get<ShopBizApiResponseWithResult<ShopLayoutImageBizModel>>("https://api.rms.rakuten.co.jp/es/1.0/shop/shopLayoutImage")
                .Result.shopLayoutImage;

        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/shop/shopLayoutImage", EndpointHttpMethod.POST)]
        public ShopBizApiResponse EditShopLayoutImage(ShopLayoutImage model)
            => Post<ShopBizApiResponse>(new ShopLayoutImageBizModelForEdit { insertModel = model });

        public IList<ShopLayoutCommon> GetShopLayoutCommon(long? layoutCommonId = null)
            => Get<ShopBizApiResponseWithResult<ShopLayoutCommonBizModel>>(
                "https://api.rms.rakuten.co.jp/es/1.0/shop/shopLayoutCommon",
                    layoutCommonId == null ? null : new NameValueCollection { { "layoutCommonId", layoutCommonId.ToString() } })
                .Result
                .shopLayoutCommonList;

        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/shop/shopLayoutCommon", EndpointHttpMethod.POST)]
        public ShopBizApiResponse<ShopLayoutCommonResultMessage> EditShopLayoutCommon(shopLayoutCommonBizModelRequest request)
            => Post<ShopBizApiResponse<ShopLayoutCommonResultMessage>>(request);

        public IList<NaviButtonInfo> GetNaviButtonInfo(long? naviId = null)
            => Get<ShopBizApiResponseWithResult<NaviButtonInfoBizModel>>(
                "https://api.rms.rakuten.co.jp/es/1.0/shop/naviButtonInfo",
                naviId == null ? null : new NameValueCollection { { "naviId", naviId.ToString() } })
                .Result.naviButtonInfoList;


        public ShopBizApiResponseWithResult<ShopLayoutCommonBizModel> EditNaviButtonInfo(NaviButtonInfoBizModelRequest request)
            => Post<ShopBizApiResponseWithResult<ShopLayoutCommonBizModel>>(request);

        public NaviButton GetNaviButton()
            => Get<ShopBizApiResponseWithResult<NaviButtonBizModel>>("https://api.rms.rakuten.co.jp/es/1.0/shop/naviButton")
                .Result.naviButton;
        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/shop/naviButtonInfo", EndpointHttpMethod.POST)]
        public ShopBizApiResponseWithResult<NaviButtonBizModel> EditNaviButton(NaviButtonBizModelRequest request)
            => Post<ShopBizApiResponseWithResult<NaviButtonBizModel>>(request);

        public void GetLayoutTextSmall()
        {
            new NotImplementedException();
        }
        public void GetLayoutLossLeader()
        {
            throw new NotImplementedException();
        }
        public void GetLayoutItemMap()
        {
            throw new NotImplementedException();
        }
        public void GetLayoutCategoryMap()
        {
            throw new NotImplementedException();
        }

        public void GetShopCalendar()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// RMS WEB SERVICE : shop.delvdateMaster.get
        /// </summary>
        public IList<DelvdateMaster> GetDelvdateMaster(string delvdateNumber = null)
        {
            var url = @"https://api.rms.rakuten.co.jp/es/1.0/shop/delvdateMaster";
            if (!string.IsNullOrEmpty(delvdateNumber))
                url += "?delvdateNumber=" + delvdateNumber;
            return Get<ShopBizApiResponseWithResult<DelvdateMasterBizModel>>(url)
                .Result.delvdateMasterList;
        }
        public void GetDeliverySetInfo()
        {
            throw new NotImplementedException();
        }
        public void GetSoryoKbn()
        {
            throw new NotImplementedException();
        }
        public void GetShopAreaSoryo()
        {
            throw new NotImplementedException();
        }
        public void EditShopAreaSoryo()
        {
            throw new NotImplementedException();
        }

        public void GetDelvAreaMaster()
        {
            throw new NotImplementedException();
        }

        public void GetLayoutTextLarge()
        {
            throw new NotImplementedException();
        }

        public void EditLayoutTextLarge()
        {
            throw new NotImplementedException();
        }

        public void GetGoldTop()
        {
            throw new NotImplementedException();
        }

        public void EditGoldTop()
        {
            throw new NotImplementedException();
        }

        public void GetShopMaster()
        {
            throw new NotImplementedException();
        }

        public void GetShopCalendarAndDesign()
        {
            throw new NotImplementedException();
        }

        public void EditShopCalendarAndDesign()
        {
            throw new NotImplementedException();
        }

        public void GetShopHoliday()
        {
            throw new NotImplementedException();
        }

        public void EditShopHoliday()
        {
            throw new NotImplementedException();
        }

        public void GetSpBigBanner()
        {
            throw new NotImplementedException();
        }

        public void EditSpBigBanner()
        {
            throw new NotImplementedException();
        }

        public void GetSpCategoryPage()
        {
            throw new NotImplementedException();
        }

        public void EditSpCategoryPage()
        {
            throw new NotImplementedException();
        }

        public void GetSpItemPage()
        {
            throw new NotImplementedException();
        }

        public void EditSpItemPage()
        {
            throw new NotImplementedException();
        }

        public void GetSpMedamaCategory()
        {
            throw new NotImplementedException();
        }

        public void EditSpMedamaCategory()
        {
            throw new NotImplementedException();
        }

        public void GetSpMedamaItem()
        {
            throw new NotImplementedException();
        }

        public void EditSpMedamaItem()
        {
            throw new NotImplementedException();
        }

        public void GetSpSmallBanner()
        {
            throw new NotImplementedException();
        }

        public void EditSpSmallBanner()
        {
            throw new NotImplementedException();
        }

        public void GetSpTopPage()
        {
            throw new NotImplementedException();
        }

        public void EditSpTopPage()
        {
            throw new NotImplementedException();
        }

        public void GetSpTopPageDisplay()
        {
            throw new NotImplementedException();
        }

        public void GetShopStatus()
        {
            throw new NotImplementedException();
        }

        public void EditShopStatus()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// この機能を利用すると、出荷リードタイムを取得することができます。※SKU移行後の店舗様向けの機能です。
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IList<OperationLeadTime> GetOperationLeadTime(int? id = null)
        {
            var url = "https://api.rms.rakuten.co.jp/es/1.0/shop/operationLeadTime";
            if (id.HasValue)
                url += "?operationLeadTimeId=" + id.ToString();
            return Get<ShopBizApiResponseWithResult<OperationLeadTimeBizModel>>(url)
                .Result.operationLeadTimeList;
        }

        public void GetShipFrom()
        {
            throw new NotImplementedException();
        }

        public void GetSignboard()
        {
            throw new NotImplementedException();
        }

        public void EditSignboard()
        {
            throw new NotImplementedException();
        }





    }
}
