using Rakuten.RMS.Api.JSON;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Rakuten.RMS.Api.ReserveAPI
{

    public class ReserveAPI : RakutenApiJsonClientBase
    {
        internal ReserveAPI(ServiceProvider provider) : base(provider)
        {
        }
        /// <summary>
        /// 申込情報一覧を取得
        /// </summary>
        public InfoListResponse GetReserveInfoList(InfoListRequest request)
        {
            if(request == null) throw new ArgumentNullException(nameof(request));
            var qs = new System.Collections.Specialized.NameValueCollection();
            typeof(InfoListRequest).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance)
                .Select(p =>
                {
                    var key = p.Name;
                    string value = null;
                    var v = p.GetValue(request, null);
                    if (v != null && (v is DateTime || v is DateTime?))
                        value = ((DateTime)v).ToString("yyyy-MM-dd");
                    else
                        value = v == null ? null : v.ToString();
                    return new { key, value };
                })
                .Where(m => !string.IsNullOrEmpty(m.value))
                .ToList()
                .ForEach(m => qs.Add( m.key, m.value ) );

            return GetRequest<InfoListResponse>("https://api.rms.rakuten.co.jp/es/1.0/reserve/reserveInfoList",
                queryParameters: qs);
        }
        /// <summary>
        /// 一括で早期確定を行う
        /// </summary>
        public ReserveUpdateResponse UpdateReserveEarlyCommit( IList<ReserveKeyListModel> reserveKeyList )
        {
            if (reserveKeyList == null) throw new ArgumentNullException(nameof(reserveKeyList));
            if (reserveKeyList.Count == 0 || reserveKeyList.Count > 500)
                throw new InvalidOperationException("Count of reserveKeyList must be 1 up to 500.");
            return PostRequest<ReserveUpdateResponse>("https://api.rms.rakuten.co.jp/es/1.0/reserve/earlyCommitReservations",
                new { reserveKeyList });
        }
    }
}
