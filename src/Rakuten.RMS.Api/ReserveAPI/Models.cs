using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rakuten.RMS.Api.ReserveAPI
{
    public class InfoListRequest
    {
        /// <summary>
        /// 期間指定種類 
        /// 1：申込日
        /// 2：お届け予定日
        /// 3：注文確定日
        /// </summary>
        public int dateType { get; set; }
        /// <summary>
        /// 商品種別
        /// 1：定期購入
        /// 2：頒布会
        /// 3：予約
        /// </summary>
        public IList<int> reserveType { get; set; }

        /// <summary>
        /// 検索方法
        /// 1: 商品管理番号で検索
        /// こちらを指定した場合、「商品管理番号」が必須
        /// </summary>
        public int? keywordType { get; set; }

        /// <summary>
        /// 商品管理番号
        /// </summary>
        public string keyword { get; set; }
        /// <summary>
        /// 開始日
        /// 最大検索期間：前年の本日より来年本日の前日までの2年間
        /// </summary>
        public DateTime? startDate { get; set; }
        /// <summary>
        /// 終了日 
        /// </summary>
        public DateTime? endDate { get; set; }
        /// <summary>
        /// 申込ステータス名
        /// 各店舗で利用している申込ステータスを参照し、完全一致の名称を指定
        /// </summary>
        public string reserveStatusName { get; set; }
        /// <summary>
        /// 利用端末
        /// 1 : PC
        /// 2 : モバイル
        /// 3 : スマートフォン
        /// 4 : タブレット
        /// </summary>
        public IList<int> deviceCode { get; set; }

        /// <summary>
        /// 支払方法    
        /// 各店舗で利用している決済方法を参照し、完全一致の名称を指定
        /// </summary>
        public string settlementName { get; set; }
        /// <summary>
        /// 配送方法 
        /// 基本情報設定の配送方法・送料設定ページにある「配送方法」と「配送キャリア」を完全一致で指定
        /// </summary>
        public string deliveryName { get; set; }
        /// <summary>
        /// 申込履歴修正有無フラグ
        /// 0：申込履歴からの修正なし
        /// 1：申込履歴からの修正あり
        /// </summary>
        public int? modifyFlag { get; set; }
        /// <summary>
        /// 取得件数
        /// 指定なしの場合先頭100件のみ取得対象となります。値の範囲: 1 - 1000
        /// </summary>
        public int? limit { get; set; }
        /// <summary>
        /// 取得位置
        /// 例：1000件データのうちの501件目～700件目の200件のみ取得したい場合、limit=200&amp;offset=500で設定します。
        /// </summary>
        public int? offset { get; set; }
    }
}
