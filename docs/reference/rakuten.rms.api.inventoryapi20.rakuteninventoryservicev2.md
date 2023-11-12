<img align="left" style="height: 2em;" src="https://webservice.rakuten.co.jp/favicon.ico"><em>Rakuten RMS WEB API client for .NET</em>

[**< クラス一覧**](./)
- - -

# RakutenInventoryServiceV2

Namespace: Rakuten.RMS.Api.InventoryAPI20

```csharp
public class RakutenInventoryServiceV2 : Rakuten.RMS.Api.JSON.RakutenApiJsonClientBase
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [RakutenApiClientBaseCommon](./rakuten.rms.api.rest.rakutenapiclientbasecommon) → [RakutenApiJsonClientBase](./rakuten.rms.api.json.rakutenapijsonclientbase) → [RakutenInventoryServiceV2](./rakuten.rms.api.inventoryapi20.rakuteninventoryservicev2)

## Fields

### <a id="fields-maxgetstatusrecord"/>**MaxGetStatusRecord**

```csharp
public static int MaxGetStatusRecord;
```

### <a id="fields-maxupdaterecord"/>**MaxUpdateRecord**

```csharp
public static int MaxUpdateRecord;
```

## Properties

### <a id="properties-version"/>**Version**

```csharp
public string Version { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

## Methods

### <a id="methods-bulkget"/>**BulkGet(InventorySku[])**

商品管理番号とSKU管理番号を指定し、最大で1000件の在庫数を一括で取得できます。

```csharp
public List<InventoryStatusResult> BulkGet(InventorySku[] inventories)
```

#### Parameters

`inventories` [InventorySku[]](./rakuten.rms.api.inventoryapi20.inventorysku)<br>

#### Returns

[List&lt;InventoryStatusResult&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)

### <a id="methods-bulkget"/>**BulkGet(Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;)**

商品管理番号とSKU管理番号を指定し、最大で1000件の在庫数を一括で取得できます。

```csharp
public List<InventoryStatusResult> BulkGet(Nullable<Int32> minQuantity, Nullable<Int32> maxQuantity)
```

#### Parameters

`minQuantity` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
最小在庫数

`maxQuantity` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
最大在庫数

#### Returns

[List&lt;InventoryStatusResult&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)

#### Exceptions

[ErrorResponseException](./rakuten.rms.api.json.errorresponseexception)<br>

### <a id="methods-bulkupsert"/>**BulkUpsert(IEnumerable&lt;InventorySkuUpsert&gt;)**

```csharp
public ResultBase BulkUpsert(IEnumerable<InventorySkuUpsert> inventories)
```

#### Parameters

`inventories` [IEnumerable&lt;InventorySkuUpsert&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

#### Returns

[ResultBase](./rakuten.rms.api.json.resultbase)

### <a id="methods-delete"/>**Delete(String, String)**

商品管理番号とSKU管理番号を指定し、在庫情報を削除する

```csharp
public ResultBase Delete(string manageNumber, string variantId)
```

#### Parameters

`manageNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`variantId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[ResultBase](./rakuten.rms.api.json.resultbase)

### <a id="methods-get"/>**Get(String, String)**

https://api.rms.rakuten.co.jp/es/2.0/inventories/manage-numbers/{manageNumber}/variants/{variantId}
 https://api.rms.rakuten.co.jp/es/2.1/inventories/manage-numbers/{manageNumber}/variants/{variantId}

```csharp
public InventoryStatusResult Get(string manageNumber, string variantId)
```

#### Parameters

`manageNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`variantId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[InventoryStatusResult](./rakuten.rms.api.inventoryapi20.inventorystatusresult)

### <a id="methods-upsert"/>**Upsert(String, String, UpsertMode, Int32)**

```csharp
public ResultBase Upsert(string manageNumber, string variantId, UpsertMode mode, int quantity)
```

#### Parameters

`manageNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`variantId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`mode` [UpsertMode](./rakuten.rms.api.inventoryapi20.upsertmode)<br>

`quantity` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

#### Returns

[ResultBase](./rakuten.rms.api.json.resultbase)


- - -
[**< クラス一覧**](./)
