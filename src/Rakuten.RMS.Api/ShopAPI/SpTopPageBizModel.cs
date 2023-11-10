using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.ShopAPI
{
    [XmlType("spTopPageBizModel", Namespace = ShopAPI.ModelNamespace)]
    public class SpTopPageBizModel
    {
        public SpTopPage updateModel {  get; set; }
    }
    public class SpTopPage
    {
        public int? useOriginalSignboard {  get; set; }
        public string signboardUrl { get; set; }
        public int? bigBannerPosition {  get; set; }
        public int? showBigBanner { get; set; }
        public int? bigBannerUseList { get; set; }
        public int? smallBannerPosition { get; set; }
        public int? showSmallBanner { get; set; }
        public int? smallBannerUseFlick { get; set; }
        public int? medamaItemPosition { get; set; }
        public int? showMedamaItem { get; set; }
        public int? medamaCategoryPosition { get; set; }
        public int? showMedamaCategory { get; set; }
        public int? topPageNotePosition { get; set; }
        public int? showTopPageNote { get; set; }
        public string topPageNote { get; set; }
        public int? itemSearchPosition { get; set; }
        public int? showItemSearch { get; set; }
        public int? categoryListPosition { get; set; }
        public int? topPageNote2Position { get; set; }
        public int? showTopPageNote2 { get; set; }
        public string topPageNote2 { get; set; }
    }
    public class SpTopPageToGet : SpTopPage
    {
        public SpBigBannerList spBigBannerList { get; set; }
        public SpSmallBannerList spSmallBannerList { get; set; }
        public SpMedamaItem spMedamaItem { get; set; }
        public SpMedamaCategory spMedamaCategory { get; set; }
    }
    public class SpBigBannerList
    {
        public SpBigBanner spBigBanner { get; set; }
    }
    public class SpBigBanner
    {
        public int bigBannerPosition { get; set; }
        public string bigBannerImageUrl { get; set; }
        public string bigBannerAltMessage { get; set; }
        public string bigBannerLinkUrl { get; set; }
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
    }
    public class SpSmallBannerList
    {
        public SpSmallBanner spSmallBanner { get; set; }
    }
    public class SpSmallBanner
    {
        public int smallBannerPosition { get; set; }
        public string smallBannerImageUrl { get; set; }
        public string smallBannerAltMessage { get; set; }
        public string smallBannerLinkUrl { get; set; }
    }
    public class SpMedamaItem
    {
        public SpMedamaItemSettings spMedamaItemSettings { get; set; }
        public MedamaItems medamaItems { get; set; }
    }
    public class SpMedamaItemSettings
    {
        public int showMedamaItemName { get; set; }
        public int showMedamaItemPrice { get; set; }
    }
    public class MedamaItems
    {
        public MedamaItem medamaItem { get; set; }
    }
    public class MedamaItem
    {
        public int medamaItemPosition { get; set; }
        public int medamaItemManagementNumber { get; set; }
    }
    public class SpMedamaCategory
    {
        public SpMedamaCategoryCommon spMedamaCategoryCommon { get; set; }
        public SpMedamaCategoryList spMedamaCategoryList { get; set; }
    }
    public class SpMedamaCategoryCommon
    {
        public int showCategoryName { get; set; }
    }
    public class SpMedamaCategoryList
    {
        public SpMedamaCategory2 spMedamaCategory { get; set; }
    }
    public class SpMedamaCategory2
    {
        public int spMedamaCategoryPosition { get; set; }
        public int spMedamaCategoryId { get; set; }
        public string spMedamaCategoryImageUrl { get; set; }

    }
}
