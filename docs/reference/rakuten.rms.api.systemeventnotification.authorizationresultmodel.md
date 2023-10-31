[`< Back`](./)

---

# AuthorizationResultModel

Namespace: Rakuten.RMS.Api.SystemEventNotification

審査結果通知 5000:1100

```csharp
public class AuthorizationResultModel : NotifyInfoModel
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [NotifyInfoModel](./rakuten.rms.api.systemeventnotification.notifyinfomodel) → [AuthorizationResultModel](./rakuten.rms.api.systemeventnotification.authorizationresultmodel)

## Properties

### **OrderNumber**

```csharp
public string OrderNumber { get; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **NotificationType**

1：発送指示
 2：楽天側キャンセル※1
 3：発送指示取消※2
 ※1 楽天側で注文がキャンセルされた後、通知が配信されます。
 ※2 予約注文確定時の再オーソリ処理においてNGとなった場合などに、この通知が配信されます

```csharp
public int NotificationType { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **OccurrenceDatetime**

```csharp
public DateTime OccurrenceDatetime { get; }
```

#### Property Value

[DateTime](https://docs.microsoft.com/en-us/dotnet/api/system.datetime)<br>

### **RequestId**

```csharp
public string RequestId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ServiceId**

```csharp
public int ServiceId { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **FunctionId**

```csharp
public int FunctionId { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **Value1**

```csharp
public ValueElement Value1 { get; set; }
```

#### Property Value

[ValueElement](./rakuten.rms.api.systemeventnotification.valueelement)<br>

### **Value2**

```csharp
public ValueElement Value2 { get; set; }
```

#### Property Value

[ValueElement](./rakuten.rms.api.systemeventnotification.valueelement)<br>

### **Value3**

```csharp
public ValueElement Value3 { get; set; }
```

#### Property Value

[ValueElement](./rakuten.rms.api.systemeventnotification.valueelement)<br>

### **Value4**

```csharp
public ValueElement Value4 { get; set; }
```

#### Property Value

[ValueElement](./rakuten.rms.api.systemeventnotification.valueelement)<br>

### **Value5**

```csharp
public ValueElement Value5 { get; set; }
```

#### Property Value

[ValueElement](./rakuten.rms.api.systemeventnotification.valueelement)<br>

### **Value6**

```csharp
public ValueElement Value6 { get; set; }
```

#### Property Value

[ValueElement](./rakuten.rms.api.systemeventnotification.valueelement)<br>

### **Value7**

```csharp
public ValueElement Value7 { get; set; }
```

#### Property Value

[ValueElement](./rakuten.rms.api.systemeventnotification.valueelement)<br>

### **Value8**

```csharp
public ValueElement Value8 { get; set; }
```

#### Property Value

[ValueElement](./rakuten.rms.api.systemeventnotification.valueelement)<br>

### **Value9**

```csharp
public ValueElement Value9 { get; set; }
```

#### Property Value

[ValueElement](./rakuten.rms.api.systemeventnotification.valueelement)<br>

### **Value10**

```csharp
public ValueElement Value10 { get; set; }
```

#### Property Value

[ValueElement](./rakuten.rms.api.systemeventnotification.valueelement)<br>

## Constructors

### **AuthorizationResultModel(NotifyInfoModel)**

```csharp
public AuthorizationResultModel(NotifyInfoModel model)
```

#### Parameters

`model` [NotifyInfoModel](./rakuten.rms.api.systemeventnotification.notifyinfomodel)<br>

---

[`< Back`](./)
