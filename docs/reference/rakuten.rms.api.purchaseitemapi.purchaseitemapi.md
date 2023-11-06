[`< Back`](./)

---

# PurchaseItemAPI

Namespace: Rakuten.RMS.Api.PurchaseItemAPI

購入商品API（PurchaseItemAPI）

```csharp
public class PurchaseItemAPI : Rakuten.RMS.Api.JSON.RakutenApiJsonClientBase
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [RakutenApiClientBaseCommon](./rakuten.rms.api.rest.rakutenapiclientbasecommon) → [RakutenApiJsonClientBase](./rakuten.rms.api.json.rakutenapijsonclientbase) → [PurchaseItemAPI](./rakuten.rms.api.purchaseitemapi.purchaseitemapi)

## Methods

### **SearchOrderItem(SearchOrderItemRequest)**

注文検索

```csharp
public SearchOrderResponse SearchOrderItem(SearchOrderItemRequest request)
```

#### Parameters

`request` [SearchOrderItemRequest](./rakuten.rms.api.rakutenpayorderapi.searchorderitemrequest)<br>

#### Returns

[SearchOrderResponse](./rakuten.rms.api.rakutenpayorderapi.searchorderresponse)<br>

### **GetOrderItem(IList&lt;String&gt;)**

購入された商品に関連する情報の取得

```csharp
public GetOrderResponse GetOrderItem(IList<string> orderNumberList)
```

#### Parameters

`orderNumberList` [IList&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

#### Returns

[GetOrderResponse](./rakuten.rms.api.rakutenpayorderapi.getorderresponse)<br>

---

[`< Back`](./)
