using System.Xml.Serialization;

namespace Rakuten.RMS.Api.ShopAPI
{


    [XmlType(TypeName = "topDisplayBizModel", Namespace = ShopAPI.ModelNamespace)]
    public class TopDisplayBizModel
    {
        [XmlElement(Namespace = "")]
        public TopDisplay topDisplay { get; set; }
    }
    public class TopDisplay
    {
        public int? layoutCommonId { get; set; }
        public int? textSmallId { get; set; }
        public int? lossLeaderId { get; set; }
        public int? lossLeadingCategoryId { get; set; }
        public int? textLargeId { get; set; }
        public string imageUrl { get; set; }
        public string imageAlt { get; set; }
        public string upperText { get; set; }
        public string lowerText { get; set; }
    }

    [XmlRoot("topDisplayBizModel", Namespace = ShopAPI.ModelNamespace)]
    public class TopDisplayBizModelRequest
    {
        [XmlElement("updateModel", Namespace = "")]
        public TopDisplay updateModel { get; set; }
    }
}
