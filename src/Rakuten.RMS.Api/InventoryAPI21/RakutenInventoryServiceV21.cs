using Rakuten.RMS.Api.InventoryAPI20;

namespace Rakuten.RMS.Api.InventoryAPI21
{
    public class RakutenInventoryServiceV21 : RakutenInventoryServiceV2
    {
        internal RakutenInventoryServiceV21(ServiceProvider provider) : base(provider, "2.1")
        {
        }
    }
}
