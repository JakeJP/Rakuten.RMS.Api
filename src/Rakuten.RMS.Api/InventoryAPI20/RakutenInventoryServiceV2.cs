using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Rakuten.RMS.Api.JSON;
using System;
using System.Collections.Generic;
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
        /// itemUrl は小文字
        /// </summary>
        /// <param name="itemUrls"></param>
        /// <returns></returns>
        public List<InventoryStatusResult> BulkGet(InventorySku[] inventories)
        {
            var result = PostRequest<BulkGetResult>($"https://api.rms.rakuten.co.jp/es/{Version}/inventories/bulk-get", inventories);

            return result.inventories;
        }

        public ResultBase Upsert(String manageNumber, string variantId, UpsertMode mode, int quantity)
        {
            return PostRequest<ResultBase>($"https://api.rms.rakuten.co.jp/es/{Version}/inventories/manage-numbers/{manageNumber}/variants/{variantId}",
                new { mode = mode.ToString(), quantity = quantity },
                method: "PUT");

        }
        public ResultBase Delete(string manageNumber, string variantId)
        {
            var result = GetRequest<ResultBase>($"https://api.rms.rakuten.co.jp/es/{Version}/inventories/manage-numbers/{manageNumber}/variants/{variantId}", method: "DELETE");
            return result;
        }

        public void GetRange(int? minQuantity = null, int? maxQuantity = null)
        {
            var qs = new StringBuilder();
            if (minQuantity != null) { qs.AppendFormat("minQuantity={0}", minQuantity); }
            if (maxQuantity != null)
            {
                if (qs.Length > 0) qs.Append("&");
                qs.AppendFormat("maxQuantity={0}", maxQuantity);
            }
            GetRequest<ResultBase>($"https://api.rms.rakuten.co.jp/es/{Version}/inventories/bulk-get/range?" + qs.ToString());
        }
        public ResultBase BulkUpsert(IEnumerable<InventorySkuUpsert> inventories)
        {
            var result = PostRequest<ResultBase>($"https://api.rms.rakuten.co.jp/es/{Version}/inventories/bulk-upsert",
                new { inventories = inventories });
            return result;
        }
    }
}
