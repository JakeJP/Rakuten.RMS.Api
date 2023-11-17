using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static Rakuten.RMS.Api.ItemAPI20.ItemCommon;

namespace Rakuten.RMS.Api.ShopAPI
{
    [XmlType(TypeName = "naviButtonInfoBizModel", Namespace = ShopAPI.ModelNamespace)]
    public class NaviButtonInfoBizModel
    {
        [XmlArray("naviButtonInfoList", Namespace = "")]
        [XmlArrayItem("naviButtonInfo", Namespace ="")]
        public List<NaviButtonInfo> naviButtonInfoList { get;set;}
    }
    public class NaviButtonInfo
    {
        public long naviId { get; set; }
        public int buttonOrder { get; set; }
        public int imgType { get; set; }
        public string imgPath { get; set; }
        public string buttonText { get; set; }
        public int buttonTextFont { get; set; }
        public long buttonTextSize { get; set; }
        public long marginWidth { get; set; }
        /// <summary>
        ///  枠線から文字までの間隔(縦）
        /// </summary>
        public long marginHeight { get; set; }
        /// <summary>
        ///  形状  Short   5	No  1: 平面
        /// </summary>
        public int outsideFrame { get; set; }
        /// <summary>
        ///  背景色 String  6	No
        /// </summary>
        public string buttonBgcolor { get; set; }
        /// <summary>
        ///  文字色 String  6	No
        /// </summary>
        public string textColor { get; set; }
        /// <summary>
        ///  リンク先ページ Short   5	Yes 1: 買い物かご
        ///  2: 会社概要
        ///  3: 決済・配送・返品
        ///  6: R-Mail購読申込み
        ///  7: 商品検索
        ///  9: 楽天市場
        ///  10: その他のリンク先
        ///  12: カテゴリトップ
        ///  13: 店舗トップ
        /// </summary>
        public int href { get; set; }
        /// <summary>
        ///    「その他のリンク先」の場合のURL String	255	No
        /// </summary>
        public string href2 { get; set; }
    }
    [XmlType(TypeName = "naviButtonInfoBizModel", Namespace = ShopAPI.ModelNamespace)]
    public class NaviButtonInfoBizModelRequest
    {
        public List<NaviButtonInfo> insertList { get; set; }
        public List<NaviButtonInfo> updateList { get; set; }
        public List<NaviButtonInfo> deleteList { get; set; }

    }
}
