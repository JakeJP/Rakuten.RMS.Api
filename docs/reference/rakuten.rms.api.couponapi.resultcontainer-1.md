[`< Back`](./)

---

# ResultContainer&lt;TResponseBody&gt;

Namespace: Rakuten.RMS.Api.CouponAPI

```csharp
public class ResultContainer<TResponseBody> : ResultWithErrorsBase
```

#### Type Parameters

`TResponseBody`<br>

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ResultBase](./rakuten.rms.api.xml.resultbase) → [ResultWithErrorsBase](./rakuten.rms.api.couponapi.resultwitherrorsbase) → [ResultContainer&lt;TResponseBody&gt;](./rakuten.rms.api.couponapi.resultcontainer-1)

## Properties

### **Content**

```csharp
public TResponseBody Content { get; set; }
```

#### Property Value

TResponseBody<br>

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

### **ResultContainer(TResponseBody)**

```csharp
public ResultContainer(TResponseBody responseBody)
```

#### Parameters

`responseBody` TResponseBody<br>

---

[`< Back`](./)
