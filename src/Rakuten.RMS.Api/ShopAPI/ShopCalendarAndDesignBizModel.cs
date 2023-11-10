using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.ShopAPI
{
    [XmlType("shopCalendarAndDesignBizModel", Namespace = ShopAPI.ModelNamespace)]
    public class ShopCalendarAndDesignBizModel
    {
        public ShopCalendar shopCalendar { get; set; }
        public ShopCalendarDesign shopCalendarDesign { get; set; }
    }
    public class ShopCalendar
    {
        /// <summary>
        /// 休業日設定
        /// </summary>
        public CalendarFunction businessHoliday { get; set; }
        /// <summary>
        /// 受注・お問い合わせ業務のみ設定
        /// </summary>
        public CalendarFunction shippingHoliday { get; set; }
        /// <summary>
        /// 発送業務のみ設定
        /// </summary>
        public CalendarFunction shippingOnly { get; set; }
    }
    public class CalendarFunction
    {
        public RegularScheduleModel replaceModel { get; set; }
        public EventDatesModel insertModel {  get; set; }
        public EventDatesModel deleteModel { get; set; } 
    }
    public class RegularScheduleModel
    {
        /// <summary>
        /// SUNDAY：日曜日
        /// MONDAY：月曜日
        /// TUESDAY：火曜日
        /// WEDNESDAY：水曜日
        /// THURSDAY：木曜日
        /// FRIDAY：金曜日
        /// SATURDAY：土曜日
        /// HOLIDAY：祝日
        /// </summary>
        [XmlArrayItem("weekday")]
        public List<string> regularSchedule { get; set; }
    }
    public class EventDatesModel
    {
        /// <summary>
        /// 個別の日付一覧 YYYYMMDD
        /// </summary>
        [XmlArrayItem("eventDate")]
        public List<string> eventDates { get; set; }
    }
    public class ShopCalendarDesign
    {
        public InputModel inputModel { get; set; }
        public class InputModel
        {
            public ShopCalDesign shopCalDesign { get; set; }
            public ShopCalDesignEvents shopCalDesignEvents { get; set;}
        }
    }
    public class ShopCalDesign
    {
        public int cellWidth { get; set; } // カレンダー１日分のセル幅    Integer	10	Yes 許容範囲：1～26
        public int cellHeight { get; set; } // カレンダー１日分のセル高    Integer	10	Yes 許容範囲：1～26
        public int fontSize { get; set; } // カレンダー文字サイズ  Integer	10	Yes	1
        public string fontColor { get; set; } // カレンダー文字色    String	6	Yes	000000〜FFFFFF
        public string dayOfWeekColor { get; set; } // カレンダーヘッダー背景色    String	6	Yes	000000〜FFFFFF
        public string bgColor { get; set; } // カレンダー背景色(外側)    String	6	Yes	000000〜FFFFFF
        public string frameColor { get; set; } // 枠色  String	6	Yes	000000〜FFFFFF
        public string weekdayColor { get; set; } // カレンダー背景色(内側)    String	6	Yes	000000〜FFFFFF
        public string satColor { get; set; } // 土曜日 文字色 String	6	Yes	000000〜FFFFFF
        public string sunColor { get; set; } // 日曜日 文字色 String	6	Yes	000000〜FFFFFF
        public string holidayColor { get; set; } // 祝日 文字色 String	6	Yes	000000〜FFFFFF
        public string nonHolidayFlag { get; set; } // 年中無休フラグ Short	7	Yes	0：休業日を設定する1：年中無休にする(本日以降の全ての休業日設定を削除します)
        public string calendarText { get; set; } // カレンダー説明文    String	255	No
    }
    public class ShopCalDesignEvents
    {
        public ShopCalDesignEvent shopCalDesignEvent { get; set; }

    }
    public class ShopCalDesignEvent
    {
        /// <summary>
        /// 1：休業日 2：受注・お問い合わせ業務のみ 3：発送業務のみ
        /// </summary>
        public int eventType { get; set; }
        /// <summary>
        /// 000000〜FFFFFF
        /// </summary>
        public string eventColor { get; set; }
    }
}
