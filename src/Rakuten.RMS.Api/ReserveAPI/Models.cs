using System;
using System.Collections.Generic;


namespace Rakuten.RMS.Api.ReserveAPI
{
    [DecodableObject]
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

    public class InfoListResponse
    {
        /// <summary>
        /// 処理結果
        /// </summary>
        public int resultCodeInt { get; set; }
        /// <summary>
        /// 処理結果コード N00-000
        /// </summary>
        public string resultCode { get; set; }
        /// <summary>
        /// 処理結果メッセージ  
        /// </summary>
        public string resultMessage { get; set; }
        /// <summary>
        /// レスポンス日時
        /// </summary>
        public DateTime responseDatetime { get; set; }
        /// <summary>
        /// 検索条件に一致したデータの総数 
        /// </summary>
        public int totalCount { get; set; }
        /// <summary>
        ///  limit の設定により、実際に取得したデータの件数
        ///  値の範囲: 1 - 1000
        /// </summary>
        public int resultCount { get; set; }
        /// <summary>
        /// 取得件数
        /// リクエストの値が設定されます。
        /// </summary>
        public int limit { get; set; }
        /// <summary>
        /// 取得位置
        /// </summary>
        public int offset { get; set; }
        /// <summary>
        /// 申込情報リスト 
        /// </summary>
        public List<ReserveModel> publicReserveModelList { get; set; }

        public class ReserveModel
        {
            /// <summary>
            /// 店舗ID
            /// </summary>
            public long shopId { get; set; }
            /// <summary>
            /// 申込番号
            /// </summary>
            public string reserveNumber { get; set; }
            /// <summary>
            /// 申込ステータス
            ///  1 : 申込中
            ///  101～ : 店舗のオリジナルステータス
            ///  ※店舗は10個までオリジナルステータスを持つことができます。
            /// </summary>
            public int reserveStatus { get; set; }
            /// <summary>
            /// 申込ステータス名
            /// </summary>
            public string reserveStatusName { get; set; }
            /// <summary>
            /// 申込種別
            /// 1：定期購入
            /// 2：頒布会
            /// 3：予約
            /// </summary>
            public int reserveType { get; set; }
            /// <summary>
            /// お届けサイクル
            /// </summary>
            public string shippingCycle { get; set; }
            /// <summary>
            /// 楽天会員フラグ
            /// 0: 楽天会員ではない
            /// 1: 楽天会員である
            /// </summary>
            public int rakutenMemberFlag { get; set; }
            /// <summary>
            /// 申込日
            /// </summary>
            public DateTime reserveDatetime { get; set; }
            /// <summary>
            /// ひとことメモ 
            /// </summary>
            public string memo { get; set; }
            /// <summary>
            /// 利用端末
            /// 0：PC(Windows系のスマートフォン、タブレットを含む)
            /// 1：モバイル(docomo) フィーチャーフォン
            /// 2：モバイル(KDDI) フィーチャーフォン
            /// 3：モバイル(Softbank) フィーチャーフォン
            /// 5：モバイル(WILLCOM) フィーチャーフォン
            /// 11：スマートフォン（iPhone系）
            /// 12：スマートフォン（Android系）
            /// 19：スマートフォン（その他）
            /// 21：タブレット（iPad系）
            /// 22：タブレット（Android系）
            /// 29：タブレット（その他）
            /// 99：その他 不明な場合も含む
            /// </summary>
            public int carrierCode { get; set; }
            /// <summary>
            /// メールキャリアコード 
            /// 0：PC("@i.softbank.jp"を含む)
            /// 1：DoCoMo
            /// 2：au
            /// 3：SoftBank
            /// 5：WILLCOM
            /// 99：その他
            /// </summary>
            public int emailCarrierCode { get; set; }
            /// <summary>
            /// 申込商品情報
            /// </summary>
            public ReserveItem reserveItem { get; set; }
            /// <summary>
            /// 申込者情報
            /// </summary>
            public ReserveOrderer reserveOrderer { get; set; }
            /// <summary>
            /// 送付先情報
            /// </summary>
	        public ReserveSender reserveSender { get; set; }
            /// <summary>
            /// 申込明細情報
            /// </summary>
            public List<ReserveDetails> reserveDatails { get; set; }
        }


        public class ReserveItem
        {
            /// <summary>
            /// 商品ID
            /// </summary>
            public long itemId { get; set; }
            /// <summary>
            /// 商品名
            /// </summary>
            public string itemName { get; set; }
            /// <summary>
            ///  商品番号    string no[SKU対応リリース後]
            /// </summary>
            public string itemNumber { get; set; }
            /// <summary>
            ///  商品URL   string yes		/_rakuten001/teiki_0005/
            /// </summary>
            public string url { get; set; }
            /// <summary>
            ///  価格  number yes		1000
            /// </summary>
            public int price { get; set; }
            /// <summary>
            ///  商品単価 初回 number  no		780
            /// </summary>
            public int firstPrice { get; set; }
            /// <summary>
            ///  商品単価 最終回 number  no		1500
            /// </summary>
            public int lastPrice { get; set; }
            /// <summary>
            ///  個数  number yes		1
            /// </summary>
            public int units { get; set; }
            /// <summary>
            ///  送料込別    number yes 以下のいずれか
            ///  0：送料別
            ///  1：送料込みもしくは送料無料
            /// </summary>
            public int includePostageFlag { get; set; }
            /// <summary>
            /// 税込別 number yes 以下のいずれか
            /// 0：税別
            /// 1：税込
            /// </summary>
            public int includeTaxFlag { get; set; }
            /// <summary>
            /// 税率  number yes		0.08
            /// </summary>
            public decimal taxRate { get; set; }
            /// <summary>
            /// 代引手数料込別 number yes 以下のいずれか
            /// 0：代引手数料別
            /// 1：代引手数料込み
            /// </summary>
            public int includeCodFeeFlag { get; set; }
            /// <summary>
            /// 項目・選択肢 string no  HTMLタグ除去済み。
            /// </summary>
            public string selectedChoice { get; set; }
            /// <summary>
            /// ポイント倍率  number yes ポイントレート	1
            /// </summary>
            public decimal pointRate { get; set; }
            /// <summary>
            /// ポイントタイプ number yes 以下のいずれか
            /// 0：変倍なし
            /// 1：店舗別変倍
            /// 2：商品別変倍
            /// -99：エラー時無効値
            /// </summary>
            public int pointType { get; set; }
            /// <summary>
            /// 在庫タイプ   number yes 以下のいずれか
            /// 0：在庫設定なし
            /// 1：通常在庫設定
            /// 2：項目選択肢在庫設定	1
            /// </summary>
            public int inventoryType { get; set; }
            /// <summary>
            /// 単品配送フラグ number yes 以下のいずれか
            /// 0：単品配送ではない
            /// 1：単品配送である
            /// </summary>
            public int singleItemShippingFlag { get; set; }
            /// <summary>
            /// SKU管理番号 string yes		12345678
            /// </summary>
            public string variantId { get; set; }
            /// <summary>
            /// システム連携用SKU番号    string no      BLK0100
            /// </summary>
            public string merchantDefinedSkuId { get; set; }
            /// <summary>
            /// SKU情報   string no  形式は、「バリエーション:選択肢」
            /// ※シングルSKUの場合は空白
            /// </summary>
            public string skuInfo { get; set; }
        }
        public class ReserveOrderer
        {
            /// <summary>
            /// 異なる送付先フラグ   number yes 以下のいずれか
            /// 0：注文者と同じ住所の送付先
            /// 1：注文者と異なる住所の送付先	0
            /// </summary>
            public int differentSenderAddressFlag { get; set; }
            /// <summary>
            ///  注文者郵便番号1    string yes		158
            /// </summary>
            public string zipCode1 { get; set; }
            /// <summary>
            /// 注文者郵便番号2    string yes		0094
            /// </summary>
            public string zipCode2 { get; set; }
            /// <summary>
            /// 注文者住所：都道府県 string yes     東京都
            /// </summary>
            public string prefecture { get; set; }
            /// <summary>
            /// 注文者住所：都市区 string yes     世田谷区
            /// </summary>
            public string city { get; set; }
            /// <summary>
            /// 注文者住所：町以降 string yes     玉川
            /// </summary>
            public string subAddress { get; set; }
            /// <summary>
            /// 注文者名字   string yes     楽天
            /// </summary>
            public string familyName { get; set; }
            /// <summary>
            /// 注文者名前   string yes     太郎
            /// </summary>
            public string firstName { get; set; }
            /// <summary>
            /// 注文者名字フリガナ   string yes     ラクテン
            /// </summary>
            public string familyNameKana { get; set; }
            /// <summary>
            /// 注文者名前フリガナ   string yes     タロウ
            /// </summary>
            public string firstNameKana { get; set; }
            /// <summary>
            /// 注文者電話番号1    string yes 電話番号の1,2,3の内、nullは１つまで許可	090
            /// </summary>
            public string phoneNumber1 { get; set; }
            /// <summary>
            /// 注文者電話番号2    string	1234
            /// </summary>
            public string phoneNumber2 { get; set; }
            /// <summary>
            /// 注文者電話番号3    string	5678
            /// </summary>
            public string phoneNumber3 { get; set; }
            /// <summary>
            /// メールアドレス string yes メールアドレスはマスキングされています。	815db15ff6ee7c02 @pc.fw.rakuten.ne.jp
            /// </summary>
            public string emailAddress { get; set; }
            /// <summary>
            /// 注文者性別   string yes     男
            /// </summary>
            public string sex { get; set; }
            /// <summary>
            /// 注文者誕生日  string no  以下のいずれか
            /// ・2000年1月1日生の場合、2000-01-01で表示する（yyyy-MM-dd）
            /// ・-年-月-日生の場合、nullで表示する   2000-01-01
            /// </summary>
            public string birthday { get; set; }
            /// <summary>
            /// 配送方法    string no      宅配便(ヤマト運輸)
            /// </summary>
            public string deliveryName { get; set; }
            /// <summary>
            /// コメント    string no  注文フォームカスタマイズで設定したタイトルおよび、お客様が入力した内容。
            /// 形式は「[注文フォームタイトル:] ユーザー入力内容」。
            /// </summary>
            public string comment { get; set; }
        }
        public class ReserveSender
        {
            public string familyName { get; set; }
            /// <summary>
            /// 注文者名前   string yes     太郎
            /// </summary>
            public string firstName { get; set; }
            /// <summary>
            /// 注文者名字フリガナ   string yes     ラクテン
            /// </summary>
            public string familyNameKana { get; set; }
            /// <summary>
            /// 注文者名前フリガナ   string yes     タロウ
            /// </summary>
            public string firstNameKana { get; set; }
            /// <summary>
            ///  注文者郵便番号1    string yes		158
            /// </summary>
            public string zipCode1 { get; set; }
            /// <summary>
            /// 注文者郵便番号2    string yes		0094
            /// </summary>
            public string zipCode2 { get; set; }
            /// <summary>
            /// 注文者住所：都道府県 string yes     東京都
            /// </summary>
            public string prefecture { get; set; }
            /// <summary>
            /// 注文者住所：都市区 string yes     世田谷区
            /// </summary>
            public string city { get; set; }
            /// <summary>
            /// 注文者住所：町以降 string yes     玉川
            /// </summary>
            public string subAddress { get; set; }
            /// <summary>
            /// 注文者電話番号1    string yes 電話番号の1,2,3の内、nullは１つまで許可	090
            /// </summary>
            public string phoneNumber1 { get; set; }
            /// <summary>
            /// 注文者電話番号2    string	1234
            /// </summary>
            public string phoneNumber2 { get; set; }
            /// <summary>
            /// 注文者電話番号3    string	5678
            /// </summary>
            public string phoneNumber3 { get; set; }

            /// <summary>
            /// お荷物伝票番号
            /// </summary>
            public string shippingNumber { get; set; }
            /// <summary>
            /// 離島フラグ
            /// 0：送付先に離島が含まれていない
            /// 1：送付先に離島が含まれている
            /// </summary>
            public int isolatedIslandFlag { get; set; }
        }
        public class ReserveDetails
        {
            /// <summary>
            /// お届け回（詳細ID）	number yes		1
            /// </summary>
            public int detailId { get; set; }
            /// <summary>
            /// お届け日    date yes yyyy-MM-dd	2019-12-31
            /// </summary>
            public DateTime shippingDate { get; set; }
            /// <summary>
            /// 注文確定日   date yes yyyy-MM-dd	2019-12-30
            /// </summary>
            public DateTime commitDate { get; set; }
            /// <summary>
            /// 発売日 date no  yyyy-MM-dd	2019-11-30
            /// </summary>
            public DateTime? releaseDate { get; set; }
            /// <summary>
            /// 商品内訳    string no		null
            /// </summary>
            public string itemDetailName { get; set; }
            /// <summary>
            /// お届けステータス    number yes	1: 申込中	1
            /// </summary>
            public int shippingStatus { get; set; }
            /// <summary>
            /// 早期注文確定フラグ   number yes 以下いずれか
            /// 0：通常 1：早期注文確定	0
            /// </summary>
            public int earlyFlag { get; set; }
            /// <summary>
            /// 合計金額    number yes 商品金額 + 消費税 + 送料 + 決済手数料
            /// ※決済手数料には代引手数料、楽天バンク決済手数料、後払い決済手数料が入ります。
            /// ※消費税、送料、代引手数料のいずれかが未確定の場合、-9999になります。	2100
            /// </summary>
            public int totalAmount { get; set; }
            /// <summary>
            /// 申込決済情報  reserveSettlement yes		
            /// </summary>
            public ReserveSettlement reserveSettlement { get; set; }
            /// <summary>
            /// 申込請求金額情報    reserveAmount yes
            /// </summary>
            public ReserveAmount reserveAmount { get; set; }
        }
        public class ReserveSettlement
        {
            /// <summary>
            /// 支払方法    string yes     銀行振込
            /// </summary>
            public string settlementName { get; set; }
            /// <summary>
            /// カード会社   string no  支払方法が「クレジットカード」の場合のみ値があります。	VISA
            /// </summary>
            public string cardName { get; set; }
            /// <summary>
            /// カード名義人  string no  支払方法が「クレジットカード」の場合のみ値があります。	TARO RAKUTEN
            /// </summary>
            public string cardOwner { get; set; }
            /// <summary>
            /// クレジットカード分割選択    string no  以下のいずれか
            /// 0：一括払い
            /// 1：リボ払い
            /// 2：分割払い
            /// 3：その他払い
            /// 4：ボーナス一括払い
            /// 支払方法が「クレジットカード」の場合のみ値があります。	2
            /// </summary>
            public string cardInstallmentType { get; set; }
            /// <summary>
            /// クレジットカード分割備考    string no  以下のいずれか
            /// 103：3回払い
            /// 105：5回払い
            /// 106：6回払い
            /// 110：10回払い
            /// 112：12回払い
            /// 115：15回払い
            /// 118：18回払い
            /// 120：20回払い
            /// 124：24回払い
            /// 支払方法が「クレジットカード」、かつ、「クレジットカード分割選択」が「2: 分割払い」の場合のみ値があります。
            /// </summary>
            public string cardInstallmentDesc { get; set; }

        }
        public class ReserveAmount
        {
            /// <summary>
            /// 消費税 number no  税込み商品の場合は0が取得されます。
            /// ※未確定の場合、-9999になります。	100
            /// </summary>
            public int taxAmount { get; set; }
            /// <summary>
            /// 送料  number no	※未確定の場合、-9999になります。	1000
            /// </summary>
            public int postageAmount { get; set; }
            /// <summary>
            /// 代引料 number no  代引手数料が掛からない決済手段の場合は、0になります。
            /// ※未確定の場合、-9999になります。
            /// </summary>
            public int codFeeAmount { get; set; }
        }
    }

    public class ReserveKeyListModel
    {
        public string reserveNumber { get; set; }
        public int detailId { get; set; }
    }

    public class ReserveUpdateResponse
    {
        public DateTime date { get; set; }
        public string summaryResultMessage { get; set; }
        public List<UpdateUnitResponseModel> updateResultList { get; set; }
        public class UpdateUnitResponseModel
        {
            public string reserveNumber { get; set; }
            public int detailId { get; set; }
            public string resultCode { get; set; }
            public string resultMessage { get; set; }
        }
    }


}
