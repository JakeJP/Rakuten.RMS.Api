using Rakuten.RMS.Api.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

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
        public void GetReserveInfoList(InfoListRequest request)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 一括で早期確定を行う
        /// </summary>
        public void UpdateReserveEarlyCommit()
        {
            throw new NotImplementedException();
        }
    }
}
