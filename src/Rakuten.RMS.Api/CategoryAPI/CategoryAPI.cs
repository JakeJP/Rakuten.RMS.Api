using Rakuten.RMS.Api.XML;
using System.Xml;
using System.Xml.Serialization;
namespace Rakuten.RMS.Api.CategoryAPI
{
    /// <summary>
    /// カテゴリAPI 2.0（CategoryAPI 2.0）
    /// </summary>
    public class CategoryAPI : RakutenApiXmlClientBase
    {
        internal CategoryAPI(ServiceProvider provider) : base(provider)
        {
        }
        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/categoryapi/shop/categorysets/get", EndpointHttpMethod.GET)]
        public GetCategorysetsResponse GetCategorySets()
        {
            return Get<GetCategorysetsResponse>();
        }
        [XmlRoot("result")]
        public class GetCategorysetsResponse : ResultBase
        {
            [XmlElement("categorysetsGetResult")]
            public categorysetsGetResult Result { get; set; }

            public class categorysetsGetResult
            {
                [XmlElement("code")]
                public string Code { get; set; }
                [XmlElement("shipId")]
                public string ShopId { get; set; }
                [XmlArray("categorySetList")]
                [XmlArrayItem("categorySet")]
                public categorySet[] List { get; set; }
            }

            public class categorySet
            {
                [XmlElement("categorySetManageNumber")]
                public string CategorySetManageNumber { get; set; }
                [XmlElement("categorySetId")]
                public int CategorySetId { get; set; }
                [XmlElement("categorySetName")]
                public string CategorySetName { get; set; }
                [XmlElement("categorySetStatus")]
                public int CategorySetStatus { get; set; }
                [XmlElement("categorySetOrder")]
                public int CategorySetOrder { get; set; }
            }
        }
    }
}
