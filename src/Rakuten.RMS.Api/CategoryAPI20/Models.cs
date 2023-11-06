using Rakuten.RMS.Api.JSON;
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
    [DecodableObject]
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
    public class Category : NewCategory
    {
        public string categoryId { get; set; }
        public DateTime created {  get; set; }
        public DateTime updated { get; set; }
    }
    public class CategoryWithBreadcrumbs : Category
    {
        public List<CategoryInBreadcrumbs> breadcrumbList {  get; set; }
    }
    public class CategoryWithChildren
    {
        //public string categoryId { get; set; }
        public Category category { get; set; }
        public List<CategoryWithChildren> children { get; set; }
    }

    internal class InsertCategoryResult
    {
        public string categoryId { get; set; }
    }
    /// <summary>
    /// カテゴリの情報をフルセットで含むカテゴリツリーの全体を保持する。
    /// カテゴリツリーの構造を更新する場合 ToCategoryIdTree() で CategoryIdTree に変換後、変更、UpdateCategoryTree()を呼ぶ。
    /// </summary>
    public class CategoryTree : List<CategoryWithChildren>
    {
        /// <summary>
        /// 更新用のオブジェクトモデルに変換します。
        /// </summary>
        /// <returns></returns>
        public CategoryIdTree ToCategoryIdTree()
        {
            return ConvertChildren(this);
        }
        private CategoryIdTree ConvertChildren(List<CategoryWithChildren> children)
        {
            if (children == null || !children.Any())
                return null;
            return new CategoryIdTree(
                children.Select(c => new CategoryIdWithChildren
                {
                    categoryId = c.category.categoryId,
                    children = ConvertChildren(c.children)
                }));

        }
    }
    public class CategoryTreeResult
    {
        public CategorySet categorySet { get; set; }
        public string categorySetId { get; set; }

        public class RootNode
        {
            public CategoryTree children { get; set; }
        }
        public RootNode rootNode { get; set; }

        public DateTime created { get; set; }
        public DateTime updated { get; set; }

    }
    internal class CategorySetKeyListResult
    {
        public List<string> categorySetKeyList { get; set; }
        public DateTime created { get; set; }
        public DateTime updated { get; set; }
    }
    internal class CategorySetFieldsResult : ResultBase
    {
        public List<CategorySet> categorySetList {  get; set; }
        public DateTime created { get; set; }
        public DateTime updated { get; set; }

    }
    [DecodableObject]
    public class CategoryIdWithChildren
    {
        public CategoryIdWithChildren() { }
        public CategoryIdWithChildren( string categoryId, IList<CategoryIdWithChildren> children)
        {
            this.categoryId = categoryId;
            this.children = children;
        }
        public void Add( CategoryIdWithChildren child)
        {
            var list = children ?? (children = new List<CategoryIdWithChildren>());
            list.Add(child);
        }
        public void Add(string categoryId, IList<CategoryIdWithChildren> children = null )
        {
            var list = this.children ?? (this.children = new List<CategoryIdWithChildren>());
            list.Add(new CategoryIdWithChildren { categoryId = categoryId, children = children });
        }

        public string categoryId { get; set; }
        public IList<CategoryIdWithChildren> children { get; set; }
    }
    /// <summary>
    /// CategorySet の Tree 全体を保持するオブジェクト。
    /// Categoryの詳細情報を含まない ID だけの階層構造を保持。
    /// UpdateCategoryTree メソッドのパラメーターとして使用。
    /// GetCategoryTree()で取得した CategoryTree はカテゴリとその詳細情報を含む階層構造で、
    /// CategoryTree.ToCategoryIdTree() で CategoryIdTree オブジェクトを取得し、
    /// Tree内に存在するCateogryの操作（追加、削除、別ノードへの移動など）を行ったのち
    /// UpdateCategoryTree() で更新することが可能。
    /// </summary>
    public class CategoryIdTree : List<CategoryIdWithChildren>
    {
        public CategoryIdTree() { }
        internal CategoryIdTree( IEnumerable<CategoryIdWithChildren> list)
        {
            AddRange(list);
        }
        public void Add( string categoryId)
        {
            var existing = Find(categoryId);
            if( existing != null)
                throw new InvalidOperationException("CategoryID already exists.");
            Add(new CategoryIdWithChildren { categoryId = categoryId, children = null });
        }
        /// <summary>
        /// カテゴリーツリーから再帰的に目的のカテゴリーIDを検索見つけます。
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public CategoryIdWithChildren Find( string categoryId)
        {
            return Find(categoryId, this).Item1;
        }
        private (CategoryIdWithChildren, IList<CategoryIdWithChildren>) Find(string categoryId, IList<CategoryIdWithChildren> list)
        {
            foreach ( var c in list)
            {
                if (c.categoryId == categoryId)
                {
                    return (c, list);
                }
                if (c.children != null && c.children.Count > 0)
                {
                    var res = Find(categoryId, c.children);
                    if (res.Item1 != null) { return res; }
                }
            }
            return (null, null);
        }
        /// <summary>
        /// カテゴリツリーから指定したカテゴリIDを削除。
        /// 該当のカテゴリは階層構造を再帰的に検索される。
        /// </summary>
        /// <param name="categoryId">削除対象のカテゴリID</param>
        /// <returns>削除されたカテゴリ（ツリー上のノード）このオブジェクトを同じツリーの別ノードに Add することが可能。</returns>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public CategoryIdWithChildren Remove( string categoryId )
        {
            var c = Find(categoryId, this);
            if (c.Item1 == null)
                throw new IndexOutOfRangeException("Category not found: " + categoryId);

            c.Item2.Remove(c.Item1);
            return c.Item1;
        }
        /// <summary>
        /// カテゴリツリーから指定したカテゴリIDを複数一度に削除。
        /// 該当のカテゴリは階層構造を再帰的に検索される。
        /// </summary>
        /// <param name="categoryIds"></param>
        public IList<CategoryIdWithChildren> Remove(IList<string> categoryIds)
        {
            // すべてのノードを検索。万一存在しないノードは Exception 
            var nodesToRemove = categoryIds.Select(id => Find(id,this)).ToList();
            //
            var list = new List<CategoryIdWithChildren>();
            foreach (var node in nodesToRemove)
            {
                node.Item2.Remove(node.Item1);
                list.Add(node.Item1);
            }
            return list;
        }
    }

}
