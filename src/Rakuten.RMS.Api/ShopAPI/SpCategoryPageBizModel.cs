using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.ShopAPI
{
    [XmlType("spCategoryPageBizModel", Namespace = ShopAPI.ModelNamespace)]
    public class SpCategoryPageBizModel
    {
        public SpCategoryPageModel updateModel {  get; set; }
    }
    public class SpCategoryPageModel
    {
        /// <summary>
        /// 大バナー表示  Short	7	No	0 : 表示しない1 : 表示する(default)
        /// </summary>
        public int showBigBanner { get; set; }
        /// <summary>
        /// 大バナーのデザイン   Short	7	No	0 : フリック表示
        /// </summary>
        public int bigBannerUseList { get; set; }
        /// <summary>
        /// 小バナー表示  Short	7	No	0 : 表示しない1 : 表示する(default)
        /// </summary>
        public int showSmallBanner { get; set; }
        /// <summary>
        /// 小バナーのデザイン   Short	7	No	0 : フリック表示(default)1 : 一覧表示
        /// </summary>
        public int smallBannerUseList { get; set; }
        /// <summary>
        /// 目玉商品表示  Short	7	No	0 : 表示しない1 : 表示する(default)
        /// </summary>
        public int showMedamaItem { get; set; }
        /// <summary>
        /// 目玉カテゴリ表示    Short	7	No	0 : 表示しない1 : 表示する(default)
        /// </summary>
        public int showMedamaCategory { get; set; }
        /// <summary>
        /// 営業日カレンダー表示  Short	7	No	0 : 表示しない(default)1 : 表示す
        /// </summary>
        public int showShopCalendar { get; set; }
        /// <summary>
        /// カテゴリページ共通説明文表示  Short	7	No	0 : 表示しない1 : 表示する(default)9	categoryCommonNote カテゴリペ
        /// </summary>
        public string showCategoryCommonNote { get; set; }
    }
}
