using Rakuten.RMS.Api.XML;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.ItemAPI
{
    public class ItemAPI : RakutenApiXmlClientBase
    {
        public ItemAPI(ServiceProvider provider) : base(provider)
        {

        }
        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/item/get", EndpointHttpMethod.GET)]
        public GetResponse Get(string itemUrl)
        {
            return Get<GetResponse>(new System.Collections.Specialized.NameValueCollection
            {
                {"itemUrl", itemUrl }
            });
        }
        [XmlRoot("result")]
        public class GetResponse : ResultBase
        {
            [XmlElement("itemGetResult")]
            public itemGetResult Result { get; set; }
            public class itemGetResult
            {
                [XmlElement("code")]
                public string Code { get; set; }
                [XmlElement("item")]
                public ItemModelToGet Item { get; set; }
            }
        }
        [XmlRoot("request")]
        public class InsertRequest
        {

        }
        [XmlRoot("result")]
        public class InsertResponse
        {

        }
        [XmlRoot("request")]
        public class UpdateRequest
        {

        }
        [XmlRoot("result")]
        public class UpdateResponse
        {

        }

        public void UpdateItems(IEnumerable<ItemModelToUpdate> items)
        {
        }
        [XmlRoot("request")]
        public class UpdateItemsRequest
        {
            public class itemsUpdateRequest
            {
                [XmlArray("items")]
                [XmlArrayItem("item")]
                public ItemModelToUpdateItems[] Items { get; set; }
            }
        }
    }

}
