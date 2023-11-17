using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.ShopAPI
{
    [XmlType("shopHolidayBizModel", Namespace = ShopAPI.ModelNamespace)]
    public class ShopHolidayBizModel
    {
        [XmlElement(Namespace = "")]
        public InputModel inputModel { get; set; }
        public class InputModel
        {
            public ShopHolidayWeb shopHolidayWeb { get; set; }
            public ShopHolidayMail shopHolidayMail { get; set; }
        }
        public class ShopHolidayWeb
        {
            public string title { get; set; }
            public string message { get; set; }
            public string stimeStampYmd { get; set; }
            public string etimeStampYmd { get; set; }
        }
        public class ShopHolidayMail
        {
            public string message { get; set; }
            public string stimeStampYmd { get; set; }
            public string etimeStampYmd { get; set; }
        }
    }
}
