using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rakuten.RMS.Api.JSON;

namespace Rakuten.RMS.Api.LicenseManagementAPI
{
    public class LicenseManagementAPI : RakutenApiJsonClientBase
    {
        public LicenseManagementAPI(ServiceProvider serviceProvider) :base(serviceProvider) { }
        public DateTime GetExpiryDate( string licenseKey)
        
            => GetRequest<LicenseResult>($"https://api.rms.rakuten.co.jp/es/1.0/license-management/license-key/expiry-date?licenseKey={licenseKey}").expiryDate;

        /// <summary>
        /// 現在接続に使用している licenseKey の有効期限を取得。
        /// </summary>
        /// <returns></returns>
        public DateTime GetExpiryDate()
            => GetRequest<LicenseResult>($"https://api.rms.rakuten.co.jp/es/1.0/license-management/license-key/expiry-date?licenseKey={provider.LicenseKey}").expiryDate;

        protected class LicenseResult
        {
            public DateTime expiryDate { get; set; }
        }
    }
}
