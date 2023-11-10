using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.ShopAPI
{
    [XmlType("shopCalendarBizModel", Namespace = ShopAPI.ModelNamespace)]
    public class ShopCalendarBizModel
    {
        public ShopCalendar2 shopCalendar { get; set; }
    }
    public class ShopCalendar2
    {
        public CalendarEvent businessHoliday { get; set; }
        public CalendarEvent shippingHoliday { get; set; }
        public CalendarEvent shippingOnly { get; set; }
        public ShopHoliday shopHoliday { get; set; }
    }
    public class CalendarEvent
    {
        [XmlArrayItem("weekday")]
        public List<string> regularSchedule { get; set; }
        [XmlArrayItem("eventDate")]
        public List<string> eventDates { get; set; }
    }
    public class ShopHoliday
    {
        public string title { get; set; }// Web告知用タイトル  String	382	No
        public DateTime? stimestampYmd { get; set; }// Web告知用表示期間From  Date	-	No yyyy-mm-dd
        public DateTime? etimestampYmd { get; set; }// Web告知用表示期間To    Date	-	No yyyy-mm-dd
        public string mailMessage { get; set; }// メール告知用メッセージ String	3072	No
        public DateTime? stimestampMailYmd { get; set; }// メール告知用表示期間From  Date	-	No yyyy-mm-dd
        public DateTime? etimestampMailYmd { get; set; }// メール告知用表示期間To    Date	-	No yyyy-mm-dd
        public string message { get; set; }//Web告知用メッセージ
    }
}
