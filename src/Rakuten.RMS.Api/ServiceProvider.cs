using System;
using System.Collections.Specialized;
using System.Text;

namespace Rakuten.RMS.Api
{
    /// <summary>
    /// APIへのアクセスを提供する。アクセスキーとして serviceSecret, licenseKey の２つが必要。
    /// APIのグループごとにGet***メソッドでグループごとのAPIアクセスのためのクラスを取得する。
    /// </summary>
    public class ServiceProvider
    {
        internal string ServiceSecret { get; set; }
        internal string LicenseKey { get; set; }
        /// <summary>
        /// serviceSecret と licenseKey.
        /// または serviceSecret = [serviceSecret]:[licenseKey], licenseKey = null の組み合わせも可能
        /// </summary>
        /// <param name="serviceSecret"></param>
        /// <param name="licenseKey"></param>
        public ServiceProvider(string serviceSecret, string licenseKey)
        {
            ServiceSecret = serviceSecret;
            LicenseKey = licenseKey;
            if( string.IsNullOrEmpty(licenseKey) && serviceSecret.Contains(":"))
            {
                LicenseKey = serviceSecret.Substring(serviceSecret.IndexOf(":") + 1);
                ServiceSecret = serviceSecret.Substring(0, serviceSecret.IndexOf(":"));
            }
            AuthorizationHeaderValue = "ESA " + Convert.ToBase64String(Encoding.ASCII.GetBytes(ServiceSecret + ":" + LicenseKey));
        }
        public ServiceProvider(NameValueCollection registry) : this(registry["serviceSecret"], registry["licenseKey"])
        {
        }
        internal string AuthorizationHeaderValue { get; set; }

        /// <summary>
        /// 商品API 2.0（ItemAPI 2.0）
        /// </summary>
        /// <returns></returns>
        public ItemAPI20.ItemAPI20 GetItemAPI20() => new ItemAPI20.ItemAPI20(this);
        public ItemAPI.ItemAPI GetItemAPI() => throw new NotImplementedException();
        public CategoryAPI.CategoryAPI GetCategoryAPI => new CategoryAPI.CategoryAPI(this);
        /// <summary>
        /// カテゴリAPI 2.0（CategoryAPI 2.0）
        /// </summary>
        /// <returns></returns>
        public CategoryAPI20.CategoryAPI20 GetCategoryAPI20() => new CategoryAPI20.CategoryAPI20(this);

        /// <summary>
        /// 在庫API 在庫API 2.1（InventoryAPI 2.1）
        /// </summary>
        /// <returns></returns>
        public InventoryAPI21.RakutenInventoryServiceV21 GetInventoryAPI21()
            => new InventoryAPI21.RakutenInventoryServiceV21(this);
        /// <summary>
        /// 在庫API 2.0（InventoryAPI 2.0）
        /// </summary>
        /// <returns></returns>
        public InventoryAPI20.RakutenInventoryServiceV2 GetInventoryAPI20()
            => new InventoryAPI20.RakutenInventoryServiceV2(this);
#if false
        public void GetInventoryAPI() => throw new NotImplementedException();
#endif
        /// <summary>
        /// ナビゲーションAPI ジャンル・商品属性情報検索API（NavigationAPI 2.0）
        /// </summary>
        /// <returns></returns>
        public NavigationAPI20.NavigationAPI20 GetNavigationAPI20()
            => new NavigationAPI20.NavigationAPI20(this);
#if false
        public void GetNavigationAPI()
            => throw new NotImplementedException();
#endif
        /// <summary>
        /// 組み合わせ販売API（ItemBundleAPI））
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void GetItemBundleAPI() => throw new NotImplementedException();
        /// <summary>
        /// R-CabinetAPI（CabinetAPI）
        /// </summary>
        /// <returns></returns>
        public CabinetAPI.CabinetAPI GetCabinetAPI() => new CabinetAPI.CabinetAPI(this);
        /// <summary>
        /// 製品API（ProductAPI）
        /// </summary>
        /// <returns></returns>
        public ProductAPI.ProductAPI GetProductAPI() => new ProductAPI.ProductAPI(this);

        /// <summary>
        /// 楽天ペイ受注API（RakutenPayOrderAPI）
        /// </summary>
        /// <returns></returns>
        public RakutenPayOrderAPI.RakutenPayOrderService GetRakutenPayOrderAPI()
            => new RakutenPayOrderAPI.RakutenPayOrderService(this);
        /// <summary>
        /// 購入商品API（PurchaseItemAPI）
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public PurchaseItemAPI.PurchaseItemAPI GetPurchaseItemAPI() => new PurchaseItemAPI.PurchaseItemAPI(this);
        /// <summary>
        /// 購入申込API（ReserveAPI）
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public ReserveAPI.ReserveAPI GetReserveAPI() => new ReserveAPI.ReserveAPI(this);
        /// <summary>
        /// 問い合わせ管理API（InquiryManagementAPI）
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public InquiryManagementAPI.InquiryManagementAPI GetInquiryManagementAPI() => new InquiryManagementAPI.InquiryManagementAPI(this);
        /// <summary>
        /// 店舗情報API（ShopAPI）
        /// </summary>
        /// <returns></returns>
        public ShopAPI.ShopAPI GetShopAPI()
            => new ShopAPI.ShopAPI(this);
        /// <summary>
        /// 店舗ページAPI（ShopPageAPI）
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void GetShopPageAPI() => throw new NotImplementedException();
        /// <summary>
        /// クーポンAPI（CouponAPI）
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void GetCouponAPI() => throw new NotImplementedException();
        /// <summary>
        /// ライセンス管理API（LicenseManagementAPI）
        /// </summary>
        /// <returns></returns>
        public LicenseManagementAPI.LicenseManagementAPI GetLicenseManagementAPI()
            => new LicenseManagementAPI.LicenseManagementAPI(this);

    }
}
