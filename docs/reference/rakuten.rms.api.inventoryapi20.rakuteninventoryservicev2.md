[`< Back`](./)

---

# RakutenInventoryServiceV2

Namespace: Rakuten.RMS.Api.InventoryAPI20

```csharp
public class RakutenInventoryServiceV2 : Rakuten.RMS.Api.JSON.RakutenApiJsonClientBase
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [RakutenApiJsonClientBase](./rakuten.rms.api.json.rakutenapijsonclientbase) → [RakutenInventoryServiceV2](./rakuten.rms.api.inventoryapi20.rakuteninventoryservicev2)

## Fields

### **MaxUpdateRecord**

```csharp
public static int MaxUpdateRecord;
```

### **MaxGetStatusRecord**

```csharp
public static int MaxGetStatusRecord;
```

## Properties

### **Version**

```csharp
public string Version { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

## Methods

### **Get(String, String)**

https://api.rms.rakuten.co.jp/es/2.0/inventories/manage-numbers/{manageNumber}/variants/{variantId}
 https://api.rms.rakuten.co.jp/es/2.1/inventories/manage-numbers/{manageNumber}/variants/{variantId}

```csharp
public InventoryStatusResult Get(string manageNumber, string variantId)
```

#### Parameters

`manageNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`variantId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[InventoryStatusResult](./rakuten.rms.api.inventoryapi20.inventorystatusresult)<br>

### **BulkGet(InventorySku[])**

itemUrl は小文字

```csharp
public List<InventoryStatusResult> BulkGet(InventorySku[] inventories)
```

#### Parameters

`inventories` [InventorySku[]](./rakuten.rms.api.inventoryapi20.inventorysku)<br>

#### Returns

[List&lt;InventoryStatusResult&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>

### **Upsert(String, String, UpsertMode, Int32)**

```csharp
public ResultBase Upsert(string manageNumber, string variantId, UpsertMode mode, int quantity)
```

#### Parameters

`manageNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`variantId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`mode` [UpsertMode](./rakuten.rms.api.inventoryapi20.upsertmode)<br>

`quantity` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

#### Returns

[ResultBase](./rakuten.rms.api.json.resultbase)<br>

### **Delete(String, String)**

```csharp
public ResultBase Delete(string manageNumber, string variantId)
```

#### Parameters

`manageNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`variantId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[ResultBase](./rakuten.rms.api.json.resultbase)<br>

### **GetRange(Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;)**

```csharp
public void GetRange(Nullable<int> minQuantity, Nullable<int> maxQuantity)
```

#### Parameters

`minQuantity` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`maxQuantity` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **BulkUpsert(IEnumerable&lt;InventorySkuUpsert&gt;)**

```csharp
public ResultBase BulkUpsert(IEnumerable<InventorySkuUpsert> inventories)
```

#### Parameters

`inventories` [IEnumerable&lt;InventorySkuUpsert&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

#### Returns

[ResultBase](./rakuten.rms.api.json.resultbase)<br>

---

[`< Back`](./)
