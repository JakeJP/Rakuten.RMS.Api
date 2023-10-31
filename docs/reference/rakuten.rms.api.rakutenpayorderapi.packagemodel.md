[`< Back`](./)

---

# PackageModel

Namespace: Rakuten.RMS.Api.RakutenPayOrderAPI

```csharp
public class PackageModel
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PackageModel](./rakuten.rms.api.rakutenpayorderapi.packagemodel)

## Properties

### **basketId**

送付先ID

```csharp
public int basketId { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **postagePrice**

送料

```csharp
public int postagePrice { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **deliveryPrice**

代引料

```csharp
public int deliveryPrice { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **goodsTax**

消費税

```csharp
public int goodsTax { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **goodsPrice**

商品合計金額

```csharp
public int goodsPrice { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **totalPrice**

合計金額
 送付先に紐付く 商品代金((価格×個数)の商品合計)+のし・ラッピング代+送料+消費税+代引手数料
 ※未確定の場合、-9999になります。

```csharp
public int totalPrice { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **noshi**

```csharp
public string noshi { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **packageDeleteFlag**

0: 送付先モデルを削除しない
 1: 送付先モデルを削除する

```csharp
public int packageDeleteFlag { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **SenderModel**

送付者モデル

```csharp
public SenderModel SenderModel { get; set; }
```

#### Property Value

[SenderModel](./rakuten.rms.api.rakutenpayorderapi.sendermodel)<br>

### **ItemModelList**

商品モデルリスト

```csharp
public IList<ItemModel> ItemModelList { get; set; }
```

#### Property Value

[IList&lt;ItemModel&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

### **ShippingModelList**

発送モデルリスト

```csharp
public IList<ShippingModel> ShippingModelList { get; set; }
```

#### Property Value

[IList&lt;ShippingModel&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

### **DeliveryCvsModel**

コンビニ配送モデル 
 配送方法がコンビニ、郵便局受取の場合、参照可能

```csharp
public DeliveryCVSModel DeliveryCvsModel { get; set; }
```

#### Property Value

[DeliveryCVSModel](./rakuten.rms.api.rakutenpayorderapi.deliverycvsmodel)<br>

## Constructors

### **PackageModel()**

```csharp
public PackageModel()
```

---

[`< Back`](./)
