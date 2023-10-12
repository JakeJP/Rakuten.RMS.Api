using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rakuten.RMS.Api.JSON;

namespace Rakuten.RMS.Api.InventoryAPI20
{
    public enum UpsertMode
    {
        ABSOLUTE, RELATIVE
    }
    public class InventoryStatusResult : InventorySku
    {
        public long quantity { get; set; }
        public DateTime created { get; set; }
        public DateTime updated { get; set; }
    }

    public class InventorySku : ResultBase
    {
        public string manageNumber { get; set; }
        public string variantId { get; set; }
    }
    public class InventorySkuUpsert : InventorySku
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public UpsertMode mode { get; set; }
        public int quantity { get; set; }

        // for V2.1
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public OperationLeadTime operationLeadTime { get; set; }
        /// <summary>
        /// IDの値はShopAPIの shop.shipFrom.get の下記項目から取得可能。 Level 3: shipFrom - shipFromId
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IList<int> shipFromIds { get; set; }

    }
    // V2.1
    public class InventorySkuUpsertV21 : InventorySkuUpsert
    {
    }
    public class OperationLeadTime
    {
        public int? normalDeliveryTimeId { get; set; }
        public int? backOrderDeliveryTimeId { get; set; }
    }

    public class BulkGetResult : ResultBase
    {
        public List<InventoryStatusResult> inventories { get; set; }
    }

}
