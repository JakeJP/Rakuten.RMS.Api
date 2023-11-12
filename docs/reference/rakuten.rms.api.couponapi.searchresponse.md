<img align="left" style="height: 2em;" src="https://webservice.rakuten.co.jp/favicon.ico"><em>Rakuten RMS WEB API client for .NET</em>

[**< クラス一覧**](./)
- - -

# SearchResponse

Namespace: Rakuten.RMS.Api.CouponAPI

```csharp
public class SearchResponse : ResultContainer<SearchedCoupons>
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ResultBase](./rakuten.rms.api.xml.resultbase) → [ResultWithErrorsBase](./rakuten.rms.api.couponapi.resultwitherrorsbase) → [ResultContainer&lt;SearchedCoupons&gt;](./rakuten.rms.api.couponapi.resultcontainer-1) → [SearchResponse](./rakuten.rms.api.couponapi.searchresponse)

## Properties

### <a id="properties-allcount"/>**allCount**

```csharp
public int allCount { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### <a id="properties-content"/>**Content**

```csharp
public SearchedCoupons Content { get; set; }
```

#### Property Value

[SearchedCoupons](./rakuten.rms.api.couponapi.searchedcoupons)<br>

### <a id="properties-errors"/>**Errors**

```csharp
public List<Error> Errors { get; set; }
```

#### Property Value

[List&lt;Error&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>

### <a id="properties-status"/>**Status**

```csharp
public XmlStatus Status { get; set; }
```

#### Property Value

[XmlStatus](./rakuten.rms.api.xml.xmlstatus)<br>

## Constructors

### <a id="constructors-.ctor"/>**SearchResponse()**

```csharp
public SearchResponse()
```


- - -
[**< クラス一覧**](./)
