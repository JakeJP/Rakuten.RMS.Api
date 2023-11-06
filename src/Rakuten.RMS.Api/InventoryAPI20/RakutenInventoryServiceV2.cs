using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Rakuten.RMS.Api.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Text.Json.Serialization;

namespace Rakuten.RMS.Api.InventoryAPI20
{
    public class RakutenInventoryServiceV2 : RakutenApiJsonClientBase
    {
        public const int MaxUpdateRecord = 400;
        public const int MaxGetStatusRecord = 1000;
        public string Version { get; set; }
        internal RakutenInventoryServiceV2(ServiceProvider provider, string version = "2.0") : base(provider)
        {
            this.Version = version ?? "2.0";
        }
        /// <summary>
        /// https://api.rms.rakuten.co.jp/es/2.0/inventories/manage-numbers/{manageNumber}/variants/{variantId}
        /// https://api.rms.rakuten.co.jp/es/2.1/inventories/manage-numbers/{manageNumber}/variants/{variantId}
        /// </summary>
        /// <param name="itemUrl"></param>
        /// <returns></returns>
        public InventoryStatusResult Get(String manageNumber, string variantId)
        {
            var url = $"https://api.rms.rakuten.co.jp/es/{Version}/inventories/manage-numbers/{manageNumber}/variants/{variantId}";
            return GetRequest<InventoryStatusResult>(url);
        }
        /// <summary>
        /// 商品管理番号とSKU管理番号を指定し、最大で1000件の在庫数を一括で取得できます。
        /// </summary>
        /// <param name="itemUrls"></param>
        /// <returns></returns>
        public List<InventoryStatusResult> BulkGet(InventorySku[] inventories )
        {
            var result = PostRequest<BulkGetResult>("https://api.rms.rakuten.co.jp/es/2.0/inventories/bulk-get",  new { inventories });
            if (result.errors != null && result.errors.Any())
                throw new ErrorResponseException(result);

            return result.inventories;
        }
        /// <summary>
        /// 商品管理番号とSKU管理番号を指定し、最大で1000件の在庫数を一括で取得できます。
        /// </summary>
        /// <param name="minQuantity">最小在庫数</param>
        /// <param name="maxQuantity">最大在庫数</param>
        /// <returns></returns>
        /// <exception cref="ErrorResponseException"></exception>
        public List<InventoryStatusResult> BulkGet( int? minQuantity = null, int? maxQuantity = null)
        {
            var url = $"https://api.rms.rakuten.co.jp/es/2.0/inventories/bulk-get/range";
            var qs = "";
            if (minQuantity != null) qs += (string.IsNullOrEmpty(qs) ? "?" : "&") + "minQuantity=" + minQuantity.ToString();
            if (maxQuantity != null) qs += (string.IsNullOrEmpty(qs) ? "?" : "&") + "maxQuantity=" + maxQuantity.ToString();
            if (!string.IsNullOrEmpty(qs)) url += qs;

            var result = GetRequest<BulkGetResult>(url);
            if (result.errors != null && result.errors.Any())
                throw new ErrorResponseException(result);

            return result.inventories;
        }

        public ResultBase Upsert(String manageNumber, string variantId, UpsertMode mode, int quantity)
        {
            return PostRequest<ResultBase>($"https://api.rms.rakuten.co.jp/es/{Version}/inventories/manage-numbers/{manageNumber}/variants/{variantId}",
                new { mode = mode.ToString(), quantity = quantity },
                method: "PUT");

        }
        /// <summary>
        /// 商品管理番号とSKU管理番号を指定し、在庫情報を削除する
        /// </summary>
        /// <param name="manageNumber"></param>
        /// <param name="variantId"></param>
        /// <returns></returns>
        public ResultBase Delete(string manageNumber, string variantId)
        {
            var result = GetRequest<ResultBase>($"https://api.rms.rakuten.co.jp/es/{Version}/inventories/manage-numbers/{manageNumber}/variants/{variantId}", method: "DELETE");
            return result;
        }

        public ResultBase BulkUpsert(IEnumerable<InventorySkuUpsert> inventories)
        {
            var result = PostRequest<ResultBase>($"https://api.rms.rakuten.co.jp/es/{Version}/inventories/bulk-upsert",
                new { inventories = inventories });
            return result;
        }
    }
}
