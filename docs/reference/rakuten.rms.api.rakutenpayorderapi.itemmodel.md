<img align="left" style="height: 2em;" src="https://webservice.rakuten.co.jp/favicon.ico"><em>Rakuten RMS WEB API client for .NET</em>

[**< クラス一覧**](./)
- - -

# ItemModel

Namespace: Rakuten.RMS.Api.RakutenPayOrderAPI

```csharp
public class ItemModel : ItemModelToUpdate
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ItemModelToUpdate](./rakuten.rms.api.rakutenpayorderapi.itemmodeltoupdate) → [ItemModel](./rakuten.rms.api.rakutenpayorderapi.itemmodel)

## Properties

### <a id="properties-dealflag"/>**dealFlag**

version=2

```csharp
public int dealFlag { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### <a id="properties-deleteitemflag"/>**deleteItemFlag**

商品削除フラグ
 0: 商品を削除しない
 1: 商品を削除する

```csharp
public int deleteItemFlag { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### <a id="properties-deleteitemflag"/>**deleteItemFlag**

```csharp
public Nullable<Int32> deleteItemFlag { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### <a id="properties-delvdateinfo"/>**delvdateInfo**

```csharp
public string delvdateInfo { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-drugflag"/>**drugFlag**

version=2

```csharp
public int drugFlag { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### <a id="properties-includecashondeliverypostageflag"/>**includeCashOnDeliveryPostageFlag**

0: 代引手数料別
 1: 代引手数料込み

```csharp
public int includeCashOnDeliveryPostageFlag { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### <a id="properties-includepostageflag"/>**includePostageFlag**

```csharp
public int includePostageFlag { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### <a id="properties-includetaxflag"/>**includeTaxFlag**

0: 税別
 1: 税込み

```csharp
public int includeTaxFlag { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### <a id="properties-inventorytype"/>**inventoryType**

```csharp
public int inventoryType { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### <a id="properties-issingleitemshipping"/>**isSingleItemShipping**

以下のいずれか
 0: 単品配送ではない
 1: 単品配送である
 ※Request Parameterの「version」に「4」以降の値を指定すると取得可能

```csharp
public int isSingleItemShipping { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### <a id="properties-itemdetailid"/>**itemDetailId**

```csharp
public long itemDetailId { get; set; }
```

#### Property Value

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>

### <a id="properties-itemid"/>**itemId**

```csharp
public int itemId { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### <a id="properties-itemname"/>**itemName**

```csharp
public string itemName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-itemnumber"/>**itemNumber**

商品番号
 項目選択肢別在庫が指定された商品の場合、以下のルールで値が表示されます
 SKU移行前注文：商品番号（店舗様が登録した番号）＋項目選択肢ID（横軸）＋項目選択肢ID（縦軸）
 SKU移行後注文：商品番号（店舗様が登録した番号）

```csharp
public string itemNumber { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-managenumber"/>**manageNumber**

```csharp
public string manageNumber { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-pointrate"/>**pointRate**

```csharp
public int pointRate { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### <a id="properties-pointtype"/>**pointType**

```csharp
public int pointType { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### <a id="properties-price"/>**price**

```csharp
public int price { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### <a id="properties-pricetaxincl"/>**priceTaxIncl**

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

### <a id="properties-restoreinventoryflag"/>**restoreInventoryFlag**

在庫連動オプション
 0: 商品の設定に従う
 1: 在庫連動する
 2: 在庫連動しない

```csharp
public int restoreInventoryFlag { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### <a id="properties-restoreinventoryflag"/>**restoreInventoryFlag**

```csharp
public Nullable<Int32> restoreInventoryFlag { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### <a id="properties-selectedchoice"/>**selectedChoice**

```csharp
public string selectedChoice { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-skumodellist"/>**SkuModelList**

```csharp
public IList<SkuModel> SkuModelList { get; set; }
```

#### Property Value

[IList&lt;SkuModel&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

### <a id="properties-taxrate"/>**taxRate**

商品税率
 以下のいずれか
 ・0・0.0・0.08・0.1

```csharp
public decimal taxRate { get; set; }
```

#### Property Value

[Decimal](https://docs.microsoft.com/en-us/dotnet/api/system.decimal)<br>

### <a id="properties-units"/>**units**

```csharp
public int units { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

## Constructors

### <a id="constructors-.ctor"/>**ItemModel()**

```csharp
public ItemModel()
```


- - -
[**< クラス一覧**](./)
