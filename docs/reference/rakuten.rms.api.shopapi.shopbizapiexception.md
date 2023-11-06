[`< Back`](./)

---

# ShopBizApiException

Namespace: Rakuten.RMS.Api.ShopAPI

```csharp
public class ShopBizApiException : Rakuten.RMS.Api.RakutenRMSApiException, System.Runtime.Serialization.ISerializable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception) → [RakutenRMSApiException](./rakuten.rms.api.rakutenrmsapiexception) → [ShopBizApiException](./rakuten.rms.api.shopapi.shopbizapiexception)<br>
Implements [ISerializable](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.serialization.iserializable)

## Properties

### **Response**

```csharp
public ShopBizApiResponse Response { get; set; }
```

#### Property Value

[ShopBizApiResponse](./rakuten.rms.api.shopapi.shopbizapiresponse)<br>

### **Error**

```csharp
public object Error { get; set; }
```

#### Property Value

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

### **TargetSite**

```csharp
public MethodBase TargetSite { get; }
```

#### Property Value

[MethodBase](https://docs.microsoft.com/en-us/dotnet/api/system.reflection.methodbase)<br>

### **Message**

```csharp
public string Message { get; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Data**

```csharp
public IDictionary Data { get; }
```

#### Property Value

[IDictionary](https://docs.microsoft.com/en-us/dotnet/api/system.collections.idictionary)<br>

### **InnerException**

```csharp
public Exception InnerException { get; }
```

#### Property Value

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **HelpLink**

```csharp
public string HelpLink { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Source**

```csharp
public string Source { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **HResult**

```csharp
public int HResult { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **StackTrace**

```csharp
public string StackTrace { get; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

## Constructors

### **ShopBizApiException(ShopBizApiResponse)**

```csharp
public ShopBizApiException(ShopBizApiResponse response)
```

#### Parameters

`response` [ShopBizApiResponse](./rakuten.rms.api.shopapi.shopbizapiresponse)<br>

---

[`< Back`](./)
