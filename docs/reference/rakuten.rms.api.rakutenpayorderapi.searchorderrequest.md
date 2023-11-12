<img align="left" style="height: 2em;" src="https://webservice.rakuten.co.jp/favicon.ico"><em>Rakuten RMS WEB API client for .NET</em>

[**< クラス一覧**](./)
- - -

# SearchOrderRequest

Namespace: Rakuten.RMS.Api.RakutenPayOrderAPI

```csharp
public class SearchOrderRequest : SearchOrderItemRequest
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [SearchOrderItemRequest](./rakuten.rms.api.rakutenpayorderapi.searchorderitemrequest) → [SearchOrderRequest](./rakuten.rms.api.rakutenpayorderapi.searchorderrequest)

## Properties

### <a id="properties-asurakuflag"/>**asurakuFlag**

あす楽希望フラグ
 以下のいずれか
 0: あす楽希望の有無によらず取得
 1: あす楽希望のものだけを取得

```csharp
public Nullable<Int32> asurakuFlag { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### <a id="properties-couponuseflag"/>**couponUseFlag**

クーポン利用有無フラグ
 以下のいずれか
 0: クーポン利用の有無によらず取得
 1: クーポン利用のものだけを取得

```csharp
public Nullable<Int32> couponUseFlag { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### <a id="properties-datetype"/>**dateType**

以下のいずれか
 1: 注文日
 2: 注文確認日
 3: 注文確定日
 4: 発送日
 5: 発送完了報告日
 6: 決済確定日

```csharp
public int dateType { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### <a id="properties-deliveryname"/>**deliveryName**

```csharp
public string deliveryName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-drugflag"/>**drugFlag**

医薬品受注フラグ
 以下のいずれか
 0: 医薬品の有無によらず取得
 1: 医薬品を含む注文だけを取得

```csharp
public Nullable<Int32> drugFlag { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### <a id="properties-enddatetime"/>**endDatetime**

```csharp
public DateTime endDatetime { get; set; }
```

#### Property Value

[DateTime](https://docs.microsoft.com/en-us/dotnet/api/system.datetime)<br>

### <a id="properties-mailsendtype"/>**mailSendType**

以下のいずれか
 0: PC/モバイル
 1: PC
 2: モバイル

```csharp
public Nullable<Int32> mailSendType { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### <a id="properties-orderermailaddress"/>**ordererMailAddress**

注文者メールアドレス 完全一致

```csharp
public string ordererMailAddress { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-orderprogresslist"/>**orderProgressList**

100: 注文確認待ち
 200: 楽天処理中
 300: 発送待ち
 400: 変更確定待ち
 500: 発送済
 600: 支払手続き中
 700: 支払手続き済
 800: キャンセル確定待ち
 900: キャンセル確定

```csharp
public IList<Int32> orderProgressList { get; set; }
```

#### Property Value

[IList&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

### <a id="properties-ordertypelist"/>**orderTypeList**

```csharp
public IList<Int32> orderTypeList { get; set; }
```

#### Property Value

[IList&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

### <a id="properties-overseasflag"/>**overseasFlag**

海外かご注文フラグ
 以下のいずれか
 0: 海外カゴ注文の有無によらず取得
 1: 海外カゴ注文のものだけを取得

```csharp
public Nullable<Int32> overseasFlag { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### <a id="properties-paginationrequestmodel"/>**PaginationRequestModel**

```csharp
public PaginationRequestModel PaginationRequestModel { get; set; }
```

#### Property Value

[PaginationRequestModel](./rakuten.rms.api.rakutenpayorderapi.paginationrequestmodel)<br>

### <a id="properties-phonenumber"/>**phoneNumber**

電話番号 完全一致

```csharp
public string phoneNumber { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-phonenumbertype"/>**phoneNumberType**

電話番号種別
 以下のいずれか
 1: 注文者
 2: 送付先

```csharp
public Nullable<Int32> phoneNumberType { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### <a id="properties-purchasesitetype"/>**purchaseSiteType**

購入サイトリスト
 0: すべて
 1: PCで注文
 2: モバイルで注文
 3: スマートフォンで注文
 4: タブレットで注文

```csharp
public Nullable<Int32> purchaseSiteType { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### <a id="properties-reservenumber"/>**reserveNumber**

申込番号 完全一致

```csharp
public string reserveNumber { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-searchkeyword"/>**searchKeyword**

・機種依存文字などの不正文字以外
 ・全角、半角にかかわらず32文字以下

```csharp
public string searchKeyword { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-searchkeywordtype"/>**searchKeywordType**

```csharp
public Nullable<Int32> searchKeywordType { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### <a id="properties-settlementmethod"/>**settlementMethod**

```csharp
public Nullable<Int32> settlementMethod { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### <a id="properties-shippingnumberblankflag"/>**shippingNumberBlankFlag**

以下のいずれか
 0: お荷物伝票番号の指定の有無によらず取得
 1: お荷物伝票番号が未指定のものだけを取得

```csharp
public Nullable<Int32> shippingNumberBlankFlag { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### <a id="properties-startdatetime"/>**startDatetime**

```csharp
public DateTime startDatetime { get; set; }
```

#### Property Value

[DateTime](https://docs.microsoft.com/en-us/dotnet/api/system.datetime)<br>

### <a id="properties-substatusidlist"/>**subStatusIdList**

```csharp
public IList<Int32> subStatusIdList { get; set; }
```

#### Property Value

[IList&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

## Constructors

### <a id="constructors-.ctor"/>**SearchOrderRequest()**

```csharp
public SearchOrderRequest()
```


- - -
[**< クラス一覧**](./)
