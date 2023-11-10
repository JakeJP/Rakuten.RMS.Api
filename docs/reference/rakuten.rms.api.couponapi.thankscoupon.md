[`< Back`](./)

---

# ThanksCoupon

Namespace: Rakuten.RMS.Api.CouponAPI

```csharp
public class ThanksCoupon : ThanksCouponToIssue
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ThanksCouponToIssue](./rakuten.rms.api.couponapi.thankscoupontoissue) → [ThanksCoupon](./rakuten.rms.api.couponapi.thankscoupon)

## Properties

### **thanksCouponId**

```csharp
public long thanksCouponId { get; set; }
```

#### Property Value

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>

### **shopId**

```csharp
public string shopId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **shopName**

```csharp
public string shopName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **shopUrl**

```csharp
public string shopUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **couponImage**

```csharp
public string couponImage { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **couponName**

```csharp
public string couponName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **couponCaption**

```csharp
public string couponCaption { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **discountType**

1： 定額値引き
 2： 定率値引き
 4： 送料無料

```csharp
public int discountType { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **discountFactor**

```csharp
public int discountFactor { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **couponUnavailableTerm**

```csharp
public int couponUnavailableTerm { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **couponTerm**

```csharp
public int couponTerm { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **memberAvailMaxCount**

```csharp
public int memberAvailMaxCount { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **combineFlag**

```csharp
public int combineFlag { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **thanksOtherConditions**

```csharp
public List<ThanksOtherCondition> thanksOtherConditions { get; set; }
```

#### Property Value

[List&lt;ThanksOtherCondition&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>

### **thanksAutoGetConditions**

```csharp
public List<ThanksAutoGetCondition> thanksAutoGetConditions { get; set; }
```

#### Property Value

[List&lt;ThanksAutoGetCondition&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>

## Constructors

### **ThanksCoupon()**

```csharp
public ThanksCoupon()
```

---

[`< Back`](./)
