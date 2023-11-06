using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Rakuten.RMS.Api.XML;

namespace Rakuten.RMS.Api.ProductAPI
{
    [DecodableObject]
    public class SearchCondition
    {
        public string productId { get; set; }
        public string keyword { get; set; }
        public string genreId { get; set; }
        public string makerName { get; set; }
        public DateTime? releaseDateFrom { get; set; }
        public DateTime? releaseDataTo { get; set; }
        public string sortBy { get; set; }
        /// <summary>
        /// 0を基準値とした検索結果取得開始位置
        ///         例：11件目から25件目の情報を取得する場合は、offset=10、limit=15
        ///         null の場合はデフォルト値で検索されます。 
        /// </summary>
        public int? offset { get; set; }
        /// <summary>
        /// 検索結果の取得上限数
        ///         例：11件目から25件目の情報を取得する場合は、offset=10、limit=15
        ///         null の場合はデフォルト値で検索されます。
        ///         ※値は30まで指定可能です。
        /// </summary>
        public int? limit { get; set; }

        internal NameValueCollection ToNameValueCollection()
        {
            var nv = new NameValueCollection();
            foreach( var p in GetType().GetProperties(System.Reflection.BindingFlags.Public| System.Reflection.BindingFlags.Instance))
            {
                var v = p.GetValue(this, null);
                if ( v != null )
                {
                    if (p.PropertyType.IsGenericType && Nullable.GetUnderlyingType(p.PropertyType) == typeof(DateTime))
                    {
                        var dt = (DateTime)v;
                        var dto = new DateTimeOffset(dt, TimeZoneInfo.Local.GetUtcOffset(dt));
                        v = dto.ToString("yyyy-MM-ddTHH:mm:ssK");
                    }
                    nv.Add(p.Name, v.ToString());
                }
            }
            return nv;
        }
    }

    [XmlRoot("result")]
    public class SearchResponse : ResultBase
    {
        public ProductSearchResultContainer productSearchResult { get; set; }
        public class ProductSearchResultContainer
        {
            [XmlElement("pagination")]
            public pagination Pagination { get; set; }
            [XmlArray("products")]
            [XmlArrayItem("product")]
            public List<Product> Products { get; set; }
        }
        public class pagination
        {
            [XmlElement("numFound")]
            public int numFound { get; set; }
            [XmlElement("offset")]
            public int offset { get; set; }

        }
        public class Product
        {
            [XmlElement("productId")]
            public string productId { get; set; }
            public string productNo { get; set; }
            public int reviewCount { get; set; }
            public decimal reviewAverage { get; set; }
            public string reviewUrlPC { get; set; }
            public string reviewUrlMobile { get; set; }
            [XmlElement("rank")]
            public string rank_text { get; set; }
            public int? rank => string.IsNullOrEmpty(rank_text) ? null : (int?)int.Parse(rank_text);
            [XmlElement("rankTargetGenreId")]
            public string rankTargetGenreId_text { get; set; }
            public int? rankTargetGenreId => string.IsNullOrEmpty(rankTargetGenreId_text) ? null : (int?)int.Parse(rankTargetGenreId_text);
            [XmlElement("rankTargetProductCount")]
            public string rankTargetProductCount_text { get; set; }
            public int? rankTargetProductCount => string.IsNullOrEmpty(rankTargetProductCount_text) ? null : (int?)int.Parse(rankTargetProductCount_text);
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
