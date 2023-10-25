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
    /// <summary>
    /// カテゴリ情報を取得し、更新
    /// </summary>
    public class CategoryAPI20 : RakutenApiJsonClientBase
    {

        public CategoryAPI20( ServiceProvider serviceProvider ) : base( serviceProvider )
        {
        }
        /// <summary>
        /// カテゴリ情報を取得し、更新
        /// </summary>
        /// <param name="categoryId">カテゴリID</param>
        /// <param name="breadcrumb">true：指定したカテゴリと、パンくずでつながった全ての上位カテゴリ情報 false：指定したカテゴリ情報のみ（デフォルト）</param>
        /// <param name="categorysetfields">カテゴリセットフィールド
        /// レスポンスの”breadcrumbs“内の以下のカテゴリセット情報を取得したい場合は指定。
        /// </param>
        /// <param name="categoryfields">カテゴリフィールド
        /// レスポンスの”breadcrumbs“内の以下のカテゴリ情報を取得したい場合は指定。</param>
        /// <returns></returns>
        public CategoryWithBreadcrumbs GetShopCategories( string categoryId, bool? breadcrumb = null, CategorySetField [] categorysetfields = null, CategoryField[] categoryfields = null)
        {
            var qs = new NameValueCollection();
            if (breadcrumb != null) qs["breadcrumb"] = breadcrumb.ToString().ToLower();
            if (categorysetfields != null && categorysetfields.Length > 0) qs["categorysetfields"] = string.Join(",", categorysetfields.Select(m => m.ToString()));
            if (categoryfields != null && categoryfields.Length > 0) qs["categoryfields"] = string.Join(",", categoryfields.Select(m => m.ToString()));
            return GetRequest<CategoryWithBreadcrumbs>($"https://api.rms.rakuten.co.jp/es/2.0/categories/shop-categories/category-ids/{categoryId}",
                queryParameters: qs);
        }
        /// <summary>
        /// カテゴリ情報を登録
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public string InsertShopCategory(NewCategory category)
        {
            return PostRequest<InsertCategoryResult>($"https://api.rms.rakuten.co.jp/es/2.0/categories/shop-categories", category, method: "POST").categoryId;
        }
        /// <summary>
        /// カテゴリIDを指定しカテゴリ情報を更新
        /// </summary>
        /// <param name="categoryId">カテゴリID</param>
        /// <param name="category"></param>
        /// <returns></returns>
        public ResultBase UpdateShopCategory( string categoryId, NewCategory category )
        {
            return PostRequest<ResultBase>($"https://api.rms.rakuten.co.jp/es/2.0/categories/shop-categories/category-ids/{categoryId}",
                category,
                method: "POST");

        }
        /// <summary>
        /// 商品管理番号を指定し、カテゴリとの紐付き情報を取得
        /// </summary>
        /// <param name="manageNumber">商品管理番号</param>
        /// <param name="breadcrumb">パンくずリスト</param>
        /// <param name="categorysetfields">カテゴリセットフィールド</param>
        /// <param name="categoryfields">カテゴリフィールド</param>
        /// <exception cref="NotImplementedException"></exception>
        public void GetItemMappings( string manageNumber, bool? breadcrumb = null, CategorySetField[] categorysetfields = null, CategoryField[] categoryfields = null)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 指定した商品管理番号の表示先カテゴリの登録や変更
        /// </summary>
        /// <param name="manageNumber"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void UpsertItemMappings(string manageNumber )
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 指定した商品管理番号を表示先カテゴリから削除
        /// </summary>
        /// <param name="manageNumber"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void DeleteItemMappings( string manageNumber ) 
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// カテゴリセットIDを指定しカテゴリツリー情報を取得
        /// </summary>
        /// <param name="categorySetId">カテゴリセットID カテゴリセットを利用していない場合、「0」を指定。</param>
        /// <param name="categorysetfields">カテゴリセットフィールド</param>
        /// <param name="categoryfields">カテゴリフィールド</param>
        /// <returns></returns>
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
        /// <summary>
        /// すべてのカテゴリセット情報を取得
        /// </summary>
        /// <returns></returns>
        public CategorySetKeyListResult GetCategorySetLists()
        {
            return GetRequest<CategorySetKeyListResult>($"https://api.rms.rakuten.co.jp/es/2.0/categories/shop-category-set-lists");
        }
        /// <summary>
        /// すべてのカテゴリセット情報を取得.取得したいカテゴリセット情報を指定する場合。
        /// </summary>
        /// <param name="categorysetfields"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
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
