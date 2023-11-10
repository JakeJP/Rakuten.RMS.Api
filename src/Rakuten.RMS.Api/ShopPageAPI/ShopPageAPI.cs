using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rakuten.RMS.Api.JSON;

namespace Rakuten.RMS.Api.ShopPageAPI
{
    public class ShopPageAPI : RakutenApiJsonClientBase
    {
        internal ShopPageAPI(ServiceProvider serviceProvider) : base(serviceProvider) { }
        #region Navigation
        public ResultBase InsertNavigations(NavigationRequest navigation)
        {
            return PostRequest<ResultBase>("https://api.rms.rakuten.co.jp/es/1.0/shop-page/navigations",
                navigation);
        }
        public IList<Navigation> ListNavigations()
            => GetRequest<ResultResponse<List<Navigation>>, ResultBase>("https://api.rms.rakuten.co.jp/es/1.0/shop-page/navigations")
                .result;

        public Navigation GetNavigations(string navigationId)
            => GetRequest<Navigation, ResultBase>($"https://api.rms.rakuten.co.jp/es/1.0/shop-page/navigations/{navigationId}");

        public ResultBase UpdateNavigations(string navigationId, NavigationRequest navigation )
        {
            return PostRequest<ResultBase>($"https://api.rms.rakuten.co.jp/es/1.0/shop-page/navigations/{navigationId}"
                , navigation, method: "PUT");
        }
        #endregion

        #region Widget
        public ResultBase InsertWidgets(WidgetToRequest widget )
        {
            return PostRequest<ResultBase>("https://api.rms.rakuten.co.jp/es/1.0/shop-page/widgets", widget);
        }
        public IList<Widget> ListWidgets()
            => GetRequest<ResultResponse<List<Widget>>, ResultBase>("https://api.rms.rakuten.co.jp/es/1.0/shop-page/widgets")
                .result;
        public void GetWidgets(string widgetId)
            => GetRequest<Widget>($"https://api.rms.rakuten.co.jp/es/1.0/shop-page/widgets/{widgetId}");
        public ResultBase UpdateWidgets(string widgetId, WidgetToRequest widget )
            => PostRequest<ResultBase>($"https://api.rms.rakuten.co.jp/es/1.0/shop-page/widgets/{widgetId}", widget, method: "PUT");

        public void DeleteWidgets(string widgetId)
            => GetRequest<ResultBase>($"https://api.rms.rakuten.co.jp/es/1.0/shop-page/widgets/{widgetId}", method: "DELETE");
        #endregion

        #region Layout
        public string InsertLayouts(LayoutToRequest layout, LayoutStatus status, bool? migratePcTopPage = null )
        {
            return PostRequest<LayoutResponse>($"https://api.rms.rakuten.co.jp/es/1.0/shop-page/layouts/status/{status.ToString().ToLower()}{(migratePcTopPage == null ? "" : "?migratePcTopPage=" + migratePcTopPage.ToString().ToLower())}",
                layout).layoutId;
        }
        public IList<Layout> ListLayouts( LayoutStatus status )
        {
            return GetRequest<ResultResponse<List<Layout>>>($"https://api.rms.rakuten.co.jp/es/1.0/shop-page/layouts/status/{status}").result;
        }
        public IList<Layout> ListPublishedLayouts( LayoutType layoutType)
        {
            return GetRequest<ResultResponse<List<Layout>>>($"https://api.rms.rakuten.co.jp/es/1.0/shop-page/layouts/published?layoutType={layoutType.ToString()}").result;
        }
        public Layout GetLayouts( string layoutId, LayoutStatus status, bool? isFullContents = null )
        {
            return GetRequest<Layout>($"https://api.rms.rakuten.co.jp/es/1.0/shop-page/layouts/{layoutId}/status/{status}"
                + (isFullContents == null ? "" : "?isFullContents=" + isFullContents.Value.ToString().ToLower()));
        }
        public string ReplaceLayouts( string targetLayoutId, LayoutToReplace layout)
        {
            return PostRequest<LayoutResponse>($"https://api.rms.rakuten.co.jp/es/1.0/shop-page/layouts/replace/{targetLayoutId}", layout).layoutId;
        }
        public void UpdateLayouts( string layoutId, LayoutToReplace layout  )
        {
            PostRequest<ResultBase>($"https://api.rms.rakuten.co.jp/es/1.0/shop-page/layouts/{layoutId}/status/draft",
                layout, method: "PUT");
        }
        public void DeleteLayouts( string layoutId, LayoutStatus status )
        {
            GetRequest<ResultBase>($"https://api.rms.rakuten.co.jp/es/1.0/shop-page/layouts/{layoutId}/status/{status.ToString().ToLower()}"
                ,method: "DELETE" );
        }
        #endregion
    }
}
