using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.ShopAPI
{
    [XmlType("spItemPageBizModel", Namespace = ShopAPI.ModelNamespace)]
    public class SpItemPageBizModel
    {
        [XmlElement(Namespace = "")]
        public SpItemPageModel updateModel { get; set; }
    }
    public class SpItemPageModel
    {
        /// <summary>
        /// 大バナー表示
        /// </summary>
        public int showBigBanner { get; set; }
        /// <summary>
        /// 大バナーのデザイン
        /// </summary>
        public int bigBannerUseList { get; set; }
        /// <summary>
        /// 小バナー表示
        /// </summary>
        public int showSmallBanner { get; set; }
        /// <summary>
        /// 小バナーのデザイン
        /// </summary>
        public int smallBannerUseFlick { get; set; }
        public int showMedamaItem { get; set; }
        public int showMedamaCategory { get; set; }
        public int showShopCalendar { get; set; }
        public int showItemCommonNote { get; set; }
        public int itemCommonNote { get; set; }
    }
}
