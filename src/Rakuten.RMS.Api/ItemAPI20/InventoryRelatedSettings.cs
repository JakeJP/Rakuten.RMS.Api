using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using static Rakuten.RMS.Api.ItemAPI20.ItemCommon;

namespace Rakuten.RMS.Api.ItemAPI20
{
    public class InventoryRelatedSettings
    {
        [Required]
        public bool unlimitedInventoryFlag { get; set; }
        public class Features
        {
            [JsonConverter(typeof(StringEnumConverter))]
            [Required]
            public InventoryDisplayEnum inventoryDisplay { get; set; }
            /// <summary>
            /// 許容値：1～20
            /// </summary>
            public int? lowStockThreshold { get; set; }
        }
        [Required]
        public Features features { get; set; }

        public class Variant
        {
            public bool? restockOnCancel { get; set; }
            public bool? backOrderFlag { get; set; }
            public int? backOrderDeliveryDateId { get; set; }
            public int? normalDeliveryDateId { get; set; }
        }
        [Required]
        public Dictionary<string, Variant> variants { get; set; }
    }
}
