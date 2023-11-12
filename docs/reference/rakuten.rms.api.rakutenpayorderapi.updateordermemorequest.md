<img align="left" style="height: 2em;" src="https://webservice.rakuten.co.jp/favicon.ico"><em>Rakuten RMS WEB API client for .NET</em>

[**< クラス一覧**](./)
- - -

# UpdateOrderMemoRequest

Namespace: Rakuten.RMS.Api.RakutenPayOrderAPI

```csharp
public class UpdateOrderMemoRequest
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [UpdateOrderMemoRequest](./rakuten.rms.api.rakutenpayorderapi.updateordermemorequest)

## Properties

### <a id="properties-deliveryclass"/>**deliveryClass**

配送区分
 0: 選択なし
 1: 普通
 2: 冷蔵
 3: 冷凍
 4: その他1
 5: その他2
 6: その他3
 7: その他4
 8: その他5

```csharp
public Nullable<Int64> deliveryClass { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### <a id="properties-deliverydate"/>**deliveryDate**

お届け日指定 no Date	10	-	YYYY-MM-DD	2017-11-30

```csharp
public Nullable<DateTime> deliveryDate { get; set; }
```

#### Property Value

[Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### <a id="properties-mailplugsentence"/>**mailPlugSentence**

メール差込文(お客様へのメッセージ)

```csharp
public string mailPlugSentence { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-memo"/>**memo**

ひとことメモ

```csharp
public string memo { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-operator"/>**Operator**

担当者

```csharp
public string Operator { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-ordernumber"/>**orderNumber**

注文番号

```csharp
public string orderNumber { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-shippingterm"/>**shippingTerm**

お届け時間帯
 0: なし
 1: 午前
 2: 午後
 9: その他
 h1h2: h1時-h2時(h1は7～24まで任意で数値指定可能。h2は07～24まで任意で数値指定可能)

```csharp
public Nullable<Int32> shippingTerm { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### <a id="properties-substatusid"/>**subStatusId**

サブステータスID

```csharp
public Nullable<Int64> subStatusId { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

## Constructors

### <a id="constructors-.ctor"/>**UpdateOrderMemoRequest()**

```csharp
public UpdateOrderMemoRequest()
```


- - -
[**< クラス一覧**](./)
