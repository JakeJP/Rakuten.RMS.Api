<img align="left" style="height: 2em;" src="https://webservice.rakuten.co.jp/favicon.ico"><em>Rakuten RMS WEB API client for .NET</em>

[**< クラス一覧**](./)
- - -

# AdditionalFeeModel

Namespace: Rakuten.RMS.Api.RakutenPayOrderAPI

```csharp
public class AdditionalFeeModel
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [AdditionalFeeModel](./rakuten.rms.api.rakutenpayorderapi.additionalfeemodel)

## Properties

### <a id="properties-additionalfeeoccuramount"/>**additionalFeeOccurAmount**

負担金

```csharp
public int additionalFeeOccurAmount { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### <a id="properties-additionalfeeoccurdatetime"/>**additionalFeeOccurDatetime**

負担金発生日時

```csharp
public Nullable<DateTime> additionalFeeOccurDatetime { get; set; }
```

#### Property Value

[Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### <a id="properties-additionalfeetaxrate"/>**additionalFeeTaxRate**

負担金税率

```csharp
public decimal additionalFeeTaxRate { get; set; }
```

#### Property Value

[Decimal](https://docs.microsoft.com/en-us/dotnet/api/system.decimal)<br>

### <a id="properties-additionalfeetype"/>**additionalFeeType**

負担金科目 
 1: 後払い手数料 2: チャージバック手数料

```csharp
public int additionalFeeType { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### <a id="properties-payfrom"/>**payFrom**

負担者
 1: 注文者
 2: 店舗

```csharp
public int payFrom { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

## Constructors

### <a id="constructors-.ctor"/>**AdditionalFeeModel()**

```csharp
public AdditionalFeeModel()
```


- - -
[**< クラス一覧**](./)
