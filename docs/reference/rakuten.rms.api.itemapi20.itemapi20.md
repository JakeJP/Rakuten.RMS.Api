[`< Back`](./)

---

# ItemAPI20

Namespace: Rakuten.RMS.Api.ItemAPI20

商品API
 商品情報の取得・登録・更新・削除

```csharp
public class ItemAPI20 : Rakuten.RMS.Api.JSON.RakutenApiJsonClientBase
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [RakutenApiClientBaseCommon](./rakuten.rms.api.rest.rakutenapiclientbasecommon) → [RakutenApiJsonClientBase](./rakuten.rms.api.json.rakutenapijsonclientbase) → [ItemAPI20](./rakuten.rms.api.itemapi20.itemapi20)

## Methods

### **Get(String)**

items.get
 商品管理番号を指定し、商品情報を取得

```csharp
public Item Get(string manageNumber)
```

#### Parameters

`manageNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
商品管理番号

#### Returns

[Item](./rakuten.rms.api.itemapi20.item)<br>

#### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)<br>

### **Upsert(String, UpsertItem)**

items.upsert
 商品管理番号を指定し、商品情報の登録・全項目の更新

```csharp
public ResultBase Upsert(string manageNumber, UpsertItem item)
```

#### Parameters

`manageNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
商品管理番号

`item` [UpsertItem](./rakuten.rms.api.itemapi20.upsertitem)<br>

#### Returns

[ResultBase](./rakuten.rms.api.json.resultbase)<br>

#### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)<br>

### **Patch(String, PatchItem)**

items.patch
 商品管理番号を指定し、商品情報の部分更新

```csharp
public ResultBase Patch(string manageNumber, PatchItem item)
```

#### Parameters

`manageNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
商品管理番号

`item` [PatchItem](./rakuten.rms.api.itemapi20.patchitem)<br>

#### Returns

[ResultBase](./rakuten.rms.api.json.resultbase)<br>

#### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)<br>

### **Delete(String)**

items.delete
 商品管理番号を指定し、商品情報を削除

```csharp
public ResultBase Delete(string manageNumber)
```

#### Parameters

`manageNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
商品管理番号

#### Returns

[ResultBase](./rakuten.rms.api.json.resultbase)<br>

#### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)<br>

### **Search(SearchCondition)**

items.search
 指定した条件から通常商品・予約商品・定期購入商品の商品情報を検索

```csharp
public SearchResult Search(SearchCondition condition)
```

#### Parameters

`condition` [SearchCondition](./rakuten.rms.api.itemapi20.searchcondition)<br>

#### Returns

[SearchResult](./rakuten.rms.api.itemapi20.searchresult)<br>

#### Exceptions

[NotImplementedException](https://docs.microsoft.com/en-us/dotnet/api/system.notimplementedexception)<br>

### **SearchAll(SearchCondition)**

Search のページングを内蔵したバージョン

```csharp
public IEnumerable<Item> SearchAll(SearchCondition condition)
```

#### Parameters

`condition` [SearchCondition](./rakuten.rms.api.itemapi20.searchcondition)<br>
検索条件

#### Returns

[IEnumerable&lt;Item&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

### **GetInventoryRelatedSettings(String)**

items.inventory-related-settings.get
 商品管理番号を指定し、納期に関する設定などを取得

```csharp
public InventoryRelatedSettings GetInventoryRelatedSettings(string manageNumber)
```

#### Parameters

`manageNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
商品管理番号

#### Returns

[InventoryRelatedSettings](./rakuten.rms.api.itemapi20.inventoryrelatedsettings)<br>

#### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)<br>

### **UpdateInventoryRelatedSettings(String, InventoryRelatedSettings)**

items.inventory-related-settings.update
 商品管理番号を指定し、納期に関する設定などを更新

```csharp
public ResultBase UpdateInventoryRelatedSettings(string manageNumber, InventoryRelatedSettings settings)
```

#### Parameters

`manageNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
商品管理番号

`settings` [InventoryRelatedSettings](./rakuten.rms.api.itemapi20.inventoryrelatedsettings)<br>

#### Returns

[ResultBase](./rakuten.rms.api.json.resultbase)<br>

#### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)<br>

[ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)<br>

---

[`< Back`](./)
