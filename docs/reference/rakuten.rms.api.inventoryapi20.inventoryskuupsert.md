<img align="left" style="height: 2em;" src="https://webservice.rakuten.co.jp/favicon.ico"><em>Rakuten RMS WEB API client for .NET</em>

[**< クラス一覧**](./)
- - -

# InventorySkuUpsert

Namespace: Rakuten.RMS.Api.InventoryAPI20

```csharp
public class InventorySkuUpsert : InventorySku
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ResultBase](./rakuten.rms.api.json.resultbase) → [InventorySku](./rakuten.rms.api.inventoryapi20.inventorysku) → [InventorySkuUpsert](./rakuten.rms.api.inventoryapi20.inventoryskuupsert)

## Properties

### <a id="properties-errors"/>**errors**

```csharp
public List<ResultError> errors { get; set; }
```

#### Property Value

[List&lt;ResultError&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>

### <a id="properties-managenumber"/>**manageNumber**

```csharp
public string manageNumber { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-mode"/>**mode**

```csharp
public UpsertMode mode { get; set; }
```

#### Property Value

[UpsertMode](./rakuten.rms.api.inventoryapi20.upsertmode)<br>

### <a id="properties-operationleadtime"/>**operationLeadTime**

```csharp
public OperationLeadTime operationLeadTime { get; set; }
```

#### Property Value

[OperationLeadTime](./rakuten.rms.api.inventoryapi20.operationleadtime)<br>

### <a id="properties-quantity"/>**quantity**

```csharp
public int quantity { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### <a id="properties-shipfromids"/>**shipFromIds**

IDの値はShopAPIの shop.shipFrom.get の下記項目から取得可能。 Level 3: shipFrom - shipFromId

```csharp
public IList<Int32> shipFromIds { get; set; }
```

#### Property Value

[IList&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

### <a id="properties-variantid"/>**variantId**

```csharp
public string variantId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

## Constructors

### <a id="constructors-.ctor"/>**InventorySkuUpsert()**

```csharp
public InventorySkuUpsert()
```

### <a id="constructors-.ctor"/>**InventorySkuUpsert(String, String, UpsertMode, Int32, OperationLeadTime, IList&lt;Int32&gt;)**

```csharp
public InventorySkuUpsert(string manageNumber, string variantId, UpsertMode mode, int quantity, OperationLeadTime operationLeadTime, IList<Int32> shipFromIds)
```

#### Parameters

`manageNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`variantId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`mode` [UpsertMode](./rakuten.rms.api.inventoryapi20.upsertmode)<br>

`quantity` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`operationLeadTime` [OperationLeadTime](./rakuten.rms.api.inventoryapi20.operationleadtime)<br>

`shipFromIds` [IList&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>


- - -
[**< クラス一覧**](./)
