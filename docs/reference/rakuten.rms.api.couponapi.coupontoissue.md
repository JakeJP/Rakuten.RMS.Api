[`< Back`](./)

---

# CouponToIssue

Namespace: Rakuten.RMS.Api.CouponAPI

```csharp
public class CouponToIssue
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [CouponToIssue](./rakuten.rms.api.couponapi.coupontoissue)

## Properties

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

### **couponStartDate**

```csharp
public DateTime couponStartDate { get; set; }
```

#### Property Value

[DateTime](https://docs.microsoft.com/en-us/dotnet/api/system.datetime)<br>

### **couponEndDate**

```csharp
public DateTime couponEndDate { get; set; }
```

#### Property Value

[DateTime](https://docs.microsoft.com/en-us/dotnet/api/system.datetime)<br>

### **couponImage**

```csharp
public string couponImage { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **issueCount**

```csharp
public int issueCount { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **itemType**

discountTypeによって、値が異なります。
 1： 単一商品
 3： 複数商品
 4： 受注
 5： 送料無料

```csharp
public int itemType { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

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

### **memberAvailMaxCount**

```csharp
public int memberAvailMaxCount { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **multiRankCond**

0： 条件なし
 1： レギュラー
 2： シルバー
 3： ゴールド
 4： プラチナ
 5： ダイヤモンド

```csharp
public Int32[] multiRankCond { get; set; }
```

#### Property Value

[Int32[]](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **combineFlag**

```csharp
public int combineFlag { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **displayFlag**

```csharp
public int displayFlag { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **items**

対象商品は3000個まで指定可能です。

```csharp
public Item[] items { get; set; }
```

#### Property Value

[Item[]](./rakuten.rms.api.couponapi.item)<br>

### **otherConditions**

```csharp
public OtherConditions otherConditions { get; set; }
```

#### Property Value

[OtherConditions](./rakuten.rms.api.couponapi.otherconditions)<br>

## Constructors

### **CouponToIssue()**

```csharp
public CouponToIssue()
```

---

[`< Back`](./)
