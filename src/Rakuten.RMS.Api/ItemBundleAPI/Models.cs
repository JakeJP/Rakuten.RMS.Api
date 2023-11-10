using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rakuten.RMS.Api.ItemBundleAPI
{
    [DecodableObject]
    public class BundleListRequest
    {
        /// <summary>
        /// ・ACTIVE・INACTIVE
        /// </summary>
        public string bundleState { get; set; }
        public int? pageSize { get; set; }
        public int? pageNumber { get; set; }
        public string itemManageNumber { get; set; }
        /// <summary>
        /// ・parent・child
        /// </summary>
        public string type { get; set; }
        public string bundleName { get; set; }

    }
    public class BundleToCreate
    {
        public string parentItemManageNumber { get; set; } // yes String	32	-	組み合わせの親商品。 組み合わせられた子商品は親商品のページにて関連商品として表示されます。	item-001
        /// <summary>
        /// 2	組み合わせ管理番号 
        /// </summary>
        public string bundleManageNumber { get; set; } // yes String	64	-	組み合わせ販売の管理番号。組み合わせを新規登録する際に指定され、店舗内においてユニークな番号です。	my-shop-bundle-001
        /// <summary>
        /// 3	表示設定 
        /// ・ACTIVE
        /// ・INACTIVE ACTIVE
        /// </summary>
        public string bundleState { get; set; } // yes String	-	-	商品ページ上の組み合わせ表示設定。1つの親商品に対して、最大2つの組み合わせを表示させる（ACTIVE）ことが可能です。非表示（INACTIVE）の組み合わせの制限はありません。設定可能な値は以下のいずれか

        /// <summary>
        /// 組み合わせ商品リスト 
        /// </summary>
        public List<BundleItemToCreate> bundleItems { get; set; } // yes List<String>    -	-	組み合わせられた商品のリスト。親商品も該当リストに入ります。1つの親商品に対して、子商品は必ず1つ登録する必要があり、最大3つまで登録できます。	
        /// <summary>
        /// // 5	組み合わせ管理名称 
        /// </summary>
        public string bundleName { get; set; } // yes String	32	-	組み合わせの管理名称 スマートフォンの組み合わせ
        /// <summary>
        /// 6	組み合わせ販売説明文 
        /// </summary>
        public string bundleDescription { get; set; } //  no String	50	-	組み合わせ販売の説明文
    }
    public class BundleItemToCreate
    {
        public string itemManageNumber { get; set; }
        public bool? mandatory { get; set; }
        public int? sequence { get; set; }
    }
    public class BundleListResponse
    {
        public int numberOfBundles { get; set; }
        public List<Bundle> bundles { get; set; }
    }
    public class Bundle
    {
        /// <summary>
        /// 組み合わせ管理番号 
        /// </summary>
        public string bundleManageNumber { get; set; } // yes String	64	組み合わせ販売の管理番号。組み合わせを新規登録する際に指定され、店舗内においてユニークな番号です。	my-shop-bundle-001
        /// <summary>
        /// 2	組み合わせ管理名称
        /// </summary>
        public string bundleName { get; set; } // yes String	32	組み合わせの管理名称 スマートフォンの組み合わせ
        /// <summary>
        /// 3	組み合わせ販売説明文
        /// </summary>
        public string bundleDescription { get; set; } //  no String	50	組み合わせ販売の説明文。PC用商品ページでのみ表示されます。	スマートフォン本体とスマホカバーの組み合わせです。
        /// <summary>
        /// 4	表示設定 
        /// </summary>
        public string bundleState { get; set; } // yes String	-	商品ページ上の組み合わせ表示設定。有効な値は以下のいずれか ・ACTIVE ・INACTIVE ACTIVE：表示 INACTIVE：非表示 ACTIVE
        /// <summary>
        /// 5	親商品管理番号 
        /// </summary>
        public string parentItemManageNumber { get; set; } // yes String	32	組み合わせの親商品。組み合わせられた子商品は親商品のページにて関連商品として表示されます。	item-001
        /// <summary>
        /// 6	組み合わせ商品リスト 
        /// </summary>
        public List<BundleItem> bundleItems { get; set; } // yes List<String>    -	組み合わせられた商品のリスト。親商品も該当リストに入ります。	
        /// <summary>
        /// 7	作成日 -	組み合わせの作成日時  2017-11-22T06:30:00.000141Z
        /// </summary>
        public DateTime createdDate { get; set; }
        /// <summary>
        /// 8	更新日  yes Date	-	組み合わせの最終更新日時
        /// </summary>
        public DateTime updatedDate { get; set; }
    }
    public class BundleItem
    {
        public string itemManageNumber { get; set; }
        public bool isDeletedItem { get; set; }
        public bool mandatory { get; set; }
        public int sequence { get; set; }
    }
}
