using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rakuten.RMS.Api.CategoryAPI20
{
    /// <summary>
    /// breadcrumb=falseの場合
    /// </summary>
    public class GetItemMappingResponse
    {
        public List<string> categoryIds { get; set; }
        public string mainPluralCategoryId { get; set; }
        public DateTime created { get; set; }
        public DateTime updated { get; set; }
    }
    public class GetItemMappingWithBreadcrumbResponse
    {
        public string manageNumber { get; set; }
        public List<CategoryWithBreadcrumsForMapping> categories { get; set; }
        public string mainPluralCategoryId { get; set; }
        public DateTime created { get; set; }
        public DateTime updated { get; set; }
    }
    public class CategoryWithBreadcrumsForMapping : Category
    {
        public CategorySet categorySet { get; set; }
        public List<Category> breadcrumbList { get; set; }
    }
}
