using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rakuten.RMS.Api.CategoryAPI20
{
    public class CategoryFeatures
    {
        public bool display { get; set; }
        public CategoryPageViewMode categoryPageViewMode { get; set; }
    }

    public enum CategoryPageViewMode
    {
        /// <summary>
        /// リスト形式
        /// </summary>
        LIST,
        /// <summary>
        /// ウィンドウショッピング形式
        /// </summary>
        GALLERY,
        /// <summary>
        /// 1ページ複数商品形式
        /// </summary>
        PLURAL
    }
    public class Layout
    {
        public long navigationId { get; set; }
        public long layoutCategorySequenceId { get; set; }
        public long smallDescriptionId { get; set; }
        public long showcaseId { get; set; }
        public long largeDescriptionId { get; set; }

    }
    public class CategorySetFeatures
    {
        public bool? display { get; set; }
    }
    public class CategorySet
    {
        public string categorySetId { get; set; }
        public string title { get; set; }
        public CategorySetFeatures categorySetFeatures { get; set; }
        public DateTime? created { get; set; }
        public DateTime? updated { get; set; }
    }
    public class Breadcrumbs
    {
        public CategorySet categorySet { get; set; }
        public List<CategoryInBreadcrumbs> breadcrumbList { get; set; }
    }
    public class NewCategory
    {
        public string categorySetId { get; set; }
        public string title { get; set; }
        public CategoryFeatures categoryFeatures { get; set; }
        public ItemAPI20.ItemCommon.ProductDescription description { get; set; }
        public string additionalDescription { get; set; }
        public List<ItemAPI20.ItemCommon.Image> images { get; set; }
        public Layout layout { get; set; }

    }
    public class CategoryInBreadcrumbs : NewCategory
    {
        public string categoryId { get; set; }
        public DateTime? created { get; set; }
        public DateTime? updated { get; set; }
    }
    public class Category
    {
        public string categoryId { get; set; }
        public string categorySetId { get; set; }
        public string title { get; set; }
        public CategoryFeatures categoryFeatures { get; set; }
        public ItemAPI20.ItemCommon.ProductDescription description { get; set; }
        public string additionalDescription { get; set; }
        public List<ItemAPI20.ItemCommon.Image> images { get; set; }
        public Layout layout { get; set; }
        public DateTime created {  get; set; }
        public DateTime updated { get; set; }
    }
    public class CategoryWithBreadcrumbs : Category
    {
        public List<CategoryInBreadcrumbs> breadcrumbList {  get; set; }
    }
    public class CategoryAndChildren
    {
        public string categoryId { get; set; }
        public Category category { get; set; }
        public List<CategoryAndChildren> children { get; set; }
    }

    public class InsertCategoryResult
    {
        public string categoryId { get; set; }
    }

    public class CategoryTreeResult
    {
        public CategorySet categorySet { get; set; }
        public string categorySetId { get; set; }
        public class RootNode
        {
            public List<CategoryAndChildren> children { get; set; }
        }
        public RootNode rootNode { get; set; }

        public DateTime created { get; set; }
        public DateTime updated { get; set; }

    }
    public class CategorySetKeyListResult
    {
        public List<string> categorySetKeyList { get; set; }
        public DateTime created { get; set; }
        public DateTime updated { get; set; }
    }
    public class CategorySetFieldsResult
    {
        public List<CategorySet> categorySetList {  get; set; }
        public DateTime created { get; set; }
        public DateTime updated { get; set; }

    }
}
