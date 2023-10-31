[`< Back`](./)

---

# PurchaseHistoryChangeNotifyModel

Namespace: Rakuten.RMS.Api.SystemEventNotification

購入履歴変更通知 4000:1100

```csharp
public class PurchaseHistoryChangeNotifyModel : NotifyInfoModel
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [NotifyInfoModel](./rakuten.rms.api.systemeventnotification.notifyinfomodel) → [PurchaseHistoryChangeNotifyModel](./rakuten.rms.api.systemeventnotification.purchasehistorychangenotifymodel)

## Properties

### **Operation**

```csharp
public string Operation { get; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **OrderNumber**

```csharp
public string OrderNumber { get; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Subkey**

```csharp
public string Subkey { get; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Class**

```csharp
public string Class { get; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Field**

```csharp
public string Field { get; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Before**

```csharp
public string Before { get; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **After**

```csharp
public string After { get; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **OrderType**

1 : 通常購入
 4 : 定期購入
 5 : 頒布会
 6 : 予約

```csharp
public int OrderType { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **OrderDate**

```csharp
public DateTime OrderDate { get; }
```

#### Property Value

[DateTime](https://docs.microsoft.com/en-us/dotnet/api/system.datetime)<br>

### **Timestamp**

```csharp
public DateTime Timestamp { get; }
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

### **PurchaseHistoryChangeNotifyModel(NotifyInfoModel)**

```csharp
public PurchaseHistoryChangeNotifyModel(NotifyInfoModel model)
```

#### Parameters

`model` [NotifyInfoModel](./rakuten.rms.api.systemeventnotification.notifyinfomodel)<br>

---

[`< Back`](./)
