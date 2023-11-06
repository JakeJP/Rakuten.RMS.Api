using Rakuten.RMS.Api.XML;
using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Rakuten.RMS.Api.ProductAPI
{
    public class ProductAPI : RakutenApiXmlClientBase
    {
        internal ProductAPI(ServiceProvider provider) : base(provider)
        {

        }
        public IEnumerable<SearchResponse.Product> SearchAll(SearchCondition condition)
        {
            while (true)
            {
                var result = Search(condition);
                if (result?.Status?.SystemStatus != SystemStatus.OK )
                    throw new XmlStatusException(result.Status);

                foreach( var r in result.productSearchResult.Products )
                    yield return r;
                if (result.productSearchResult.Pagination.numFound <= result.productSearchResult.Pagination.offset +
                    result.productSearchResult.Products.Count)
                    break;
                condition.offset = (condition.offset ?? 0) + (condition.limit ?? 30);
                condition.limit = (condition.limit ?? 30);
            }
        }

        /// <summary>
        /// keyword だけで検索する簡易版
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public IEnumerable<SearchResponse.Product> SearchAll(string keyword)
            => SearchAll(new SearchCondition { keyword = keyword });

        /// <summary>
        /// APIへの直接呼出し
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/2.0/product/search", EndpointHttpMethod.GET)]
        public SearchResponse Search(SearchCondition condition)
            => Get<SearchResponse>(condition.ToNameValueCollection());
    }
}
