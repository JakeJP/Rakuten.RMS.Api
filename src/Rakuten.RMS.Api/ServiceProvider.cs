using System;
using System.Collections.Specialized;
using System.Text;

namespace Rakuten.RMS.Api
{
    public class ServiceProvider
    {
        public string ServiceSecret { get; set; }
        public string LicenseKey { get; set; }

        public ServiceProvider(string serviceSecret, string licenseKey)
        {
            ServiceSecret = serviceSecret;
            LicenseKey = licenseKey;
            AuthorizationHeaderValue = "ESA " + Convert.ToBase64String(Encoding.ASCII.GetBytes(ServiceSecret + (string.IsNullOrEmpty(LicenseKey) ? "" : ":" + LicenseKey)));
        }
        public ServiceProvider(NameValueCollection registry) : this(registry["serviceSecret"], registry["licenseKey"])
        {
        }
        internal string AuthorizationHeaderValue { get; set; }

        public ItemAPI20.ItemAPI20 GetItemAPI20() => new ItemAPI20.ItemAPI20(this);
        public ItemAPI.ItemAPI GetItemAPI() => throw new NotImplementedException();
        public CategoryAPI.CategoryAPI GetCategoryAPI => new CategoryAPI.CategoryAPI(this);
        public CategoryAPI20.CategoryAPI20 GetCategoryAPI20() => new CategoryAPI20.CategoryAPI20(this);

        public InventoryAPI21.RakutenInventoryServiceV21 GetInventoryAPI21()
            => new InventoryAPI21.RakutenInventoryServiceV21(this);
        public InventoryAPI20.RakutenInventoryServiceV2 GetInventoryAPI20()
            => new InventoryAPI20.RakutenInventoryServiceV2(this);
        public void GetInventoryAPI() => throw new NotImplementedException();

        public NavigationAPI20.NavigationAPI20 GetNavigationAPI20()
            => new NavigationAPI20.NavigationAPI20(this);
        public void GetNavigationAPI()
            => throw new NotImplementedException();

        public void GetItemBundleAPI() => throw new NotImplementedException();
        public CabinetAPI.CabinetAPI GetCabinetAPI() => new CabinetAPI.CabinetAPI(this);
        public ProductAPI.ProductAPI GetProductAPI() => new ProductAPI.ProductAPI(this);


        public RakutenPayOrderAPI.RakutenPayOrderService GetRakutenPayOrderAPI()
            => new RakutenPayOrderAPI.RakutenPayOrderService(this);

        public void GetPurchaseItemAPI() => throw new NotImplementedException();
        public void ReserveAPI() => throw new NotImplementedException();
        public void GetInquiryManagementAPI() => throw new NotImplementedException();

        public ShopAPI.ShopAPI GetShopAPI()
            => new ShopAPI.ShopAPI(this);
        public void GetShopPageAPI() => throw new NotImplementedException();
        public void GetCouponAPI() => throw new NotImplementedException();
        public LicenseManagementAPI.LicenseManagementAPI GetLicenseManagementAPI() => new LicenseManagementAPI.LicenseManagementAPI(this);

    }
}
