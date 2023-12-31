<img align="left" style="height: 2em;" src="https://webservice.rakuten.co.jp/favicon.ico"><em>Rakuten RMS WEB API client for .NET</em>

[**< クラス一覧**](./)
- - -

# CategoryAPI20

Namespace: Rakuten.RMS.Api.CategoryAPI20

カテゴリ情報を取得し、更新

```csharp
public class CategoryAPI20 : Rakuten.RMS.Api.JSON.RakutenApiJsonClientBase
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [RakutenApiClientBaseCommon](./rakuten.rms.api.rest.rakutenapiclientbasecommon) → [RakutenApiJsonClientBase](./rakuten.rms.api.json.rakutenapijsonclientbase) → [CategoryAPI20](./rakuten.rms.api.categoryapi20.categoryapi20)

## Methods

### <a id="methods-createcategory"/>**CreateCategory(NewCategory)**

```csharp
public string CreateCategory(NewCategory category)
```

#### Parameters

`category` [NewCategory](./rakuten.rms.api.categoryapi20.newcategory)<br>

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

### <a id="methods-deleteitemmappings"/>**DeleteItemMappings(String)**

指定した商品管理番号を表示先カテゴリから削除

```csharp
public void DeleteItemMappings(string manageNumber)
```

#### Parameters

`manageNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Exceptions

[NotImplementedException](https://docs.microsoft.com/en-us/dotnet/api/system.notimplementedexception)<br>

### <a id="methods-getallcategoryset"/>**GetAllCategorySet()**

```csharp
public IList<CategorySet> GetAllCategorySet()
```

#### Returns

[IList&lt;CategorySet&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)

### <a id="methods-getcategory"/>**GetCategory(String, Boolean)**

```csharp
public Category GetCategory(string categoryId, bool breadcrumb)
```

#### Parameters

`categoryId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`breadcrumb` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

#### Returns

[Category](./rakuten.rms.api.categoryapi20.category)

### <a id="methods-getcategoryset"/>**GetCategorySet(String)**

```csharp
public CategorySet GetCategorySet(string categorySetId)
```

#### Parameters

`categorySetId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[CategorySet](./rakuten.rms.api.categoryapi20.categoryset)

### <a id="methods-getcategorysetidlist"/>**GetCategorySetIdList()**

すべてのカテゴリセット情報を取得

```csharp
public IList<String> GetCategorySetIdList()
```

#### Returns

[IList&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)

### <a id="methods-getcategorysetlist"/>**GetCategorySetList(params CategorySetField[])**

すべてのカテゴリセット情報を取得.取得したいカテゴリセット情報を指定する場合。

```csharp
public IList<CategorySet> GetCategorySetList(params CategorySetField[] categorysetfields)
```

#### Parameters

`categorysetfields` [CategorySetField[]](./rakuten.rms.api.categoryapi20.categorysetfield)<br>

#### Returns

[IList&lt;CategorySet&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)

#### Exceptions

[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)<br>

### <a id="methods-getcategorytree"/>**GetCategoryTree(String)**

```csharp
public CategoryTree GetCategoryTree(string categorySetId)
```

#### Parameters

`categorySetId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[CategoryTree](./rakuten.rms.api.categoryapi20.categorytree)

### <a id="methods-getcategorytrees"/>**GetCategoryTrees(String, CategorySetField[], CategoryField[])**

カテゴリセットIDを指定しカテゴリツリー情報を取得

```csharp
public CategoryTreeResult GetCategoryTrees(string categorySetId, CategorySetField[] categorysetfields, CategoryField[] categoryfields)
```

#### Parameters

`categorySetId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
カテゴリセットID カテゴリセットを利用していない場合、「0」を指定。

`categorysetfields` [CategorySetField[]](./rakuten.rms.api.categoryapi20.categorysetfield)<br>
カテゴリセットフィールド

`categoryfields` [CategoryField[]](./rakuten.rms.api.categoryapi20.categoryfield)<br>
カテゴリフィールド

#### Returns

[CategoryTreeResult](./rakuten.rms.api.categoryapi20.categorytreeresult)

### <a id="methods-getitemmappings"/>**GetItemMappings(String, CategorySetField[], CategoryField[])**

商品管理番号を指定し、カテゴリとの紐付き情報を取得

```csharp
public GetItemMappingResponse GetItemMappings(string manageNumber, CategorySetField[] categorysetfields, CategoryField[] categoryfields)
```

#### Parameters

`manageNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
商品管理番号

`categorysetfields` [CategorySetField[]](./rakuten.rms.api.categoryapi20.categorysetfield)<br>
カテゴリセットフィールド

`categoryfields` [CategoryField[]](./rakuten.rms.api.categoryapi20.categoryfield)<br>
カテゴリフィールド

#### Returns

[GetItemMappingResponse](./rakuten.rms.api.categoryapi20.getitemmappingresponse)

### <a id="methods-getitemmappingswithbreadcrumbs"/>**GetItemMappingsWithBreadcrumbs(String, CategorySetField[], CategoryField[])**

```csharp
public GetItemMappingWithBreadcrumbResponse GetItemMappingsWithBreadcrumbs(string manageNumber, CategorySetField[] categorysetfields, CategoryField[] categoryfields)
```

#### Parameters

`manageNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`categorysetfields` [CategorySetField[]](./rakuten.rms.api.categoryapi20.categorysetfield)<br>

`categoryfields` [CategoryField[]](./rakuten.rms.api.categoryapi20.categoryfield)<br>

#### Returns

[GetItemMappingWithBreadcrumbResponse](./rakuten.rms.api.categoryapi20.getitemmappingwithbreadcrumbresponse)

### <a id="methods-getshopcategories"/>**GetShopCategories(String, Nullable&lt;Boolean&gt;, CategorySetField[], CategoryField[])**

カテゴリ情報を取得し、更新

```csharp
public CategoryWithBreadcrumbs GetShopCategories(string categoryId, Nullable<Boolean> breadcrumb, CategorySetField[] categorysetfields, CategoryField[] categoryfields)
```

#### Parameters

`categoryId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
カテゴリID

`breadcrumb` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
true：指定したカテゴリと、パンくずでつながった全ての上位カテゴリ情報 false：指定したカテゴリ情報のみ（デフォルト）

`categorysetfields` [CategorySetField[]](./rakuten.rms.api.categoryapi20.categorysetfield)<br>
カテゴリセットフィールド
 レスポンスの”breadcrumbs“内の以下のカテゴリセット情報を取得したい場合は指定。

`categoryfields` [CategoryField[]](./rakuten.rms.api.categoryapi20.categoryfield)<br>
カテゴリフィールド
 レスポンスの”breadcrumbs“内の以下のカテゴリ情報を取得したい場合は指定。

#### Returns

[CategoryWithBreadcrumbs](./rakuten.rms.api.categoryapi20.categorywithbreadcrumbs)

### <a id="methods-insertshopcategory"/>**InsertShopCategory(NewCategory)**

カテゴリ情報を登録

```csharp
public string InsertShopCategory(NewCategory category)
```

#### Parameters

`category` [NewCategory](./rakuten.rms.api.categoryapi20.newcategory)<br>

#### Returns

カテゴリID

### <a id="methods-updatecategory"/>**UpdateCategory(String, NewCategory)**

```csharp
public void UpdateCategory(string categoryId, NewCategory category)
```

#### Parameters

`categoryId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`category` [NewCategory](./rakuten.rms.api.categoryapi20.newcategory)<br>

### <a id="methods-updatecategorytree"/>**UpdateCategoryTree(String, IList&lt;CategoryIdWithChildren&gt;)**

```csharp
public void UpdateCategoryTree(string categorySetId, IList<CategoryIdWithChildren> tree)
```

#### Parameters

`categorySetId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`tree` [IList&lt;CategoryIdWithChildren&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

### <a id="methods-updateshopcategory"/>**UpdateShopCategory(String, NewCategory)**

カテゴリIDを指定しカテゴリ情報を更新

```csharp
public ResultBase UpdateShopCategory(string categoryId, NewCategory category)
```

#### Parameters

`categoryId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
カテゴリID

`category` [NewCategory](./rakuten.rms.api.categoryapi20.newcategory)<br>

#### Returns

[ResultBase](./rakuten.rms.api.json.resultbase)

### <a id="methods-upsertcategorytree"/>**UpsertCategoryTree(String, IList&lt;CategoryIdWithChildren&gt;)**

```csharp
public void UpsertCategoryTree(string categorySetId, IList<CategoryIdWithChildren> tree)
```

#### Parameters

`categorySetId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`tree` [IList&lt;CategoryIdWithChildren&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

### <a id="methods-upsertitemmappings"/>**UpsertItemMappings(String, IList&lt;String&gt;, String)**

指定した商品管理番号の表示先カテゴリの登録や変更
 複数カテゴリへのマッピング時

```csharp
public void UpsertItemMappings(string manageNumber, IList<String> categoryIds, string mainPluralCategoryId)
```

#### Parameters

`manageNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`categoryIds` [IList&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

`mainPluralCategoryId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Exceptions

[NotImplementedException](https://docs.microsoft.com/en-us/dotnet/api/system.notimplementedexception)<br>

### <a id="methods-upsertitemmappings"/>**UpsertItemMappings(String, String)**

1カテゴリ - 1商品 モードの時の呼び出し。

```csharp
public void UpsertItemMappings(string manageNumber, string categoryId)
```

#### Parameters

`manageNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`categoryId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>


- - -
[**< クラス一覧**](./)
