[`< Back`](./)

---

# ItemModel

Namespace: Rakuten.RMS.Api.RakutenPayOrderAPI

```csharp
public class ItemModel
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ItemModel](./rakuten.rms.api.rakutenpayorderapi.itemmodel)

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

### **itemId**

```csharp
public int itemId { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

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

### **manageNumber**

```csharp
public string manageNumber { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **price**

```csharp
public int price { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

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

### **pointRate**

```csharp
public int pointRate { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **pointType**

```csharp
public int pointType { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **inventoryType**

```csharp
public int inventoryType { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **delvdateInfo**

```csharp
public string delvdateInfo { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **restoreInventoryFlag**

在庫連動オプション
 0: 商品の設定に従う
 1: 在庫連動する
 2: 在庫連動しない

```csharp
public int restoreInventoryFlag { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **dealFlag**

version=2

```csharp
public int dealFlag { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **drugFlag**

version=2

```csharp
public int drugFlag { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **deleteItemFlag**

商品削除フラグ
 0: 商品を削除しない
 1: 商品を削除する

```csharp
public int deleteItemFlag { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **taxRate**

商品税率

```csharp
public decimal taxRate { get; set; }
```

#### Property Value

[Decimal](https://docs.microsoft.com/en-us/dotnet/api/system.decimal)<br>

### **priceTaxIncl**

商品毎税込価格
 ・税込商品の場合：
 商品単価＝商品毎税込価格
 ・税別商品の場合：
 商品単価＝税別価格
 商品毎税込単価＝税込価格（商品単価* (1+税率））
 端数処理は、店舗設定に準ずる

```csharp
public int priceTaxIncl { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **isSingleItemShipping**

以下のいずれか
 0: 単品配送ではない
 1: 単品配送である
 ※Request Parameterの「version」に「4」以降の値を指定すると取得可能

```csharp
public int isSingleItemShipping { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **SkuModelList**

```csharp
public IList<SkuModel> SkuModelList { get; set; }
```

#### Property Value

[IList&lt;SkuModel&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

## Constructors

### **ItemModel()**

```csharp
public ItemModel()
```

---

[`< Back`](./)
