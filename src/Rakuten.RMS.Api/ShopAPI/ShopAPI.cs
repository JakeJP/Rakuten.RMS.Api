using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
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
        protected override TResult HandleResponse<TResult, TErrorResult>(HttpWebRequest req)
        {
            try
            {
                var result = base.HandleResponse<TResult, ShopBizApiResponse>(req);
                if (result is ShopBizApiResponse)
                {
                    LastResult = result as ShopBizApiResponse;
                    if (LastResult.resultCode != "N000")
                        throw new ShopBizApiException(LastResult);
                }
                return result;
            }
            catch( RakutenRMSApiException ex)
            {
                if (ex.Error is ShopBizApiResponse)
                    throw new ShopBizApiException((ShopBizApiResponse)ex.Error);
                else
                    throw ex;
            }
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

        /// <summary>
        /// 共通説明文（小）の情報を取得
        /// </summary>
        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/shop/layoutTextSmall", EndpointHttpMethod.GET)]
        public ShopBizApiResponseWithResult<LayoutTextSmallBizModel> GetLayoutTextSmall( int? textSmallId = null)
            => Get<ShopBizApiResponseWithResult<LayoutTextSmallBizModel>>(textSmallId == null ? null : new NameValueCollection { { "textSmallId", textSmallId.ToString() } });

        /// <summary>
        /// 目玉商品（PC）のテンプレート設定情報のみを取得
        /// </summary>
        /// <param name="lossLeaderId">
        /// lossLeaderId
        /// </param>
        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/shop/layoutLossLeader", EndpointHttpMethod.GET)]
        public IList<LayoutLossLeader> GetLayoutLossLeader(int? lossLeaderId = null )
            => Get<ShopBizApiResponseWithResult<LayoutLossLeaderBizModel>>(lossLeaderId == null ? null : new NameValueCollection { { "lossLeaderId", lossLeaderId.ToString() } })
                .Result.layoutLossLeaderList;
        /// <summary>
        /// 商品ページ表示項目並び順の情報を取得
        /// </summary>
        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/shop/layoutItemMap", EndpointHttpMethod.GET)]
        public IList<LayoutItemMap> GetLayoutItemMap(int? itemMapId = null)
            => Get<ShopBizApiResponseWithResult<LayoutItemMapBizModel>>(itemMapId == null ? null : new NameValueCollection { { "itemMapId", itemMapId.ToString() } }).Result.layoutItemMapList;
        /// <summary>
        /// カテゴリページ表示項目並び順の情報を取得
        /// </summary>
        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/shop/layoutCategoryMap", EndpointHttpMethod.GET)]
        public IList<LayoutCategoryMap> GetLayoutCategoryMap( int? categoryMapId = null )
            => Get<ShopBizApiResponseWithResult<LayoutCategoryMapBizModel>>(
                categoryMapId == null ? null : new NameValueCollection { { "categoryMapId", categoryMapId.ToString() } }).Result.layoutCategoryMapList;
        /// <summary>
        /// 営業日カレンダー設定・ショップからの重要なお知らせの情報を取得
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="period">取得する期間を指定します。(fromDate ～ fromDate + period)
        /// デフォルト値は90日。
        /// 最大値は180日。</param>
        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/shop/shopCalendar", EndpointHttpMethod.GET)]
        public ShopCalendar2 GetShopCalendar( DateTime? fromDate = null, int? period = null )
        {
            var qs = new NameValueCollection();
            if (fromDate != null) qs.Add("fromDate", fromDate.Value.ToString("yyyy-MM-dd"));
            if (period != null) qs.Add("period", period.ToString());
            return Get<ShopBizApiResponseWithResult<ShopCalendarBizModel>>(qs).Result.shopCalendar;
        }
        /// <summary>
        /// 納期情報設定の情報を取得
        /// </summary>
        /// <param name="delvdateNumber">
        /// 指定したdelvdateNumberの情報を取得します。指定しない場合はすべての納期情報設定の情報を取得します。
        /// </param>
        public IList<DelvdateMaster> GetDelvdateMaster(string delvdateNumber = null)
        {
            var url = @"https://api.rms.rakuten.co.jp/es/1.0/shop/delvdateMaster";
            if (!string.IsNullOrEmpty(delvdateNumber))
                url += "?delvdateNumber=" + delvdateNumber;
            return Get<ShopBizApiResponseWithResult<DelvdateMasterBizModel>>(url)
                .Result.delvdateMasterList;
        }
        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/shop/deliverySetInfo", EndpointHttpMethod.GET)]
        public IList<DeliverySetInfo> GetDeliverySetInfo(int? deliverySetId = null)
            => Get<ShopBizApiResponseWithResult<DeliverySetInfoBizModel>>(
                deliverySetId == null ? null : new NameValueCollection { { "deliverySetId", deliverySetId.ToString() } }).Result.deliverySetInfoList;
        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/shop/soryoKbn", EndpointHttpMethod.GET)]
        public SoryoKbnBizModel GetSoryoKbn(int? kbnId = null, int? id = null )
        {
            var qs = new NameValueCollection();
            if( kbnId != null ) qs.Add("kbnId", kbnId.ToString());
            if(id != null) qs.Add("id", id.ToString());
            return Get<ShopBizApiResponseWithResult<SoryoKbnBizModel>>(qs).Result;
        }
        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/shop/shopAreaSoryo", EndpointHttpMethod.GET)]
        public ShopAreaSoryoWrapper GetShopAreaSoryo(int? patternId = null)
            => Get<ShopBizApiResponseWithResult<ShopAreaSoryoWrapperModel>>(
                patternId == null ? null : new NameValueCollection { { "patternId", patternId.ToString() } }).Result.shopAreaSoryoWrapper;

        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/shop/shopAreaSoryo", EndpointHttpMethod.POST)]
        public ShopBizApiResponse EditShopAreaSoryo(ShopAreaSoryoWrapperBizModel model)
            => Post<ShopBizApiResponse>(model);

        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/shop/delvAreaMaster", EndpointHttpMethod.GET)]
        public DelvAreaMasterBizModel GetDelvAreaMaster(int? delvAreaId = null)
            => Get<ShopBizApiResponseWithResult<DelvAreaMasterBizModel>>(
                delvAreaId == null ? null :
                new NameValueCollection { { "delvAreaId", delvAreaId.ToString().ToLower() } }).Result;

        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/shop/layoutTextLarge", EndpointHttpMethod.GET)]
        public LayoutTextLargeBizModel GetLayoutTextLarge()
            => Get<ShopBizApiResponseWithResult<LayoutTextLargeBizModel>>().Result;

        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/shop/layoutTextLarge", EndpointHttpMethod.POST)]
        public ShopBizApiResponse EditLayoutTextLarge(LayoutTextLargeBizModel model)
            => Post<ShopBizApiResponse>(model);

        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/shop/goldTop", EndpointHttpMethod.GET)]
        public GoldTopBizModel GetGoldTop()
            => Get<ShopBizApiResponseWithResult<GoldTopBizModel>>().Result;

        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/shop/goldTop", EndpointHttpMethod.POST)]
        public ShopBizApiResponse EditGoldTop(GoldTopBizModel model)
            => Post<ShopBizApiResponse>(model);

        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/shop/shopMaster", EndpointHttpMethod.GET)]
        public ShopMasterBizModel GetShopMaster()
            => Get<ShopBizApiResponseWithResult<ShopMasterBizModel>>().Result;

        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/shop/shopCalendarAndDesign", EndpointHttpMethod.GET)]
        public ShopCalendarAndDesignBizModel GetShopCalendarAndDesign()
            => Get<ShopBizApiResponseWithResult<ShopCalendarAndDesignBizModel>>().Result;

        /// <summary>
        /// 営業日カレンダー・カレンダーデザイン設定を登録・更新・削除
        /// </summary>
        /// <param name="clearCalendar">clearCalendar=trueを年中無休フラグ（nonHolidayFlag=1）と合わせて使用します。</param>
        public ShopBizApiResponse EditShopCalendarAndDesign(ShopCalendarAndDesignBizModel model, bool? clearCalendar = null)
            => Post<ShopBizApiResponse>(
                "https://api.rms.rakuten.co.jp/es/1.0/shop/shopCalendarAndDesign" +
                (clearCalendar == null ? null : "?clearCalendar=" + clearCalendar.ToString().ToLower()));

        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/shop/shopHoliday", EndpointHttpMethod.GET)]
        public ShopHolidayBizModel GetShopHoliday()
            => Get<ShopBizApiResponseWithResult<ShopHolidayBizModel>>().Result;

        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/shop/shopHoliday", EndpointHttpMethod.POST)]
        public ShopBizApiResponse EditShopHoliday(ShopHolidayBizModel model)
            => Post<ShopBizApiResponse>(model);

        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/shop/spBigBanner", EndpointHttpMethod.GET)]
        public SpBigBannerBizModel GetSpBigBanner()
            => Get<ShopBizApiResponseWithResult<SpBigBannerBizModel>>().Result;

        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/shop/spBigBanner", EndpointHttpMethod.POST)]
        public ShopBizApiResponse EditSpBigBanner(SpBigBannerBizModel model)
            => Post<ShopBizApiResponse>(model);

        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/shop/spCategoryPage", EndpointHttpMethod.GET)]
        public SpCategoryPageBizModel GetSpCategoryPage()
            => Get<ShopBizApiResponseWithResult<SpCategoryPageBizModel>>().Result;

        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/shop/spCategoryPage", EndpointHttpMethod.POST)]
        public void EditSpCategoryPage(SpCategoryPageBizModel model)
            => Post<ShopBizApiResponse>(model);

        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/shop/spItemPage", EndpointHttpMethod.GET)]
        public SpItemPageBizModel GetSpItemPage()
            => Get<ShopBizApiResponseWithResult<SpItemPageBizModel>>().Result;

        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/shop/spItemPage", EndpointHttpMethod.POST)]
        public ShopBizApiResponse EditSpItemPage(SpItemPageBizModel model)
            => Post<ShopBizApiResponse>(model);

        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/shop/spMedamaCategory", EndpointHttpMethod.GET)]
        public SpMedamaCategoryBizModel GetSpMedamaCategory()
            => Get<ShopBizApiResponseWithResult<SpMedamaCategoryBizModel>>().Result;

        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/shop/spMedamaCategory", EndpointHttpMethod.POST)]
        public ShopBizApiResponse EditSpMedamaCategory(SpMedamaCategoryBizModel model)
            => Post<ShopBizApiResponse>(model);

        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/shop/spMedamaItem", EndpointHttpMethod.GET)]
        public ShopBizApiResponse GetSpMedamaItem()
            => Get<ShopBizApiResponseWithResult<ShopBizApiResponse>>().Result;


        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/shop/spMedamaItem", EndpointHttpMethod.POST)]
        public ShopBizApiResponse EditSpMedamaItem(SpMedamaItemBizModel model)
            => Post<ShopBizApiResponse>(model);

        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/shop/spSmallBanner", EndpointHttpMethod.GET)]
        public SpSmallBannerBizModel GetSpSmallBanner()
            => Get<ShopBizApiResponseWithResult<SpSmallBannerBizModel>>().Result;

        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/shop/spSmallBanner", EndpointHttpMethod.POST)]
        public ShopBizApiResponse EditSpSmallBanner(SpSmallBannerBizModel model)
            => Post<ShopBizApiResponse>(model);

        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/shop/spTopPage", EndpointHttpMethod.GET)]
        public SpTopPageBizModel GetSpTopPage()
            => Get<ShopBizApiResponseWithResult<SpTopPageBizModel>>().Result;

        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/shop/spTopPage", EndpointHttpMethod.POST)]
        public ShopBizApiResponse EditSpTopPage(SpTopPageBizModel model)
            => Post<ShopBizApiResponse>(model);

        /// <summary>
        /// 2022年4月18日（月）リリースのスマートフォン用トップページへの切替を行ったかを確認
        /// </summary>
        /// <returns>0: 従来版スマートフォン用トップページ 1: 2022年4月18日（月）リリースのスマートフォン用トップページ</returns>
        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/shop/spTopPageDisplay", EndpointHttpMethod.GET)]
        public int GetSpTopPageDisplay()
        {
            return Get<ShopBizApiResponseWithResult<SpTopPageDisplayBizModel>>().Result.spTopPageDisplay.status;
        }
        /// <summary>
        /// skuMigration：SKU移行
        /// pcTopMigration：PC用トップページの移行
        /// </summary>
        /// <param name="statusKey"></param>
        public ShopStatusBizModel GetShopStatus(string statusKey)
        {
            var url = $"https://api.rms.rakuten.co.jp/es/1.0/shop/shopStatus/{statusKey}";
            return Get<ShopBizApiResponseWithResult<ShopStatusBizModel>>(url).Result;
        }

        public ShopBizApiResponse EditShopStatus( string statusKey, ShopStatus status )
        {
            var url = $"https://api.rms.rakuten.co.jp/es/1.0/shop/shopStatus/{statusKey}";
            return Post<ShopBizApiResponse>(url, new ShopStatusBizModel { updateModel = status });
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
        /// <summary>
        /// 出荷元住所を取得
        /// </summary>
        /// <param name="shipFromId"></param>
        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/shop/shipFrom", EndpointHttpMethod.GET)]
        public void GetShipFrom(int? shipFromId = null)
            => Get<ShopBizApiResponseWithResult<ShipFromBizModel>>(shipFromId == null ? null : new NameValueCollection { { "shipFromId", shipFromId.ToString() } });
        /// <summary>
        /// スマートフォン用・PC用新店舗トップページの看板画像URLを取
        /// </summary>
        /// <returns></returns>
        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/shop/signboard", EndpointHttpMethod.GET)]
        public ShopBizApiResponseWithResult<SignboardBizModel> GetSignboard()
            => Get<ShopBizApiResponseWithResult<SignboardBizModel>>();
        /// <summary>
        /// スマートフォン用小バナー設定の情報を登録・更新・削除・表示順変更
        /// </summary>
        /// <param name="spSignboardUrl"></param>
        /// <param name="pcSignboardUrl"></param>
        /// <returns></returns>
        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/shop/signboard", EndpointHttpMethod.POST)]
        public ShopBizApiResponse EditSignboard( string spSignboardUrl, string pcSignboardUrl = null )
            => Post<ShopBizApiResponse>(new { inputModel = new { spSignboardUrl, pcSignboardUrl } });
    }
}
