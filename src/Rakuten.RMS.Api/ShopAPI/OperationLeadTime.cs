using System.Collections.Generic;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.ShopAPI
{
    [XmlType(TypeName = "operationLeadTimeBizModel", Namespace = ShopAPI.ModelNamespace)]
    public class OperationLeadTimeBizModel
    {
        [XmlArray("operationLeadTimeList", Namespace = "")]
        [XmlArrayItem("operationLeadTime", Namespace = "")]
        public List<OperationLeadTime> operationLeadTimeList { get; set; }
    }
    public class OperationLeadTime
    {
        public string operationLeadTimeId { get; set; }
        public string name { get; set; }
        public int numberOfDays { get; set; }
        public int inStockDefaultFlag { get; set; }
        public int outOfStockDefaultFlag { get; set; }
    }
}
