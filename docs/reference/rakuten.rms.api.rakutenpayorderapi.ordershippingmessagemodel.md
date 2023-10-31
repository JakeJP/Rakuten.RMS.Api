[`< Back`](./)

---

# OrderShippingMessageModel

Namespace: Rakuten.RMS.Api.RakutenPayOrderAPI

```csharp
public class OrderShippingMessageModel : MessageModel
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MessageModel](./rakuten.rms.api.rakutenpayorderapi.messagemodel) → [OrderShippingMessageModel](./rakuten.rms.api.rakutenpayorderapi.ordershippingmessagemodel)

## Properties

### **dataNumber**

データ番号 指定データ番号。上から１～

```csharp
public Nullable<int> dataNumber { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **shippingDetailId**

発送明細ID ・新規の場合は採番された番号 ・更新の場合は対象の番号 ※こちらは提供時期未定

```csharp
public Nullable<long> shippingDetailId { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

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

### **OrderShippingMessageModel()**

```csharp
public OrderShippingMessageModel()
```

---

[`< Back`](./)
