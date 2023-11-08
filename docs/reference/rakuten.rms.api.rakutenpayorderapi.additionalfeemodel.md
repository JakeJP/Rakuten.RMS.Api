[`< Back`](./)

---

# AdditionalFeeModel

Namespace: Rakuten.RMS.Api.RakutenPayOrderAPI

```csharp
public class AdditionalFeeModel
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [AdditionalFeeModel](./rakuten.rms.api.rakutenpayorderapi.additionalfeemodel)

## Properties

### **additionalFeeType**

負担金科目 
 1: 後払い手数料 2: チャージバック手数料

```csharp
public int additionalFeeType { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **payFrom**

負担者
 1: 注文者
 2: 店舗

```csharp
public int payFrom { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **additionalFeeOccurDatetime**

負担金発生日時

```csharp
public Nullable<DateTime> additionalFeeOccurDatetime { get; set; }
```

#### Property Value

[Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **additionalFeeOccurAmount**

負担金

```csharp
public int additionalFeeOccurAmount { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **additionalFeeTaxRate**

負担金税率

```csharp
public decimal additionalFeeTaxRate { get; set; }
```

#### Property Value

[Decimal](https://docs.microsoft.com/en-us/dotnet/api/system.decimal)<br>

## Constructors

### **AdditionalFeeModel()**

```csharp
public AdditionalFeeModel()
```

---

[`< Back`](./)
