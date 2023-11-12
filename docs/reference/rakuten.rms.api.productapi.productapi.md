<img align="left" style="height: 2em;" src="https://webservice.rakuten.co.jp/favicon.ico"><em>Rakuten RMS WEB API client for .NET</em>

[**< クラス一覧**](./)
- - -

# ProductAPI

Namespace: Rakuten.RMS.Api.ProductAPI

```csharp
public class ProductAPI : Rakuten.RMS.Api.XML.RakutenApiXmlClientBase
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [RakutenApiClientBaseCommon](./rakuten.rms.api.rest.rakutenapiclientbasecommon) → [RakutenApiXmlClientBase](./rakuten.rms.api.xml.rakutenapixmlclientbase) → [ProductAPI](./rakuten.rms.api.productapi.productapi)

## Methods

### <a id="methods-search"/>**Search(SearchCondition)**

APIへの直接呼出し

```csharp
public SearchResponse Search(SearchCondition condition)
```

#### Parameters

`condition` [SearchCondition](./rakuten.rms.api.productapi.searchcondition)<br>

#### Returns

[SearchResponse](./rakuten.rms.api.productapi.searchresponse)

### <a id="methods-searchall"/>**SearchAll(SearchCondition)**

```csharp
public IEnumerable<Product> SearchAll(SearchCondition condition)
```

#### Parameters

`condition` [SearchCondition](./rakuten.rms.api.productapi.searchcondition)<br>

#### Returns

[IEnumerable&lt;Product&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)

### <a id="methods-searchall"/>**SearchAll(String)**

keyword だけで検索する簡易版

```csharp
public IEnumerable<Product> SearchAll(string keyword)
```

#### Parameters

`keyword` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[IEnumerable&lt;Product&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)


- - -
[**< クラス一覧**](./)
