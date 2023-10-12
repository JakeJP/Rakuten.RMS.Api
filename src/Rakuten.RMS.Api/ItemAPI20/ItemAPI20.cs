using Rakuten.RMS.Api.JSON;
using System;

namespace Rakuten.RMS.Api.ItemAPI20
{
    public class ItemAPI20 : RakutenApiJsonClientBase
    {
        public ItemAPI20(ServiceProvider provider) : base(provider)
        {
        }
        public GetItem Get(string manageNumber)
        {
            if (string.IsNullOrEmpty(manageNumber))
                throw new ArgumentNullException("manageNumber");
            return GetRequest<GetItem>(
                $"https://api.rms.rakuten.co.jp/es/2.0/items/manage-numbers/{manageNumber}");
        }
        public ResultBase Upsert(string manageNumber, UpsertItem item)
        {
            if (string.IsNullOrEmpty(manageNumber))
                throw new ArgumentNullException("manageNumber");
            return PostRequest<ResultBase>(
                $"https://api.rms.rakuten.co.jp/es/2.0/items/manage-numbers/{manageNumber}",
                item,
                "PUT");
        }
        public ResultBase Patch(string manageNumber, PatchItem item)
        {
            if (string.IsNullOrEmpty(manageNumber))
                throw new ArgumentNullException("manageNumber");
            return PostRequest<ResultBase>(
                $"https://api.rms.rakuten.co.jp/es/2.0/items/manage-numbers/{manageNumber}",
                item,
                "PATCH");
        }
        public ResultBase Delete(string manageNumber)
        {
            if (string.IsNullOrEmpty(manageNumber))
                throw new ArgumentNullException("manageNumber");
            return GetRequest<ResultBase>(
                $"https://api.rms.rakuten.co.jp/es/2.0/items/manage-numbers/{manageNumber}",
                "DELETE");
        }
        public void Search()
        {
            throw new NotImplementedException();
        }
        public InventoryRelatedSettings InventoryRelatedSettingsGet(string manageNumber)
        {
            if (string.IsNullOrEmpty(manageNumber))
                throw new ArgumentNullException("manageNumber");
            return GetRequest<InventoryRelatedSettings>(
                $"https://api.rms.rakuten.co.jp/es/2.0/items/inventory-related-settings/manage-numbers/{manageNumber}");
        }
        public ResultBase InventoryRelatedSettingsUpdate(string manageNumber, InventoryRelatedSettings settings)
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
