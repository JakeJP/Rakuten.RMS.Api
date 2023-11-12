<img align="left" style="height: 2em;" src="https://webservice.rakuten.co.jp/favicon.ico"><em>Rakuten RMS WEB API client for .NET</em>

[**< クラス一覧**](./)
- - -

# SkuModel

Namespace: Rakuten.RMS.Api.RakutenPayOrderAPI

Level 5: skuModel

```csharp
public class SkuModel
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [SkuModel](./rakuten.rms.api.rakutenpayorderapi.skumodel)

## Properties

### <a id="properties-merchantdefinedskuid"/>**merchantDefinedSkuId**

システム連携用SKU番号
 SKU移行前の注文の場合、値は空になります。
 ※Request Parameterの「version」に「7」以降の値を指定すると取得可能

```csharp
public string merchantDefinedSkuId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-skuinfo"/>**skuInfo**

SKU情報
 
 以下のルールで値が入ります。
 SKU移行前注文：値は空になります。
 SKU移行後注文：バリエーション項目名・バリエーション選択肢（旧・項目選択肢別在庫情報）が入ります。
 項目選択肢情報は入りません。Level 4: ItemModel &gt; selectedChoiceにて取得可能です。 　 　　 　　　 　　　 　　 　　 　　　 　　　 　　 　　 　　　 　　　 　　 　
 商品種別 内容
 シングルSKU 該当項目は無い為、データ無し
 マルチSKU バリエーション項目名とバリエーション選択肢。
 下記のフォーマットで返却されます。
 バリエーション項目名:バリエーション選択肢
 ※Request Parameterの「version」に「7」以降の値を指定すると取得可能

```csharp
public string skuInfo { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-variantid"/>**variantId**

SKU管理番号
 SKU移行前の注文の場合、値は空になります。
 ※Request Parameterの「version」に「7」以降の値を指定すると取得可能

```csharp
public string variantId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

## Constructors

### <a id="constructors-.ctor"/>**SkuModel()**

```csharp
public SkuModel()
```


- - -
[**< クラス一覧**](./)
