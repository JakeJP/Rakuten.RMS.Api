<img align="left" style="height: 2em;" src="https://webservice.rakuten.co.jp/favicon.ico"><em>Rakuten RMS WEB API client for .NET</em>

[**< クラス一覧**](./)
- - -

# DeliveryModel

Namespace: Rakuten.RMS.Api.RakutenPayOrderAPI

```csharp
public class DeliveryModel
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DeliveryModel](./rakuten.rms.api.rakutenpayorderapi.deliverymodel)

## Properties

### <a id="properties-deliveryclass"/>**deliveryClass**

配送区分
 0: 選択なし
 1: 普通
 2: 冷蔵
 3: 冷凍
 4: その他１
 5: その他２
 6: その他３
 7: その他４
 8: その他５

```csharp
public Nullable<Int32> deliveryClass { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### <a id="properties-deliveryname"/>**deliveryName**

以下のいずれか
 ・宅配便
 ・小型宅配便
 ・大型宅配便
 ・クール便
 ・メール便
 ・国際配送
 ・コンビニ受取
 ・ロッカー受取
 ・店頭受取
 ・発送を伴わない
 ・郵便局受取

```csharp
public string deliveryName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

## Constructors

### <a id="constructors-.ctor"/>**DeliveryModel()**

```csharp
public DeliveryModel()
```


- - -
[**< クラス一覧**](./)
