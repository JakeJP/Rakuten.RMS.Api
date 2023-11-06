using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using static Rakuten.RMS.Api.ItemAPI20.SearchResult;

namespace Rakuten.RMS.Api.ItemAPI20
{
    [DecodableObject]
    public class SearchCondition
    {
        public string title { get; set; }
        public string tagline { get; set; }
        public string manageNumber { get; set; }
        public string itemNumber { get; set; }
        public string articleNumber {  get; set; }
        public string variantId { get; set; }
        public string merchantDefinedSkuId { get; set; }
        public string genreId { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public ItemCommon.ItemType? itemType { get; set; }
        public bool? isAsuraku { get; set; }
        public long? standardPriceFrom { get; set; }
        public long? standardPriceTo { get; set; }
        public bool? isVariantStockout { get; set; }
        public bool? isItemStockout { get; set; }
        public DateTime? purchasablePeriodFrom { get; set; }
        public DateTime? purchasablePeriodTo { get; set; }
        public bool? isHiddenItem { get; set; }
        public bool? isHiddenVariant {  get; set; }
        public bool? isSearchable {  get; set; }
        public bool? isYamiichi {  get; set; }
        public DateTime? pointApplicablePeriodFrom { get; set; }
        public DateTime? pointApplicablePeriodTo { get; set; }
        public bool? isOptimizedPoint {  get; set; }
        public int? pointRate {  get; set; }
        public int? maxPointRate {  get; set; }
        public string categoryId { get; set; }
        public bool? isBackOrder { get; set; }
        public bool? isPostageIncluded {  get; set; }
        public DateTime? createdFrom {  get; set; }
        public DateTime? createdTo { get; set;}
        public DateTime? updatedFrom { get; set; }
        public DateTime? updatedTo { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public SearchSortKey? sortKey {  get; set; }
        public int? sortOrder {  get; set; }
        public int? offset {  get; set; }
        public int? hits {  get; set; }
        public string cursorMark { get; set; }
        public bool? isCategoryIncluded {  get; set; }
        public bool? isReviewIncluded {  get; set; }
        public bool? isInventoryIncluded {  get; set; }
    }
    public enum SearchSortKey
    {
        /// <summary>
        /// 更新日（デフォルト）
        /// </summary>
        updated,
        /// <summary>
        /// 登録日
        /// </summary>
        created,
        /// <summary>
        /// カテゴリ表示順位
        /// </summary>
        itemDisplaySequence,
        /// <summary>
        /// 商品管理番号
        /// </summary>
        manageNumber,
        /// <summary>
        /// 販売期間開始
        /// </summary>
        purchasablePeriodStart,
        /// <summary>
        /// 販売期間終了
        /// </summary>
        purchasablePeriodEnd,
        /// <summary>
        /// ポイント変倍期間開始
        /// </summary>
        pointCampaignStart,
        /// <summary>
        /// ポイント変倍期間終了
        /// </summary>
        pointCampaignEnd,
        /// <summary>
        /// ポイント変倍率
        /// </summary>
        pointRate,
        /// <summary>
        /// レビュー件数
        /// </summary>
        reviewCount,
        /// <summary>
        /// レビュー評価平均点
        /// </summary>
        reviewAverageRating
    }
    public class SearchResult
    {
        public int numFound {  get; set; }
        public int offset {  get; set; }
        public string nextCursorMark {  get; set; }
        public List<Item> results { get; set; }

        public class InventorySku
        {
            public class OperationLeadTime
            {
                public int? normalDeliveryTimeId { get; set; }
                public int? backOrderDeliveryTimeId { get; set; }
            }
            public OperationLeadTime operationLeadTime { get; set; }
            public List<int> shipFromIds { get; set; }
        }
        public class InventorySkuContainer : Dictionary<string, InventorySku>
        {
            public DateTime created { get; set; }
            public DateTime updated { get; set; }
        }
        public class Review
        {
            public int? count { get; set; }
            public float? averageRating { get; set; }
        }
        public class Category
        {
            public List<string> categoryIds { get; set; }
        }
        public class Item
        {
            public Api.ItemAPI20.Item item { get; set; }
            public Category category { get; set; }
            public Review review { get; set; }
            public InventorySkuContainer inventory { get; set; }

        }
    }
}
