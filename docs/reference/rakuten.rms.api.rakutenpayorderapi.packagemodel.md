<img align="left" style="height: 2em;" src="https://webservice.rakuten.co.jp/favicon.ico"><em>Rakuten RMS WEB API client for .NET</em>

[**< クラス一覧**](./)
- - -

# PackageModel

Namespace: Rakuten.RMS.Api.RakutenPayOrderAPI

```csharp
public class PackageModel
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PackageModel](./rakuten.rms.api.rakutenpayorderapi.packagemodel)

## Properties

### <a id="properties-basketid"/>**basketId**

送付先ID

```csharp
public int basketId { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### <a id="properties-defaultdeliverycompanycode"/>**defaultDeliveryCompanyCode**

購入時配送会社
 1000: その他
 1001: ヤマト運輸
 1002: 佐川急便
 1003: 日本郵便
 1004: 西濃運輸
 1005: セイノースーパーエクスプレス
 1006: 福山通運
 1007: 名鉄運輸
 1008: トナミ運輸
 1009: 第一貨物
 1010: 新潟運輸
 1011: 中越運送
 1012: 岡山県貨物運送
 1013: 久留米運送
 1014: 山陽自動車運送
 1015: NXトランスポート
 1016: エコ配
 1017: EMS
 1018: DHL
 1019: FedEx
 1020: UPS
 1021: 日本通運
 1022: TNT
 1023: OCS
 1024: USPS
 1025: SFエクスプレス
 1026: Aramex
 1027: SGHグローバル・ジャパン
 1028: Rakuten EXPRESS
 ※Request Parameterの「version」に「4」以降の値を指定すると取得可能。

```csharp
public string defaultDeliveryCompanyCode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-deliverycvsmodel"/>**DeliveryCvsModel**

コンビニ配送モデル 
 配送方法がコンビニ、郵便局受取の場合、参照可能

```csharp
public DeliveryCVSModel DeliveryCvsModel { get; set; }
```

#### Property Value

[DeliveryCVSModel](./rakuten.rms.api.rakutenpayorderapi.deliverycvsmodel)<br>

### <a id="properties-deliveryprice"/>**deliveryPrice**

代引料

```csharp
public int deliveryPrice { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### <a id="properties-goodsprice"/>**goodsPrice**

商品合計金額

```csharp
public int goodsPrice { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### <a id="properties-goodstax"/>**goodsTax**

消費税

```csharp
public int goodsTax { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### <a id="properties-itemmodellist"/>**ItemModelList**

商品モデルリスト

```csharp
public IList<ItemModel> ItemModelList { get; set; }
```

#### Property Value

[IList&lt;ItemModel&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

### <a id="properties-noshi"/>**noshi**

```csharp
public string noshi { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-packagedeleteflag"/>**packageDeleteFlag**

0: 送付先モデルを削除しない
 1: 送付先モデルを削除する

```csharp
public int packageDeleteFlag { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### <a id="properties-postageprice"/>**postagePrice**

送料

```csharp
public int postagePrice { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### <a id="properties-sendermodel"/>**SenderModel**

送付者モデル

```csharp
public SenderModel SenderModel { get; set; }
```

#### Property Value

[SenderModel](./rakuten.rms.api.rakutenpayorderapi.sendermodel)<br>

### <a id="properties-shippingmodellist"/>**ShippingModelList**

発送モデルリスト

```csharp
public IList<ShippingModel> ShippingModelList { get; set; }
```

#### Property Value

[IList&lt;ShippingModel&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

### <a id="properties-totalprice"/>**totalPrice**

合計金額
 送付先に紐付く 商品代金((価格×個数)の商品合計)+のし・ラッピング代+送料+消費税+代引手数料
 ※未確定の場合、-9999になります。

```csharp
public int totalPrice { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

## Constructors

### <a id="constructors-.ctor"/>**PackageModel()**

```csharp
public PackageModel()
```


- - -
[**< クラス一覧**](./)
