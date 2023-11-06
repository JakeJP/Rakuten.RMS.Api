[`< Back`](./)

---

# ProductAPI

Namespace: Rakuten.RMS.Api.ProductAPI

```csharp
public class ProductAPI : Rakuten.RMS.Api.XML.RakutenApiXmlClientBase
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [RakutenApiClientBaseCommon](./rakuten.rms.api.rest.rakutenapiclientbasecommon) → [RakutenApiXmlClientBase](./rakuten.rms.api.xml.rakutenapixmlclientbase) → [ProductAPI](./rakuten.rms.api.productapi.productapi)

## Methods

### **SearchAll(SearchCondition)**

```csharp
public IEnumerable<Product> SearchAll(SearchCondition condition)
```

#### Parameters

`condition` [SearchCondition](./rakuten.rms.api.productapi.searchcondition)<br>

#### Returns

[IEnumerable&lt;Product&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

### **SearchAll(String)**

keyword だけで検索する簡易版

```csharp
public IEnumerable<Product> SearchAll(string keyword)
```

#### Parameters

`keyword` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[IEnumerable&lt;Product&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

### **Search(SearchCondition)**

APIへの直接呼出し

```csharp
public SearchResponse Search(SearchCondition condition)
```

#### Parameters

`condition` [SearchCondition](./rakuten.rms.api.productapi.searchcondition)<br>

#### Returns

[SearchResponse](./rakuten.rms.api.productapi.searchresponse)<br>

---

[`< Back`](./)
