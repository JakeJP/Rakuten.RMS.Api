[`< Back`](./)

---

# ItemModelToUpdate

Namespace: Rakuten.RMS.Api.RakutenPayOrderAPI

```csharp
public class ItemModelToUpdate
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ItemModelToUpdate](./rakuten.rms.api.rakutenpayorderapi.itemmodeltoupdate)

## Properties

### **itemDetailId**

```csharp
public int itemDetailId { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **itemName**

```csharp
public string itemName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **itemNumber**

商品番号
 項目選択肢別在庫が指定された商品の場合、以下のルールで値が表示されます
 SKU移行前注文：商品番号（店舗様が登録した番号）＋項目選択肢ID（横軸）＋項目選択肢ID（縦軸）
 SKU移行後注文：商品番号（店舗様が登録した番号）

```csharp
public string itemNumber { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **price**

```csharp
public int price { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **taxRate**

商品税率
 以下のいずれか
 ・0・0.0・0.08・0.1

```csharp
public decimal taxRate { get; set; }
```

#### Property Value

[Decimal](https://docs.microsoft.com/en-us/dotnet/api/system.decimal)<br>

### **units**

```csharp
public int units { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **includePostageFlag**

```csharp
public int includePostageFlag { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **includeTaxFlag**

0: 税別
 1: 税込み

```csharp
public int includeTaxFlag { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **includeCashOnDeliveryPostageFlag**

0: 代引手数料別
 1: 代引手数料込み

```csharp
public int includeCashOnDeliveryPostageFlag { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **selectedChoice**

```csharp
public string selectedChoice { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **restoreInventoryFlag**

```csharp
public Nullable<int> restoreInventoryFlag { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **deleteItemFlag**

```csharp
public Nullable<int> deleteItemFlag { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **SkuModelList**

```csharp
public IList<SkuModel> SkuModelList { get; set; }
```

#### Property Value

[IList&lt;SkuModel&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

## Constructors

### **ItemModelToUpdate()**

```csharp
public ItemModelToUpdate()
```

---

[`< Back`](./)
