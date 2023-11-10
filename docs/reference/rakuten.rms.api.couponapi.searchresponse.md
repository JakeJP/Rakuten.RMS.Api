[`< Back`](./)

---

# SearchResponse

Namespace: Rakuten.RMS.Api.CouponAPI

```csharp
public class SearchResponse : ResultContainer`1
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ResultBase](./rakuten.rms.api.xml.resultbase) → [ResultWithErrorsBase](./rakuten.rms.api.couponapi.resultwitherrorsbase) → [ResultContainer&lt;SearchedCoupons&gt;](./rakuten.rms.api.couponapi.resultcontainer-1) → [SearchResponse](./rakuten.rms.api.couponapi.searchresponse)

## Properties

### **allCount**

```csharp
public int allCount { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **Content**

```csharp
public SearchedCoupons Content { get; set; }
```

#### Property Value

[SearchedCoupons](./rakuten.rms.api.couponapi.searchedcoupons)<br>

### **Errors**

```csharp
public List<Error> Errors { get; set; }
```

#### Property Value

[List&lt;Error&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>

### **Status**

```csharp
public XmlStatus Status { get; set; }
```

#### Property Value

[XmlStatus](./rakuten.rms.api.xml.xmlstatus)<br>

## Constructors

### **SearchResponse()**

```csharp
public SearchResponse()
```

---

[`< Back`](./)
