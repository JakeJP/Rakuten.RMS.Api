using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rakuten.RMS.Api.JSON;

namespace Rakuten.RMS.Api.NavigationAPI20
{
    public class VersionResult : ResultBase
    {
        public Version version { get; set; }
    }
    public class Version
    {
        public int id { get; set; }
        public DateTime fixedAt { get; set; }
    }
    public class Genre : BaseGenre
    {

        public List<BaseGenre> ancestors { get; set; }
        public List<BaseGenre> siblings { get; set; }
        public List<BaseGenre> children { get; set; }
    }
    public class BaseGenre
    {
        public long genreId { get; set; }
        public List<long> genreIdPath { get; set; }
        public string nameJa { get; set; }
        public List<string> nameJaPath { get; set; }

        public int level { get; set; }
        public bool lowest { get; set; }
        public Property properties { get; set; }
    }
    public class GenreWithAttributes : Genre
    {
        public List<Attribute> attributes { get; set; }
    }
    public class GenreWithAttributesAndDictionary : Genre
    {
        public List<AttributeWithDictionaryValues> attributes { get; set; }
    }
    public class Property
    {
        public bool itemRegisterFlg { get; set; }
    }
    public class GenreResult : ResultBase
    {
        public Version version { get; set; }
        public Genre genre { get; set; }
    }
    public class AttributeResult : ResultBase
    {
        public Version version { get; set; }
        public GenreWithAttributes genre { get; set; }
    }
    public class AttributeWithDictionaryResult : ResultBase
    {
        public Version version { get; set; }
        public GenreWithAttributesAndDictionary genre { get; set; }
    }
    public class Attribute
    {
        public long id { get; set; }
        public string nameJa { get; set; }
        public string dataType { get; set; }
        public int? minLength { get; set; }
        public int? maxLength { get; set; }
        public float? minValue { get; set; }
        public float? maxValue { get; set; }
        public string dateFormat { get; set; }
        public string unit { get; set; }
        public List<string> subUnits { get; set; }
        public AttributeProperty properties { get; set; }
    }
    public class AttributeWithDictionaryValues : Attribute
    {
        public List<DictionaryValue> dictionaryValues { get; set; }
    }
    public class DictionaryValue
    {
        public long id { get; set; }
        public string nameJa { get; set; }
    }
    public class AttributeProperty
    {
        public bool rmsMandatoryFlg { get; set; }
        public int rmsMultiValueLimit { get; set; }
        public string rmsInputMethod { get; set; }
        public bool rmsSkuUnifyFlg { get; set; }
        public bool rmsRecommend { get; set; }
    }
}
