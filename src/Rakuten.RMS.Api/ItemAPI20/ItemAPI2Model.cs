using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Rakuten.RMS.Api.ItemAPI20
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class UpsertItem : ItemCommon
    {

    }
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class PatchItem : ItemCommon
    {
        public new ItemType? itemType { get; set; }
        public new bool? hideItem { get; set; }
        public new bool? unlimitedInventoryFlag { get; set; }
        public new long? itemDisplaySequence { get; set; }
        public new Dictionary<string, PatchVariant> variants { get; set; }
        public override void InitializeVariants() => variants = variants ?? new Dictionary<string, PatchVariant>();

        public override Variant NewVariant() => new PatchVariant();
        public override void AddVariant(string variantId, Variant variant)
        {
            InitializeVariants();
            variants.Add(variantId, (PatchVariant)variant);
        }
        [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
        public class PatchVariant : ItemCommon.Variant
        {
            public new int? asurakuDeliveryId { get; set; }
        }
    }
    public class GetItem : ItemCommon
    {
        /// <summary>
        /// 商品管理番号
        /// </summary>
        public string manageNumber { get; set; }
        public DateTime created { get; set; }
        public DateTime updated { get; set; }

    }
    public abstract class ItemCommon
    {
        /// <summary>
        /// 商品番号
        /// </summary>
        [DisplayName("商品番号")]
        public string itemNumber { get; set; }
        /// <summary>
        /// 商品名
        /// </summary>
        [DisplayName("商品名")]
        public string title { get; set; }
        /// <summary>
        /// キャッチコピー
        /// </summary>
        [DisplayName("キャッチコピー")]
        public string tagline { get; set; }

        public class ProductDescription
        {
            [DisplayName("PC用商品説明文")]
            public string pc { get; set; }
            [DisplayName("スマートフォン用商品説明文")]
            public string sp { get; set; }

        }
        [DisplayName("商品説明文")]
        public ProductDescription productDescription { get; set; }
        [DisplayName("PC用販売説明文")]
        public string salesDescription { get; set; }
        public class Precautions
        {
            [DisplayName("医薬品説明文")]
            public string description { get; set; }
            [DisplayName("医薬品注意事項")]
            public string agreement { get; set; }
        }
        [DisplayName("医薬品説明文・注意事項")]
        public Precautions precautions { get; set; }
        public enum ItemType
        {
            NORMAL,
            PRE_ORDER,
            SUBSCRIPTION
        }
        [DisplayName("商品種別")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ItemType itemType { get; set; }

        public enum ImageType
        {
            CABINET,
            GOLD,
            ABSOLUTE // only for Category API?
        }
        public class WhiteBgImage
        {
            [JsonConverter(typeof(StringEnumConverter))]
            [Required]
            [DisplayName("画像種別")]
            public ImageType type { get; set; }
            [Required]
            [DisplayName("画像URL")]
            public string location { get; set; }
        }
        public class Image : WhiteBgImage
        {
            [DisplayName("画像名（ALT）")]
            public string alt { get; set; }

        }
        [DisplayName("商品画像")]
        public IList<Image> images { get; set; }
        [DisplayName("白背景画像")]
        public WhiteBgImage whiteBgImage { get; set; }
        public enum VideoType
        {
            HTML
        }
        public class VideoParameters
        {
            /// <summary>
            /// 動画のURL
            /// </summary>
            [JsonConverter(typeof(StringEnumConverter))]
            [Required]
            [DisplayName("動画のURL")]
            public string value { get; set; }
        }
        public class Video
        {
            [Required]
            [DisplayName("動画種別")]
            public VideoType type { get; set; }
            [Required]
            [DisplayName("動画パラメータ")]
            public VideoParameters parameters { get; set; }
        }
        [DisplayName("動画")]
        public Video video { get; set; }
        [DisplayName("ジャンルID")]
        public string genreId { get; set; }
        [DisplayName("非製品属性タグID")]
        public IList<long> tags { get; set; }
        [DisplayName("倉庫指定")]
        public bool hideItem { get; set; }
        [DisplayName("在庫設定なし")]
        public bool unlimitedInventoryFlag { get; set; }
        public enum CustomizationInputType
        {
            SINGLE_SELECTION,
            MULTIPLE_SELECTION,
            FREE_TEXT
        }
        public class CustomizationOption
        {
            [Required]
            [DisplayName("商品オプション（項目選択肢）項目名")]
            public string displayName { get; set; }
            [JsonConverter(typeof(StringEnumConverter))]
            [Required]
            [DisplayName("商品オプション（項目選択肢）選択肢タイプ")]
            public CustomizationInputType inputType { get; set; }
            [DisplayName("商品オプション必須フラグ")]
            public bool? required { get; set; }
            [Required(conditional: true)]
            [DisplayName("Select/Checkbox用選択肢リスト")]
            public IList<OptionSelection> selections { get; set; }
        }
        public class OptionSelection
        {
            [DisplayName("商品オプション選択肢名")]
            public string displayValue { get; set; }
        }
        /// <summary>
        /// 商品種別を「PRE_ORDER」に更新した場合、必須。
        /// フォーマットはISO 8601、タイムゾーンは日本標準時（JST）、日まで。
        /// 定期購入商品の場合は設定不可
        /// </summary>
        [Required(conditional: true)]
        [DisplayName("予約商品発売日")]
        public DateTime? releaseDate { get; set; }
        public class Period
        {
            [Required]
            [DisplayName("開始日時")]
            public DateTime? start { get; set; }
            [Required]
            [DisplayName("終了日時")]
            public DateTime? end { get; set; }
        }
        [DisplayName("販売期間指定")]
        public Period purchasablePeriod { get; set; }
        public class Subscription
        {
            [DisplayName("お届け日付指定フラグ")]
            public bool? shippingDateFlag { get; set; }
            [DisplayName("お届け間隔指定フラグ")]
            public bool? shippingIntervalFlag { get; set; }

        }
        [DisplayName("定期購入商品設定")]
        public Subscription subscription { get; set; }
        public enum SearchEnum
        {
            ALWAYS_VISIBLE,
            ALWAYS_HIDDEN
        }
        public enum InventoryDisplayEnum
        {
            DISPLAY_ABSOLUTE_STOCK_COUNT,
            HIDDEN_STOCK,
            DISPLAY_LOW_STOCK
        }
        public enum ReviewEnum
        {
            SHOP_SETTING,
            VISIBLE,
            HIDDEN
        }
        public class Feature
        {
            [JsonConverter(typeof(StringEnumConverter))]
            [DisplayName("サーチ表示")]
            public SearchEnum searchVisibility { get; set; }
            [DisplayName("注文ボタン")]
            public bool displayNormalCartButton { get; set; }
            [DisplayName("定期購入ボタン")]
            public bool displaySubscriptionCartButton { get; set; }
            [JsonConverter(typeof(StringEnumConverter))]
            [DisplayName("在庫数表示")]
            public InventoryDisplayEnum inventoryDisplay { get; set; }
            [Required(conditional: true)]
            [DisplayName("残り在庫数表示閾値")]
            public int? lowStockThreshold { get; set; }
            [DisplayName("商品問い合わせボタン")]
            public bool shopContact { get; set; }
            [JsonConverter(typeof(StringEnumConverter))]
            [DisplayName("商品問い合わせボタン")]
            public ReviewEnum review { get; set; }
            [DisplayName("メーカー提供情報表示")]
            public bool displayManufacturerContents { get; set; }
        }
        public class AccessControl
        {
            [DisplayName("闇市パスワード")]
            public string accessPassword { get; set; }
        }
        [DisplayName("アクセスコントロール")]
        public AccessControl accessControl { get; set; }

        public class Payment
        {
            [DisplayName("決済情報")]
            public bool taxIncluded { get; set; }
            [DisplayName("消費税税率")]
            public string taxRate { get; set; }
            [DisplayName("代引料")]
            public bool cashOnDeliveryFeeIncluded { get; set; }
        }
        [DisplayName("決済情報")]
        public Payment payment { get; set; }
        public class PointCampaign
        {
            [DisplayName("ポイント変倍適用期間")]
            public Period applicablePeriod { get; set; }
            public class Benefits
            {
                [Required]
                public int? pointRate { get; set; }

            }
            [Required]
            [DisplayName("ポイント情報")]
            public Benefits benefits { get; set; }
            public class Optimization
            {
                [Required]
                [DisplayName("ポイント上限倍率")]
                public int? maxPointRate { get; set; }
            }
            [DisplayName("運用型ポイント情報")]
            public Optimization optimization { get; set; }
        }
        [DisplayName("ポイント変倍情報")]
        public PointCampaign pointCampaign { get; set; }
        [DisplayName("店舗内カテゴリでの表示順位")]
        public long itemDisplaySequence { get; set; }
        public class Layout
        {
            [DisplayName("商品ページレイアウト")]
            public int itemLayoutId { get; set; }
            [DisplayName("ヘッダー・フッター・レフトナビのテンプレートID")]
            public int navigationId { get; set; }
            [DisplayName("表示項目の並び順テンプレートID")]
            public int layoutSequenceId { get; set; }
            [DisplayName("共通説明文(小)テンプレートID")]
            public int smallDescriptionId { get; set; }
            [DisplayName("共通説明文(大)テンプレートID")]
            public int largeDescriptionId { get; set; }
            [DisplayName("共通説明文(小)テンプレートID")]
            public int showcaseId { get; set; }
        }
        [DisplayName("レイアウト設定")]
        public Layout layout { get; set; }
        public class VariantSelector
        {
            public class Value
            {
                [DisplayName("バリエーション選択肢")]
                public string displayValue { get; set; }
            }
            [Required]
            [DisplayName("共通説明文(小)テンプレートID")]
            public string key { get; set; }
            [Required]
            [DisplayName("バリエーション項目名")]
            public string displayName { get; set; }
            [Required]
            [DisplayName("バリエーション項目")]
            public List<Value> values { get; set; }
        }
        public IList<VariantSelector> variantSelectors { get; set; }
        public class Variant
        {
            //public string variantId { get; set; }
            [DisplayName("バリエーション項目")]
            public string merchantDefinedSkuId { get; set; }
            [DisplayName("SKU情報")]
            public Dictionary<string, string> selectorValues { get; set; }
            [DisplayName("SKU画像")]
            public IList<Image> images { get; set; }
            [DisplayName("在庫戻しフラグ")]
            public bool? restockOnCancel { get; set; }
            [DisplayName("在庫切れ時の注文受付")]
            public bool? backOrderFlag { get; set; }
            [DisplayName("在庫あり時納期管理番号")]
            public int? normalDeliveryDateId { get; set; }
            [Required(conditional: true)]
            [DisplayName("在庫あり時納期管理番号")]
            public int? backOrderDeliveryDateId { get; set; }
            [DisplayName("注文受付数")]
            public int? orderQuantityLimit { get; set; }
            public class ReferencePrice
            {
                public enum DisplayType
                {
                    REFERENCE_PRICE,
                    SHOP_SETTING,
                    OPEN_PRICE
                }
                [JsonConverter(typeof(StringEnumConverter))]
                [Required]
                [DisplayName("表示価格種別")]
                public DisplayType displayType { get; set; }
                /// <summary>
                /// 表示価格種別に「REFERENCE_PRICE」を設定し、かつ表示価格文言に「4：商品価格ナビのデータ参照」以外の値を設定した場合、必須。
                /// 定期購入商品の場合、SKUごとに異なる値の設定は不可。
                /// 許容値：1～999999999
                /// </summary>
                [Required(conditional: true)]
                [JsonProperty(NullValueHandling = NullValueHandling.Include)]
                [DisplayName("表示価格文言")]
                public int? type { get; set; }
                /// <summary>
                /// 表示価格種別に「REFERENCE_PRICE」を設定し、かつ表示価格文言に「4：商品価格ナビのデータ参照」以外の値を設定した場合、必須。
                /// 定期購入商品の場合、SKUごとに異なる値の設定は不可。
                /// 許容値：1～999999999
                /// </summary>
                [Required(conditional: true)]
                [DisplayName("表示価格")]
                public string value { get; set; }
            }
            [DisplayName("表示価格")]
            public ReferencePrice referencePrice { get; set; }
            public class Feature
            {
                [DisplayName("\t再入荷お知らせボタン")]
                public bool? restockNotification { get; set; }
                [DisplayName("のし対応")]
                public bool? noshi { get; set; }
            }
            [DisplayName("その他設定")]
            public Feature features { get; set; }
            [DisplayName("SKU倉庫設定")]
            public bool? hidden { get; set; }
            [Required(conditional: true)]
            [DisplayName("販売価格")]
            public string standardPrice { get; set; }
            public class SubscriptionPrice
            {
                [Required]
                public string basePrice { get; set; }
                public class IndividualPrices
                {
                    string firstPrice { get; set; }
                }
            }
            [Required(conditional: true)]
            [DisplayName("定期購入販売価格設定")]
            public SubscriptionPrice subscriptionPrice { get; set; }
            [DisplayName("セット商品用カタログID")]
            public IList<string> articleNumberForSet { get; set; }
            [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
            public class ArticleNumber
            {
                [Required(conditional: true)]
                [DisplayName("カタログID")]
                public string value { get; set; }
                [Required(conditional: true)]
                [DisplayName("カタログIDなしの理由")]
                public int? exemptionReason { get; set; }
            }
            [DisplayName("カタログID情報")]
            public ArticleNumber articleNumber { get; set; }
            public class PostageSegment
            {
                /// <summary>
                /// 送料区分1(ローカル)
                /// </summary>
                [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
                [DisplayName("送料区分1（ローカル）")]
                public int? local { get; set; }
                /// <summary>
                /// 送料区分2(海外)
                /// </summary>
                [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
                [DisplayName("送料区分1（ローカル）")]
                public int? overseas { get; set; }
            }
            [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
            public class Shipping
            {
                [DisplayName("個別送料")]
                public string fee { get; set; }
                [DisplayName("送料無料フラグ")]
                public bool? postageIncluded { get; set; }
                [DisplayName("地域別個別送料管理番号")]
                public int? shopAreaSoryoPatternId { get; set; }
                [DisplayName("配送方法セット管理番号")]
                public string shippingMethodGroup { get; set; }

                [DisplayName("送料区分情報")]
                public PostageSegment postageSegment { get; set; }
                [DisplayName("海外配送管理番号")]
                public int? overseasDeliveryId { get; set; }
                [DisplayName("単品配送設定")]
                public int? singleItemShipping { get; set; }
            }
            [DisplayName("送料情報")]
            public Shipping shipping { get; set; }
            [DisplayName("送料情報")]
            public int asurakuDeliveryId { get; set; }
            public class Spec
            {
                [Required]
                [DisplayName("送料区分1（ローカル）")]
                public string label { get; set; }
                [Required]
                [DisplayName("属性情報自由入力行（値）")]
                public string value { get; set; }

            }
            [DisplayName("送料区分1（ローカル）")]
            public IList<Spec> specs { get; set; }
            public class Attribute
            {
                [Required]
                [DisplayName("属性情報名")]
                public string name { get; set; }
                [Required]
                [DisplayName("属性情報（実値）")]
                public IList<string> values { get; set; }
                [DisplayName("単位")]
                public string unit { get; set; }

            }
            public IList<Attribute> attributes { get; set; }
        }

        public virtual Dictionary<string, Variant> variants { get; set; }
        public virtual void InitializeVariants() => variants = variants ?? new Dictionary<string, Variant>();
        public virtual Variant NewVariant() => new Variant();
        public virtual void AddVariant(string variantId, Variant variant)
        {
            InitializeVariants();
            variants.Add(variantId, variant);
        }

    }
}
