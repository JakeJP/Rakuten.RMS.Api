[`< Back`](./)

---

# InventorySkuUpsert

Namespace: Rakuten.RMS.Api.InventoryAPI20

```csharp
public class InventorySkuUpsert : InventorySku
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ResultBase](./rakuten.rms.api.json.resultbase) → [InventorySku](./rakuten.rms.api.inventoryapi20.inventorysku) → [InventorySkuUpsert](./rakuten.rms.api.inventoryapi20.inventoryskuupsert)

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

### **InventorySkuUpsert()**

```csharp
public InventorySkuUpsert()
```

### **InventorySkuUpsert(String, String, UpsertMode, Int32, OperationLeadTime, IList&lt;Int32&gt;)**

```csharp
public InventorySkuUpsert(string manageNumber, string variantId, UpsertMode mode, int quantity, OperationLeadTime operationLeadTime, IList<int> shipFromIds)
```

#### Parameters

`manageNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`variantId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`mode` [UpsertMode](./rakuten.rms.api.inventoryapi20.upsertmode)<br>

`quantity` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`operationLeadTime` [OperationLeadTime](./rakuten.rms.api.inventoryapi20.operationleadtime)<br>

`shipFromIds` [IList&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

---

[`< Back`](./)
