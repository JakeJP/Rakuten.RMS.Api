<img align="left" style="height: 2em;" src="https://webservice.rakuten.co.jp/favicon.ico"><em>Rakuten RMS WEB API client for .NET</em>

[**< クラス一覧**](./)
- - -

# NavigationAPI20

Namespace: Rakuten.RMS.Api.NavigationAPI20

ジャンル・商品属性情報検索API（NavigationAPI 2.0）

```csharp
public class NavigationAPI20 : Rakuten.RMS.Api.JSON.RakutenApiJsonClientBase
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [RakutenApiClientBaseCommon](./rakuten.rms.api.rest.rakutenapiclientbasecommon) → [RakutenApiJsonClientBase](./rakuten.rms.api.json.rakutenapijsonclientbase) → [NavigationAPI20](./rakuten.rms.api.navigationapi20.navigationapi20)

## Methods

### <a id="methods-getattributesdictionaryvalues"/>**GetAttributesDictionaryValues(Int64, Int64, Nullable&lt;Boolean&gt;, Nullable&lt;Boolean&gt;, Nullable&lt;Boolean&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;)**

```csharp
public AttributeWithDictionaryResult GetAttributesDictionaryValues(long genreId, long attributeId, Nullable<Boolean> showAncestors, Nullable<Boolean> showSiblings, Nullable<Boolean> showChildren, Nullable<Int32> page, Nullable<Int32> limit)
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

[AttributeWithDictionaryResult](./rakuten.rms.api.navigationapi20.attributewithdictionaryresult)

### <a id="methods-getgenreattributes"/>**GetGenreAttributes(Int64, Nullable&lt;Int64&gt;, Nullable&lt;Boolean&gt;, Nullable&lt;Boolean&gt;, Nullable&lt;Boolean&gt;)**

```csharp
public AttributeResult GetGenreAttributes(long genreId, Nullable<Int64> attributeId, Nullable<Boolean> showAncestors, Nullable<Boolean> showSiblings, Nullable<Boolean> showChildren)
```

#### Parameters

`genreId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>

`attributeId` [Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`showAncestors` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`showSiblings` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`showChildren` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

#### Returns

[AttributeResult](./rakuten.rms.api.navigationapi20.attributeresult)

### <a id="methods-getgenres"/>**GetGenres(Int64, Nullable&lt;Boolean&gt;, Nullable&lt;Boolean&gt;, Nullable&lt;Boolean&gt;)**

```csharp
public GenreResult GetGenres(long genreId, Nullable<Boolean> showAncestors, Nullable<Boolean> showSiblings, Nullable<Boolean> showChildren)
```

#### Parameters

`genreId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>

`showAncestors` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`showSiblings` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`showChildren` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

#### Returns

[GenreResult](./rakuten.rms.api.navigationapi20.genreresult)

### <a id="methods-getversion"/>**GetVersion()**

```csharp
public Version GetVersion()
```

#### Returns

[Version](./rakuten.rms.api.navigationapi20.version)


- - -
[**< クラス一覧**](./)
