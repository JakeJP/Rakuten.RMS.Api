using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.ShopAPI
{
    [XmlType(TypeName = "shopLayoutCommonBizModel", Namespace = ShopAPI.ModelNamespace)]

    public class ShopLayoutCommonBizModel
    {
        [XmlArrayItem("shopLayoutCommon")]
        public List<ShopLayoutCommon> shopLayoutCommonList { get; set; }
    }
    public class ShopLayoutCommon
    {
        public long? layoutCommonId { get; set; }
        public int? defaultFlag { get; set; }
        public string name { get; set; }
        public DateTime? lastUpdate { get; set; }
        public string captionHeader { get; set; }
        public string captionFooter { get; set; }
        public string captionLeft { get; set; }
    }

    [XmlType(TypeName = "shopLayoutCommonBizModel", Namespace = ShopAPI.ModelNamespace)]
    public class shopLayoutCommonBizModelRequest
    {
        public List<ShopLayoutCommon> insertList { get; set; }
        public List<ShopLayoutCommon> updateList { get;set; }

    }

    public class ShopLayoutCommonResultMessage : XML.ResultMessage
    {
        public string resourceId { get; set; }
        public string fieldId { get;set; }
        public string validationErrorCode { get; set; }
        public string minValue { get; set; }
        public string maxValue { get; set; }
    }
}
