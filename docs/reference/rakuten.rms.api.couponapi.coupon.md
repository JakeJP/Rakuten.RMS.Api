<img align="left" style="height: 2em;" src="https://webservice.rakuten.co.jp/favicon.ico"><em>Rakuten RMS WEB API client for .NET</em>

[**< クラス一覧**](./)
- - -

# Coupon

Namespace: Rakuten.RMS.Api.CouponAPI

```csharp
public class Coupon : CouponToIssue
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [CouponToIssue](./rakuten.rms.api.couponapi.coupontoissue) → [Coupon](./rakuten.rms.api.couponapi.coupon)

## Properties

### <a id="properties-combineflag"/>**combineFlag**

```csharp
public int combineFlag { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### <a id="properties-couponcaption"/>**couponCaption**

```csharp
public string couponCaption { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-couponcode"/>**couponCode**

```csharp
public string couponCode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-couponenddate"/>**couponEndDate**

```csharp
public DateTime couponEndDate { get; set; }
```

#### Property Value

[DateTime](https://docs.microsoft.com/en-us/dotnet/api/system.datetime)<br>

### <a id="properties-couponimage"/>**couponImage**

```csharp
public string couponImage { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-couponname"/>**couponName**

```csharp
public string couponName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-couponstartdate"/>**couponStartDate**

```csharp
public DateTime couponStartDate { get; set; }
```

#### Property Value

[DateTime](https://docs.microsoft.com/en-us/dotnet/api/system.datetime)<br>

### <a id="properties-discountfactor"/>**discountFactor**

```csharp
public int discountFactor { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### <a id="properties-discounttype"/>**discountType**

1： 定額値引き
 2： 定率値引き
 4： 送料無料

```csharp
public int discountType { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### <a id="properties-displayflag"/>**displayFlag**

```csharp
public int displayFlag { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### <a id="properties-issuecount"/>**issueCount**

```csharp
public int issueCount { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### <a id="properties-items"/>**items**

対象商品は3000個まで指定可能です。

```csharp
public Item[] items { get; set; }
```

#### Property Value

[Item[]](./rakuten.rms.api.couponapi.item)<br>

### <a id="properties-itemtype"/>**itemType**

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

### <a id="properties-memberavailmaxcount"/>**memberAvailMaxCount**

```csharp
public int memberAvailMaxCount { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### <a id="properties-multirankcond"/>**multiRankCond**

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

### <a id="properties-otherconditions"/>**otherConditions**

```csharp
public OtherConditions otherConditions { get; set; }
```

#### Property Value

[OtherConditions](./rakuten.rms.api.couponapi.otherconditions)<br>

## Constructors

### <a id="constructors-.ctor"/>**Coupon()**

```csharp
public Coupon()
```


- - -
[**< クラス一覧**](./)
