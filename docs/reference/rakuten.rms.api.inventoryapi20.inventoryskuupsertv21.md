[`< Back`](./)

---

# InventorySkuUpsertV21

Namespace: Rakuten.RMS.Api.InventoryAPI20

```csharp
public class InventorySkuUpsertV21 : InventorySkuUpsert
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ResultBase](./rakuten.rms.api.json.resultbase) → [InventorySku](./rakuten.rms.api.inventoryapi20.inventorysku) → [InventorySkuUpsert](./rakuten.rms.api.inventoryapi20.inventoryskuupsert) → [InventorySkuUpsertV21](./rakuten.rms.api.inventoryapi20.inventoryskuupsertv21)

## Properties

### **mode**

```csharp
public UpsertMode mode { get; set; }
```

#### Property Value

[UpsertMode](./rakuten.rms.api.inventoryapi20.upsertmode)<br>

### **quantity**

```csharp
public int quantity { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **operationLeadTime**

```csharp
public OperationLeadTime operationLeadTime { get; set; }
```

#### Property Value

[OperationLeadTime](./rakuten.rms.api.inventoryapi20.operationleadtime)<br>

### **shipFromIds**

IDの値はShopAPIの shop.shipFrom.get の下記項目から取得可能。 Level 3: shipFrom - shipFromId

```csharp
public IList<int> shipFromIds { get; set; }
```

#### Property Value

[IList&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

### **manageNumber**

```csharp
public string manageNumber { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **variantId**

```csharp
public string variantId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **errors**

```csharp
public List<ResultError> errors { get; set; }
```

#### Property Value

[List&lt;ResultError&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>

## Constructors

### **InventorySkuUpsertV21()**

```csharp
public InventorySkuUpsertV21()
```

---

[`< Back`](./)
