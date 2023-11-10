[`< Back`](./)

---

# SearchThanksCouponResponse

Namespace: Rakuten.RMS.Api.CouponAPI

```csharp
public class SearchThanksCouponResponse : ResultContainer`1
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ResultBase](./rakuten.rms.api.xml.resultbase) → [ResultWithErrorsBase](./rakuten.rms.api.couponapi.resultwitherrorsbase) → [ResultContainer&lt;SearchedThanksCoupons&gt;](./rakuten.rms.api.couponapi.resultcontainer-1) → [SearchThanksCouponResponse](./rakuten.rms.api.couponapi.searchthankscouponresponse)

## Properties

### **allCount**

```csharp
public int allCount { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **Content**

```csharp
public SearchedThanksCoupons Content { get; set; }
```

#### Property Value

[SearchedThanksCoupons](./rakuten.rms.api.couponapi.searchedthankscoupons)<br>

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

### **SearchThanksCouponResponse()**

```csharp
public SearchThanksCouponResponse()
```

---

[`< Back`](./)
