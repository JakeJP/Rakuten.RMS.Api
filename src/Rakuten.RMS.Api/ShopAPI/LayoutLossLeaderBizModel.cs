using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.ShopAPI
{
    [XmlType("layoutLossLeaderBizModel", Namespace = ShopAPI.ModelNamespace)]
    public class LayoutLossLeaderBizModel
    {
        [XmlArray(Namespace = "")]
        [XmlArrayItem("layoutLossLeader", Namespace = "")]
        public List<LayoutLossLeader> layoutLossLeaderList { get; set; }
    }
    public class LayoutLossLeader
    {
        public int lossLea { get; set; }// 目玉商品テンプレート名 String	90	No	
        public int imageSize { get; set; }// 目玉商品画像サイズ（ピクセル）	Integer	10	No	
        public int imageScaleStandard { get; set; }// 目玉商品画像サイズを設定する方向    Short	5	No	0: 自動調整 1: 高さ2: 幅
        public int dispItemFlag { get; set; }// 商品名の表示  Short	5	No	0: 非表示 1: 表示
        public int dispPriceFlag { get; set; }// 販売価格の表示 Short	5	No	0: 非表示 1: 表示
        public int textPosition { get; set; }// 目玉商品のレイアウト  Short	5	No	1: 商品名の上に画像1を配置 2: 商品名の下に画像1を配置
        public int wrapLength { get; set; }// 商品名の横幅（ピクセル）	Integer	10	No
        public int imageCols { get; set; }//	1行あたりの商品数 Short	5	No
        public int defaultFlag { get; set; }// テンプレートの自動選択 Short	5	No	0: 自動選択しない 1: 自動選択対象
        public DateTime? lastUpdate { get; set; }// 更新日時
    }
}
