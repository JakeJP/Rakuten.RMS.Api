using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rakuten.RMS.Api.JSON;

namespace Rakuten.RMS.Api.CategoryAPI20
{
    public enum CategorySetField
    {
        /// <summary>
        /// カテゴリセット名
        /// </summary>
        TITLE,
        /// <summary>
        /// カテゴリセット設定
        /// </summary>
        CATEGORY_SET_FEATURES,
        /// <summary>
        /// カテゴリセットの登録日時
        /// </summary>
        CREATED,
        /// <summary>
        /// カテゴリセットの更新日時
        /// </summary>
        UPDATED
    }
    public enum CategoryField
    {
        /// <summary>
        /// カテゴリセットID
        /// </summary>
        CATEGORY_SET_ID,
        /// <summary>
        /// カテゴリ名
        /// </summary>
        TITLE,
        /// <summary>
        /// カテゴリ設定
        /// </summary>
        CATEGORY_FEATURES,
        /// <summary>
        /// カテゴリ説明文
        /// </summary>
        DESCRIPTION,
        /// <summary>
        /// カテゴリ説明文下
        /// </summary>
        ADDITIONALDESCRIPTION,
        /// <summary>
        /// カテゴリ画像
        /// </summary>
        IMAGES,
        /// <summary>
        /// カテゴリレイアウト
        /// </summary>
        LAYOUT,
        /// <summary>
        /// カテゴリの登録日時
        /// </summary>
        CREATED,
        /// <summary>
        /// カテゴリの更新日時
        /// </summary>
        UPDATED
    }

    public class CategoryAPI20 : RakutenApiJsonClientBase
    {

        public CategoryAPI20( ServiceProvider serviceProvider ) : base( serviceProvider )
        {
        }
        public CategoryWithBreadcrumbs GetShopCategories( string categoryId, bool? breadcrumb = null, CategorySetField [] categorysetfields = null, CategoryField[] categoryfields = null)
        {
            var qs = new NameValueCollection();
            if (breadcrumb != null) qs["breadcrumb"] = breadcrumb.ToString().ToLower();
            if (categorysetfields != null && categorysetfields.Length > 0) qs["categorysetfields"] = string.Join(",", categorysetfields.Select(m => m.ToString()));
            if (categoryfields != null && categoryfields.Length > 0) qs["categoryfields"] = string.Join(",", categoryfields.Select(m => m.ToString()));
            return GetRequest<CategoryWithBreadcrumbs>($"https://api.rms.rakuten.co.jp/es/2.0/categories/shop-categories/category-ids/{categoryId}",
                queryParameters: qs);
        }
        public string InsertShopCategory(NewCategory category)
        {
            return PostRequest<InsertCategoryResult>($"https://api.rms.rakuten.co.jp/es/2.0/categories/shop-categories", category, method: "POST").categoryId;
        }
        public ResultBase UpdateShopCategory( string categoryId, NewCategory category )
        {
            return PostRequest<ResultBase>($"https://api.rms.rakuten.co.jp/es/2.0/categories/shop-categories/category-ids/{categoryId}",
                category,
                method: "POST");

        }
        public void GetItemMappings( string manageNumber, bool? breadcrumb = null, CategorySetField[] categorysetfields = null, CategoryField[] categoryfields = null)
        {
            throw new NotImplementedException();
        }
        public void UpsertItemMappings(string manageNumber )
        {
            throw new NotImplementedException();
        }
        public void DeleteItemMappings( string manageNumber ) 
        {
            throw new NotImplementedException();
        }
        public CategoryTreeResult GetCategoryTrees( string categorySetId, CategorySetField[] categorysetfields = null, CategoryField[] categoryfields = null)
        {
            var qs = new NameValueCollection();
            if (categorysetfields != null && categorysetfields.Length > 0) qs["categorysetfields"] = string.Join(",", categorysetfields.Select(m => m.ToString()));
            if (categoryfields != null && categoryfields.Length > 0) qs["categoryfields"] = string.Join(",", categoryfields.Select(m => m.ToString()));
            return GetRequest<CategoryTreeResult>($"https://api.rms.rakuten.co.jp/es/2.0/categories/shop-category-trees/category-set-ids/{categorySetId}", queryParameters: qs);
        }
        public void UpsertCategoryTrees(string categorySetId )
        {
            throw new NotImplementedException();
        }
        public CategorySetKeyListResult GetCategorySetLists()
        {
            return GetRequest<CategorySetKeyListResult>($"https://api.rms.rakuten.co.jp/es/2.0/categories/shop-category-set-lists");
        }
        public CategorySetFieldsResult GetCategorySetLists(params CategorySetField[] categorysetfields )
        {
            if (categorysetfields == null || categorysetfields.Length == 0)
                throw new ArgumentException("categorysetfields must have one or more elements.");
            var qs = new NameValueCollection();
            qs["categorysetfields"] = string.Join(",", categorysetfields.Select(m=>m.ToString()));
            return GetRequest<CategorySetFieldsResult>($"https://api.rms.rakuten.co.jp/es/2.0/categories/shop-category-set-lists",
                queryParameters: qs);
        }

    }
}
