using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

using Rakuten.RMS.Api.JSON;

namespace Rakuten.RMS.Api.ItemBundleAPI
{
    public class ItemBundleAPI : RakutenApiJsonClientBase
    {
        internal ItemBundleAPI(ServiceProvider serviceProvider) : base(serviceProvider) { }

        public Bundle Create(BundleToCreate bundle )
        {
            return PostRequest<Bundle>("https://api.rms.rakuten.co.jp/es/1.0/bto/bundle", bundle);
        }
        public void Delete( string bundleManageNumber)
        {
            var res = GetRequest<ResultBase>($"https://api.rms.rakuten.co.jp/es/1.0/bto/bundle/{bundleManageNumber}", method: "DELETE");
            if (res != null && res.errors?.Count > 0)
                throw new ErrorResponseException(res);
        }
        public Bundle GetBundle( string bundleManageNumber)
            => GetRequest<Bundle>($"https://api.rms.rakuten.co.jp/es/1.0/bto/bundle/{bundleManageNumber}");
        public BundleListResponse GetBundleList(BundleListRequest request)
        {
            var qs = new NameValueCollection();
            foreach( var kv in typeof(BundleListRequest).GetProperties(System.Reflection.BindingFlags.Public| System.Reflection.BindingFlags.Instance)
                .Select( p => new { p.Name, Value = p.GetValue(request, null) })
                .Where( m => m.Value != null))
            {
                qs.Add(kv.Name, kv.Value.ToString());
            }
            return GetRequest<BundleListResponse>("https://api.rms.rakuten.co.jp/es/1.0/bto/bundles", queryParameters: qs);
        }
        public Bundle Update(string bundleManageNumber, BundleToCreate bundle)
        {
            return PostRequest<Bundle>($"https://api.rms.rakuten.co.jp/es/1.0/bto/bundle/{bundleManageNumber}", bundle, method:"PUT");
        }
}

}
