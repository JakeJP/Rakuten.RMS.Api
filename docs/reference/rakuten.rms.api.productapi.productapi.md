[`< Back`](./)

---

# ProductAPI

Namespace: Rakuten.RMS.Api.ProductAPI

```csharp
public class ProductAPI : Rakuten.RMS.Api.XML.RakutenApiXmlClientBase
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [RakutenApiXmlClientBase](./rakuten.rms.api.xml.rakutenapixmlclientbase) → [ProductAPI](./rakuten.rms.api.productapi.productapi)

## Methods

### **Search(String, String, String, String, Nullable&lt;DateTime&gt;, Nullable&lt;DateTime&gt;, String, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;)**

```csharp
public SearchResponse Search(string productId, string keyword, string genreId, string makerName, Nullable<DateTime> releaseDateFrom, Nullable<DateTime> releaseDataTo, string sortBy, Nullable<int> offset, Nullable<int> limit)
```

#### Parameters

`productId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`keyword` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`genreId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`makerName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`releaseDateFrom` [Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`releaseDataTo` [Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`sortBy` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`offset` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`limit` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

#### Returns

[SearchResponse](./rakuten.rms.api.productapi.productapi.searchresponse)<br>

---

[`< Back`](./)
