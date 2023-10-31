using Rakuten.RMS.Api.XML;
using System;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.ProductAPI
{
    public class ProductAPI : RakutenApiXmlClientBase
    {
        internal ProductAPI(ServiceProvider provider) : base(provider)
        {

        }
        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/2.0/product/search", EndpointHttpMethod.GET)]
        public SearchResponse Search(string productId = null, string keyword = null, string genreId = null, string makerName = null, DateTime? releaseDateFrom = null, DateTime? releaseDataTo = null, string sortBy = null, int? offset = null, int? limit = null)
        {
            return Get<SearchResponse>(new System.Collections.Specialized.NameValueCollection
            {
                { "productId", productId },
                {"keyword", keyword },
                { "genreId", genreId},
                {"makerName", makerName },
                {"releaseDateFrom", releaseDateFrom?.ToString("G") },
                {"releaseDateTo", releaseDataTo?.ToString("G") },
                {"sortBy",sortBy },
                {"offset",offset.ToString() },
                {"limit", limit.ToString() }
            });
        }
        [XmlRoot("result")]
        public class SearchResponse : ResultBase
        {
            public class productSearchResult
            {
                [XmlElement("pagination")]
                public pagination Pagination { get; set; }
                [XmlArray("products")]
                [XmlArrayItem("product")]
                public product[] Products { get; set; }
            }
            public class pagination
            {
                [XmlElement("numFound")]
                public int numFound { get; set; }
                [XmlElement("offset")]
                public int offset { get; set; }

            }
            public class product
            {
                [XmlElement("productId")]
                public string productId { get; set; }
                public string productNo { get; set; }
                public int reviewCount { get; set; }
                public decimal reviewAverage { get; set; }
                public string reviewUrlPC { get; set; }
                public string reviewUrlMobile { get; set; }
                public int rank { get; set; }
                public int rankTargetGenreId { get; set; }
                public int rankTargetProductCount { get; set; }
                public string genreId { get; set; }
                public string genreName { get; set; }
                public string productName { get; set; }
                public string releaseDateDisp { get; set; }
                public string detailInfo { get; set; }
                public string brandName { get; set; }
                public string standardPrice { get; set; }
                [XmlIgnore]
                public bool isOpenPrice { get; set; }
                [XmlElement("isOpenPrice")]
                public int isOpenPriceRaw { get; set; }
                public int taxCategory { get; set; }
                [XmlIgnore]
                public DateTime releaseDate => DateTime.Parse(releaseDateRaw);
                [XmlElement("releaseDate")]
                public string releaseDateRaw { get; set; }
                public string makerName { get; set; }
                [XmlIgnore]
                public DateTime updateDate => DateTime.Parse(updateDateRaw);
                [XmlElement("updateDate")]
                public string updateDateRaw { get; set; }
            }


        }
    }
}
