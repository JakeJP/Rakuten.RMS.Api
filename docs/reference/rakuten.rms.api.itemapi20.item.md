[`< Back`](./)

---

# Item

Namespace: Rakuten.RMS.Api.ItemAPI20

```csharp
public class Item : ItemCommon
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ItemCommon](./rakuten.rms.api.itemapi20.itemcommon) → [Item](./rakuten.rms.api.itemapi20.item)

## Properties

### **manageNumber**

商品管理番号

```csharp
public string manageNumber { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **created**

```csharp
public DateTime created { get; set; }
```

#### Property Value

[DateTime](https://docs.microsoft.com/en-us/dotnet/api/system.datetime)<br>

### **updated**

```csharp
public DateTime updated { get; set; }
```

#### Property Value

[DateTime](https://docs.microsoft.com/en-us/dotnet/api/system.datetime)<br>

### **itemNumber**

商品番号

```csharp
public string itemNumber { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **title**

商品名

```csharp
public string title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **tagline**

キャッチコピー

```csharp
public string tagline { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **productDescription**

```csharp
public ProductDescription productDescription { get; set; }
```

#### Property Value

[ProductDescription](./rakuten.rms.api.itemapi20.itemcommon.productdescription)<br>

### **salesDescription**

```csharp
public string salesDescription { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **precautions**

```csharp
public Precautions precautions { get; set; }
```

#### Property Value

[Precautions](./rakuten.rms.api.itemapi20.itemcommon.precautions)<br>

### **itemType**

```csharp
public ItemType itemType { get; set; }
```

#### Property Value

[ItemType](./rakuten.rms.api.itemapi20.itemcommon.itemtype)<br>

### **images**

```csharp
public IList<Image> images { get; set; }
```

#### Property Value

[IList&lt;Image&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

### **whiteBgImage**

```csharp
public WhiteBgImage whiteBgImage { get; set; }
```

#### Property Value

[WhiteBgImage](./rakuten.rms.api.itemapi20.itemcommon.whitebgimage)<br>

### **video**

```csharp
public Video video { get; set; }
```

#### Property Value

[Video](./rakuten.rms.api.itemapi20.itemcommon.video)<br>

### **genreId**

```csharp
public string genreId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **tags**

```csharp
public IList<long> tags { get; set; }
```

#### Property Value

[IList&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

### **hideItem**

```csharp
public bool hideItem { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **unlimitedInventoryFlag**

```csharp
public bool unlimitedInventoryFlag { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **releaseDate**

商品種別を「PRE_ORDER」に更新した場合、必須。
 フォーマットはISO 8601、タイムゾーンは日本標準時（JST）、日まで。
 定期購入商品の場合は設定不可

```csharp
public Nullable<DateTime> releaseDate { get; set; }
```

#### Property Value

[Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **purchasablePeriod**

```csharp
public Period purchasablePeriod { get; set; }
```

#### Property Value

[Period](./rakuten.rms.api.itemapi20.itemcommon.period)<br>

### **subscription**

```csharp
public Subscription subscription { get; set; }
```

#### Property Value

[Subscription](./rakuten.rms.api.itemapi20.itemcommon.subscription)<br>

### **accessControl**

```csharp
public AccessControl accessControl { get; set; }
```

#### Property Value

[AccessControl](./rakuten.rms.api.itemapi20.itemcommon.accesscontrol)<br>

### **payment**

```csharp
public Payment payment { get; set; }
```

#### Property Value

[Payment](./rakuten.rms.api.itemapi20.itemcommon.payment)<br>

### **pointCampaign**

```csharp
public PointCampaign pointCampaign { get; set; }
```

#### Property Value

[PointCampaign](./rakuten.rms.api.itemapi20.itemcommon.pointcampaign)<br>

### **itemDisplaySequence**

```csharp
public long itemDisplaySequence { get; set; }
```

#### Property Value

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>

### **layout**

```csharp
public Layout layout { get; set; }
```

#### Property Value

[Layout](./rakuten.rms.api.itemapi20.itemcommon.layout)<br>

### **variantSelectors**

```csharp
public IList<VariantSelector> variantSelectors { get; set; }
```

#### Property Value

[IList&lt;VariantSelector&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

### **variants**

```csharp
public Dictionary<string, Variant> variants { get; set; }
```

#### Property Value

[Dictionary&lt;String, Variant&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2)<br>

## Constructors

### **Item()**

```csharp
public Item()
```

---

[`< Back`](./)
