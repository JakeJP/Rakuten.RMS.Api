<img align="left" style="height: 2em;" src="https://webservice.rakuten.co.jp/favicon.ico"><em>Rakuten RMS WEB API client for .NET</em>

[**< クラス一覧**](./)
- - -

# AuthorizationResultModel

Namespace: Rakuten.RMS.Api.SystemEventNotification

審査結果通知 5000:1100

```csharp
public class AuthorizationResultModel : NotifyInfoModel
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [NotifyInfoModel](./rakuten.rms.api.systemeventnotification.notifyinfomodel) → [AuthorizationResultModel](./rakuten.rms.api.systemeventnotification.authorizationresultmodel)

## Properties

### <a id="properties-functionid"/>**FunctionId**

```csharp
public int FunctionId { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### <a id="properties-notificationtype"/>**NotificationType**

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

### <a id="properties-occurrencedatetime"/>**OccurrenceDatetime**

```csharp
public DateTime OccurrenceDatetime { get; }
```

#### Property Value

[DateTime](https://docs.microsoft.com/en-us/dotnet/api/system.datetime)<br>

### <a id="properties-ordernumber"/>**OrderNumber**

```csharp
public string OrderNumber { get; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-requestid"/>**RequestId**

```csharp
public string RequestId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-serviceid"/>**ServiceId**

```csharp
public int ServiceId { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### <a id="properties-value1"/>**Value1**

```csharp
public ValueElement Value1 { get; set; }
```

#### Property Value

[ValueElement](./rakuten.rms.api.systemeventnotification.valueelement)<br>

### <a id="properties-value10"/>**Value10**

```csharp
public ValueElement Value10 { get; set; }
```

#### Property Value

[ValueElement](./rakuten.rms.api.systemeventnotification.valueelement)<br>

### <a id="properties-value2"/>**Value2**

```csharp
public ValueElement Value2 { get; set; }
```

#### Property Value

[ValueElement](./rakuten.rms.api.systemeventnotification.valueelement)<br>

### <a id="properties-value3"/>**Value3**

```csharp
public ValueElement Value3 { get; set; }
```

#### Property Value

[ValueElement](./rakuten.rms.api.systemeventnotification.valueelement)<br>

### <a id="properties-value4"/>**Value4**

```csharp
public ValueElement Value4 { get; set; }
```

#### Property Value

[ValueElement](./rakuten.rms.api.systemeventnotification.valueelement)<br>

### <a id="properties-value5"/>**Value5**

```csharp
public ValueElement Value5 { get; set; }
```

#### Property Value

[ValueElement](./rakuten.rms.api.systemeventnotification.valueelement)<br>

### <a id="properties-value6"/>**Value6**

```csharp
public ValueElement Value6 { get; set; }
```

#### Property Value

[ValueElement](./rakuten.rms.api.systemeventnotification.valueelement)<br>

### <a id="properties-value7"/>**Value7**

```csharp
public ValueElement Value7 { get; set; }
```

#### Property Value

[ValueElement](./rakuten.rms.api.systemeventnotification.valueelement)<br>

### <a id="properties-value8"/>**Value8**

```csharp
public ValueElement Value8 { get; set; }
```

#### Property Value

[ValueElement](./rakuten.rms.api.systemeventnotification.valueelement)<br>

### <a id="properties-value9"/>**Value9**

```csharp
public ValueElement Value9 { get; set; }
```

#### Property Value

[ValueElement](./rakuten.rms.api.systemeventnotification.valueelement)<br>

## Constructors

### <a id="constructors-.ctor"/>**AuthorizationResultModel(NotifyInfoModel)**

```csharp
public AuthorizationResultModel(NotifyInfoModel model)
```

#### Parameters

`model` [NotifyInfoModel](./rakuten.rms.api.systemeventnotification.notifyinfomodel)<br>


- - -
[**< クラス一覧**](./)
