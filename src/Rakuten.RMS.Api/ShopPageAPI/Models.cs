using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;


namespace Rakuten.RMS.Api.ShopPageAPI
{
    public class ResultResponse<TResponse>
    {
        public TResponse result { get; set; }
    }
    #region Navigation
    public class NavigationRequest
    {
        public string type { get; set; }
        public Option options { get; set; }
        public class Option
        {
            public bool ranking { get; set; }
            public bool coupon { get; set; }
        }

    }
    public class Navigation : NavigationRequest
    {
        public string navigationId { get;set; }

    }
    #endregion
    public class WidgetToRequest
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public WidgetType type { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public DisplayFormat displayFormat { get; set; }
        public List<WidgetBody> body { get; set; }
    }
    public class Widget : WidgetToRequest
    {
        public string widgetId { get; set; }

    }
    public class WidgetBody
    {
        public string caption { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public ImageType imageType { get; set; }
        public string imagePath { get; set; }
        public string linkUrl { get; set; }
    }
    public enum WidgetType
    {
        SMALL_IMAGE, //小画像パーツ
        SMALL_COMMON_BANNER, // 小バナー（共通テンプレート）
        LARGE_IMAGE, //大画像パーツ
        LARGE_COMMON_BANNERS, //大バナー（共通テンプレート）パーツ
        ITEM_LIST, //商品パーツ
        IN_SHOP_CATEGORY, //商品（店舗内カテゴリ）パーツ
        FEATURED_ITEMS, //目玉商品（共通テンプレート）パーツ
        TITLE, //タイトルパーツ
        TEXT, //テキストパーツ
        SHOP_NOTICE, //お知らせパーツ
        ITEM_REVIEW, //商品レビューパーツ
        IN_SHOP_RANKING, // 店舗内ランキングパーツ
        HYPERLINK, //リンクパーツ
        IN_SHOP_KEYWORDS, //店舗内注目キーワードパーツ
        COUPON, //クーポンパーツ
        RECOMMENDATION //おすすめパーツ
    }
    public enum ImageType
    {
        CABINET,
        RECOMMEND
    }
    public enum DisplayFormat
    {
        LANDSCAPE,
        PORTRAIT
    }


    #region Layout
    public enum LayoutStatus
    {
        PUBLIC, DRAFT, PREVIEW
    }
    public enum LayoutType
    {
        SHOP_TOP
    }
    public class LayoutToReplace
    {
        public LayoutType type { get; set; }
        public string title { get; set; }
        public List<LayoutModule> modules { get; set; }

    }
    public class LayoutToRequest : LayoutToReplace
    {
        public DateTime? startTime { get; set; }
        public DateTime? endTime { get; set; }
    }
    public class Layout : LayoutToRequest
    {
        public string layoutId {  get; set; }
        public DateTime createTime {  get; set; }
        public DateTime updateTime { get; set; }
    }
    public enum LayoutModuleType
    {
        HEADER,
        NAVIGATION,
        COMMON,
        WIDGET
    }
    public class LayoutModule
    {
        public LayoutModuleType type { get; set; }
    }
    public class LayoutModuleHeader : LayoutModule
    {
        public LayoutModuleHeader() { type = LayoutModuleType.HEADER; }
    }
    public class LayoutModuleNavigation : LayoutModule
    {
        public LayoutModuleNavigation() { type = LayoutModuleType.NAVIGATION; }
        public Details details { get; set; }
        public class Details
        {
            public List<string> navigationIds { get; set; }
        }
    }
    public class LayoutModuleCommon : LayoutModule
    {
        public LayoutModuleCommon() { type = LayoutModuleType.COMMON; }
    }
    public class LayoutModuleWidget : LayoutModule
    {
        public LayoutModuleWidget() { type = LayoutModuleType.WIDGET; }
        public Details details { get; set; }
        public class Details
        {
            public List<string> widgetIds { get; set; }
        }
    }
    public class LayoutResponse
    {
        public string layoutId { get; set; }
    }
    #endregion
}
