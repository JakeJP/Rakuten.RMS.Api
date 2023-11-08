[`< Back`](./)

---

# CouponModel

Namespace: Rakuten.RMS.Api.RakutenPayOrderAPI

```csharp
public class CouponModel : CouponModelBase
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [CouponModelBase](./rakuten.rms.api.rakutenpayorderapi.couponmodelbase) → [CouponModel](./rakuten.rms.api.rakutenpayorderapi.couponmodel)

## Properties

### **couponName**

```csharp
public string couponName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **couponSummary**

```csharp
public string couponSummary { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **couponCapital**

```csharp
public string couponCapital { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **expiryDate**

```csharp
public DateTime expiryDate { get; set; }
```

#### Property Value

[DateTime](https://docs.microsoft.com/en-us/dotnet/api/system.datetime)<br>

### **couponTotalPrice**

クーポン利用金額
 クーポン割引単価 × クーポン利用数
 ※クーポン割引単価もしくはクーポン利用数がnullの場合、-9999になります。

```csharp
public int couponTotalPrice { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **itemDetailId**

商品明細ID

```csharp
public long itemDetailId { get; set; }
```

#### Property Value

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>

### **couponCode**

```csharp
public string couponCode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **itemId**

```csharp
public int itemId { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **couponPrice**

```csharp
public int couponPrice { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **couponUnit**

```csharp
public int couponUnit { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

## Constructors

### **CouponModel()**

```csharp
public CouponModel()
```

---

[`< Back`](./)
