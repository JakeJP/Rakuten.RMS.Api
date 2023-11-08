[`< Back`](./)

---

# OrderSenderRequest

Namespace: Rakuten.RMS.Api.RakutenPayOrderAPI

```csharp
public class OrderSenderRequest
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [OrderSenderRequest](./rakuten.rms.api.rakutenpayorderapi.ordersenderrequest)

## Properties

### **orderNumber**

```csharp
public string orderNumber { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **reductionReason**

```csharp
public Nullable<int> reductionReason { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **taxRecalcFlag**

```csharp
public Nullable<int> taxRecalcFlag { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **WrappingModel1**

```csharp
public WrappingModel WrappingModel1 { get; set; }
```

#### Property Value

[WrappingModel](./rakuten.rms.api.rakutenpayorderapi.wrappingmodel)<br>

### **WrappingModel2**

```csharp
public WrappingModel WrappingModel2 { get; set; }
```

#### Property Value

[WrappingModel](./rakuten.rms.api.rakutenpayorderapi.wrappingmodel)<br>

### **PackageModelList**

```csharp
public IList<PackageModelToUpdate> PackageModelList { get; set; }
```

#### Property Value

[IList&lt;PackageModelToUpdate&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

### **CouponModelList**

```csharp
public IList<CouponModelBase> CouponModelList { get; set; }
```

#### Property Value

[IList&lt;CouponModelBase&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

### **afterSettlementMethodCode**

```csharp
public Nullable<int> afterSettlementMethodCode { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

## Constructors

### **OrderSenderRequest()**

```csharp
public OrderSenderRequest()
```

---

[`< Back`](./)
