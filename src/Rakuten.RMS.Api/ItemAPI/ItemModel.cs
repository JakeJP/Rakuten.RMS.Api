using System;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.ItemAPI
{
    public class ItemModelToUpdate : ItemModelBase
    {
        public string descriptionForMobile { get; set; }
        public bool isAvailableForMobile { get; set; }
    }
    public class ItemModelToInsert : ItemModelBase
    {

    }
    public class ItemModelToGet : ItemModelBase
    {

    }
    public class ItemModelToUpdateItems : ItemModelSimpleBase
    {
        public bool isAvailableForMobile { get; set; }

    }
    public abstract class ItemModelSimpleBase
    {
        [XmlElement("itemUrl")]
        public string itemUrl { get; set; }
        [XmlElement("itemNumber")]
        public string itemNumber { get; set; }
        [XmlElement("itemName")]
        public string itemName { get; set; }
        public int itemPrice { get; set; }
        public int genreId { get; set; }
        public string catalogId { get; set; }
        public int catalogIdExemptionReason { get; set; }
        public string whiteBgImageUrl { get; set; }
        //
        //
        public string catchCopyForPC { get; set; }
        public string catchCopyForMobile { get; set; }
        //
        //
        public bool displayMakerContents { get; set; }

        //
        //
        public bool isIncludedTax { get; set; }
        public bool isIncludedPostage { get; set; }
        //
        //
        public int displayPrice { get; set; }

        //
        //
        public bool isDepot { get; set; }
        //
        public int deliverySetId { get; set; }
        //
        //
        [XmlArray("categories")]
        [XmlArrayItem("categoryInfo")]
        public ItemModelBase.categoryInfo[] Categories { get; set; }

        public int itemWeight { get; set; }
        public int layoutCommonId { get; set; }
        public int layoutMapId { get; set; }
        public int textSmallId { get; set; }
        public int lossLeaderId { get; set; }
        public int textLargeId { get; set; }
        public int shopAreaSoryoPatternId { get; set; }
        public double taxRate { get; set; }
        public bool isSingleItemShipping { get; set; }
        public int singleItemShippingReason { get; set; }






    }
    public abstract class ItemModelBase : ItemModelSimpleBase
    {

        [XmlArray("images")]
        [XmlArrayItem("image")]
        public itemGetResultItemImage[] Images { get; set; }
        public string descriptionForPC { get; set; }
        public string descriptionForSmartPhone { get; set; }
        public string movieUrl { get; set; }
        [XmlArray("options")]
        [XmlArrayItem("option")]
        public itemGetResultItemOption[] Options { get; set; }
        [XmlArray("tagIds")]
        [XmlArrayItem("tagId")]
        public string[] TagIds { get; set; }

        public string descriptionBySalesMethod { get; set; }
        public bool isSaleButton { get; set; }
        public bool isDocumentButton { get; set; }
        public bool isInquiryButton { get; set; }
        public bool isStockNoticeButton { get; set; }
        public int itemLayout { get; set; }

        public bool isIncludedCashOnDeliveryPostage { get; set; }
        public int orderLimit { get; set; }
        public int postage { get; set; }
        public int postageSegment1 { get; set; }
        public int postageSegment2 { get; set; }
        public bool isNoshiEnable { get; set; }
        public bool isTimeSale { get; set; }
        public DateTime? timeSaleStartDateTime { get; set; }
        public DateTime? timeSaleEndDateTime { get; set; }
        public bool isUnavailableForSearch { get; set; }
        public string limitedPasswd { get; set; }
        public int detailSellType { get; set; }
        public DateTime? releaseDate { get; set; }
        [XmlElement("point")]
        public point Point { get; set; }
        public string asurakuDeliveryId { get; set; }
        public string sizeChartLinkCode { get; set; }
        public int reviewDisp { get; set; }
        [XmlElement("medicine")]
        public medicine Medicine { get; set; }




        public class itemGetResultItemOption
        {
            public string optionName { get; set; }
            public int optionStyle { get; set; }
            [XmlIgnore]
            public bool isOptionRequired => isOptionRequiredRaw != 0;
            [XmlElement("isOptionRequired")]
            public int isOptionRequiredRaw { get; set; }
            [XmlArray("optionValues")]
            [XmlArrayItem("optionValue")]
            public itemGetResultItemOptionValue[] OptionValues { get; set; }


        }
        public class itemGetResultItemOptionValue
        {
            public string value { get; set; }
        }
        public class point
        {
            public int pointRate { get; set; }
            public DateTime pointRateStart { get; set; }
            public DateTime pointRateEnd { get; set; }
        }
        public class itemInventory
        {
            public int inventoryType { get; set; }
        }
        public class inventory
        {
            public int inventoryCount { get; set; }
            public string childNoVertical { get; set; }
            public string childNoHorizontal { get; set; }
            public string optionNameVertical { get; set; }
            public string optionNameHorizontal { get; set; }
            public bool isBackorderAvailable { get; set; }
            public string normalDeliveryDateId { get; set; }
            public string backorderDeliveryDateId { get; set; }
            public bool isBackorder { get; set; }
            public bool isRestoreInventoryFlag { get; set; }
            [XmlArray("images")]
            [XmlArrayItem("image")]
            public inventoryImage[] Images { get; set; }
            [XmlArray("tagIds")]
            [XmlArrayItem("tagId")]
            public string[] TagIds { get; set; }
            public string verticalName { get; set; }
            public string horizontalName { get; set; }
            public int inventoryQuantityFlag { get; set; }
            public int inventoryDisplayFlag { get; set; }



        }
        public class medicine
        {
            public string medCaption { get; set; }
            public string medAttention { get; set; }
        }
        public class categoryInfo
        {
            public string categorySetManageNumber { get; set; }
            public int categoryId { get; set; }
            public bool isPluralItemPage { get; set; }
        }
        public class inventoryImage
        {
            public string imageUrl { get; set; }
        }
        public class itemGetResultItemImage
        {
            public string imageUrl { get; set; }
            public string imageAlt { get; set; }
        }
    }
}
