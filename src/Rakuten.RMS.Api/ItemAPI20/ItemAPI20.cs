using Rakuten.RMS.Api.JSON;
using System;

namespace Rakuten.RMS.Api.ItemAPI20
{
    /// <summary>
    /// 商品API
    /// 商品情報の取得・登録・更新・削除
    /// </summary>
    public class ItemAPI20 : RakutenApiJsonClientBase
    {
        public ItemAPI20(ServiceProvider provider) : base(provider)
        {
        }
        /// <summary>
        /// items.get
        /// 商品管理番号を指定し、商品情報を取得
        /// </summary>
        /// <param name="manageNumber">商品管理番号</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public GetItem Get(string manageNumber)
        {
            if (string.IsNullOrEmpty(manageNumber))
                throw new ArgumentNullException("manageNumber");
            return GetRequest<GetItem>(
                $"https://api.rms.rakuten.co.jp/es/2.0/items/manage-numbers/{manageNumber}");
        }
        /// <summary>
        /// items.upsert
        /// 商品管理番号を指定し、商品情報の登録・全項目の更新
        /// </summary>
        /// <param name="manageNumber">商品管理番号</param>
        /// <param name="item"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public ResultBase Upsert(string manageNumber, UpsertItem item)
        {
            if (string.IsNullOrEmpty(manageNumber))
                throw new ArgumentNullException("manageNumber");
            return PostRequest<ResultBase>(
                $"https://api.rms.rakuten.co.jp/es/2.0/items/manage-numbers/{manageNumber}",
                item,
                "PUT");
        }
        /// <summary>
        /// items.patch
        /// 商品管理番号を指定し、商品情報の部分更新
        /// </summary>
        /// <param name="manageNumber">商品管理番号</param>
        /// <param name="item"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public ResultBase Patch(string manageNumber, PatchItem item)
        {
            if (string.IsNullOrEmpty(manageNumber))
                throw new ArgumentNullException("manageNumber");
            return PostRequest<ResultBase>(
                $"https://api.rms.rakuten.co.jp/es/2.0/items/manage-numbers/{manageNumber}",
                item,
                "PATCH");
        }
        /// <summary>
        /// items.delete
        /// 商品管理番号を指定し、商品情報を削除
        /// </summary>
        /// <param name="manageNumber">商品管理番号</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public ResultBase Delete(string manageNumber)
        {
            if (string.IsNullOrEmpty(manageNumber))
                throw new ArgumentNullException("manageNumber");
            return GetRequest<ResultBase>(
                $"https://api.rms.rakuten.co.jp/es/2.0/items/manage-numbers/{manageNumber}",
                "DELETE");
        }
        /// <summary>
        /// items.search
        /// 指定した条件から通常商品・予約商品・定期購入商品の商品情報を検索
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void Search()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// items.inventory-related-settings.get
        /// 商品管理番号を指定し、納期に関する設定などを取得
        /// </summary>
        /// <param name="manageNumber">商品管理番号</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public InventoryRelatedSettings GetInventoryRelatedSettings(string manageNumber)
        {
            if (string.IsNullOrEmpty(manageNumber))
                throw new ArgumentNullException("manageNumber");
            return GetRequest<InventoryRelatedSettings>(
                $"https://api.rms.rakuten.co.jp/es/2.0/items/inventory-related-settings/manage-numbers/{manageNumber}");
        }
        /// <summary>
        /// items.inventory-related-settings.update
        /// 商品管理番号を指定し、納期に関する設定などを更新
        /// </summary>
        /// <param name="manageNumber">商品管理番号</param>
        /// <param name="settings"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public ResultBase UpdateInventoryRelatedSettings(string manageNumber, InventoryRelatedSettings settings)
        {
            if (string.IsNullOrEmpty(manageNumber))
                throw new ArgumentNullException("manageNumber");
            if( settings.variants == null || (settings.variants.Count < 1 || settings.variants.Count>400 ) )
            {
                throw new ArgumentOutOfRangeException("variants must have 1 to 400 records.");
            } 
            return PostRequest<ResultBase>(
                $"https://api.rms.rakuten.co.jp/es/2.0/items/inventory-related-settings/manage-numbers/{manageNumber}",
                settings,
                "PUT");
        }

    }
}
