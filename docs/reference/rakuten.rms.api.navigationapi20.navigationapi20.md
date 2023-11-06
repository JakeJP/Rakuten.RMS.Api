[`< Back`](./)

---

# NavigationAPI20

Namespace: Rakuten.RMS.Api.NavigationAPI20

ジャンル・商品属性情報検索API（NavigationAPI 2.0）

```csharp
public class NavigationAPI20 : Rakuten.RMS.Api.JSON.RakutenApiJsonClientBase
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [RakutenApiClientBaseCommon](./rakuten.rms.api.rest.rakutenapiclientbasecommon) → [RakutenApiJsonClientBase](./rakuten.rms.api.json.rakutenapijsonclientbase) → [NavigationAPI20](./rakuten.rms.api.navigationapi20.navigationapi20)

## Methods

### **GetVersion()**

```csharp
public Version GetVersion()
```

#### Returns

[Version](./rakuten.rms.api.navigationapi20.version)<br>

### **GetGenres(Int64, Nullable&lt;Boolean&gt;, Nullable&lt;Boolean&gt;, Nullable&lt;Boolean&gt;)**

```csharp
public GenreResult GetGenres(long genreId, Nullable<bool> showAncestors, Nullable<bool> showSiblings, Nullable<bool> showChildren)
```

#### Parameters

`genreId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>

`showAncestors` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`showSiblings` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`showChildren` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

#### Returns

[GenreResult](./rakuten.rms.api.navigationapi20.genreresult)<br>

### **GetGenreAttributes(Int64, Nullable&lt;Int64&gt;, Nullable&lt;Boolean&gt;, Nullable&lt;Boolean&gt;, Nullable&lt;Boolean&gt;)**

```csharp
public AttributeResult GetGenreAttributes(long genreId, Nullable<long> attributeId, Nullable<bool> showAncestors, Nullable<bool> showSiblings, Nullable<bool> showChildren)
```

#### Parameters

`genreId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>

`attributeId` [Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`showAncestors` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`showSiblings` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`showChildren` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

#### Returns

[AttributeResult](./rakuten.rms.api.navigationapi20.attributeresult)<br>

### **GetAttributesDictionaryValues(Int64, Int64, Nullable&lt;Boolean&gt;, Nullable&lt;Boolean&gt;, Nullable&lt;Boolean&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;)**

```csharp
public AttributeWithDictionaryResult GetAttributesDictionaryValues(long genreId, long attributeId, Nullable<bool> showAncestors, Nullable<bool> showSiblings, Nullable<bool> showChildren, Nullable<int> page, Nullable<int> limit)
```

#### Parameters

`genreId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>

`attributeId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>

`showAncestors` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`showSiblings` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`showChildren` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`page` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`limit` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

#### Returns

[AttributeWithDictionaryResult](./rakuten.rms.api.navigationapi20.attributewithdictionaryresult)<br>

---

[`< Back`](./)
