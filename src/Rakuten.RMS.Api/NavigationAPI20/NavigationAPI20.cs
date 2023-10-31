using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Rakuten.RMS.Api.JSON;

namespace Rakuten.RMS.Api.NavigationAPI20
{
    /// <summary>
    /// ジャンル・商品属性情報検索API（NavigationAPI 2.0）
    /// </summary>
    public class NavigationAPI20 : RakutenApiJsonClientBase
    {
        internal NavigationAPI20( ServiceProvider serviceProvider ) : base(serviceProvider ) { }
        public Version GetVersion()
            => GetRequest<VersionResult>($"https://api.rms.rakuten.co.jp/es/2.0/navigation/version")?.version;
        public GenreResult GetGenres(long genreId, bool? showAncestors = null, bool? showSiblings = null, bool? showChildren = null )
        {
            var url = $"https://api.rms.rakuten.co.jp/es/2.0/navigation/genres/{genreId}";
            var qs = new NameValueCollection();
            if( showAncestors != null ) qs["showAncestors"] = showAncestors.ToString().ToLower();
            if (showSiblings != null) qs["showSiblings"] = showSiblings.ToString().ToLower();
            if (showChildren != null) qs["showChildren"] = showChildren.ToString().ToLower();
            return GetRequest<GenreResult>(url, queryParameters: qs);
        }
        public AttributeResult GetGenreAttributes( long genreId, long? attributeId, bool? showAncestors = null, bool? showSiblings = null, bool? showChildren = null)
        {
            var url = $"https://api.rms.rakuten.co.jp/es/2.0/navigation/genres/{genreId}/attributes/{attributeId}";

            var qs = new NameValueCollection();
            if (showAncestors != null) qs["showAncestors"] = showAncestors.ToString().ToLower();
            if (showSiblings != null) qs["showSiblings"] = showSiblings.ToString().ToLower();
            if (showChildren != null) qs["showChildren"] = showChildren.ToString().ToLower();
            return GetRequest<AttributeResult>(url, queryParameters: qs);
        }
        public AttributeWithDictionaryResult GetAttributesDictionaryValues(long genreId, long attributeId, bool? showAncestors = null, bool? showSiblings = null, bool? showChildren = null, int? page = null, int? limit = null)
        {
            var url = $"https://api.rms.rakuten.co.jp/es/2.0/navigation/genres/{genreId}/attributes/{attributeId}/dictionaryValues";

            var qs = new NameValueCollection();
            if (showAncestors != null) qs["showAncestors"] = showAncestors.ToString().ToLower();
            if (showSiblings != null) qs["showSiblings"] = showSiblings.ToString().ToLower();
            if (showChildren != null) qs["showChildren"] = showChildren.ToString().ToLower();
            if (page != null) qs["page"] = page.ToString().ToLower();
            if (limit != null) qs["limit"] = limit.ToString().ToLower();
            return GetRequest<AttributeWithDictionaryResult>(url, queryParameters: qs);

        }
    }

}
