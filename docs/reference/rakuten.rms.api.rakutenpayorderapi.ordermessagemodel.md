[`< Back`](./)

---

# OrderMessageModel

Namespace: Rakuten.RMS.Api.RakutenPayOrderAPI

```csharp
public class OrderMessageModel : MessageModel
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MessageModel](./rakuten.rms.api.rakutenpayorderapi.messagemodel) → [OrderMessageModel](./rakuten.rms.api.rakutenpayorderapi.ordermessagemodel)

## Properties

### **orderNumber**

```csharp
public string orderNumber { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **messageType**

・INFO
 ・ERROR
 ・WARNING

```csharp
public string messageType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **messageCode**

https://webservice.rms.rakuten.co.jp/merchant-portal/view?contents=/ja/common/1-1_service_index/rakutenpayorderapi/rakutenpaymsgcodereference

```csharp
public string messageCode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **message**

```csharp
public string message { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

## Constructors

### **OrderMessageModel()**

```csharp
public OrderMessageModel()
```

---

[`< Back`](./)
