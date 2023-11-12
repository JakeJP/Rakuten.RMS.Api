<img align="left" style="height: 2em;" src="https://webservice.rakuten.co.jp/favicon.ico"><em>Rakuten RMS WEB API client for .NET</em>

[**< クラス一覧**](./)
- - -

# SearchOrderItemRequest

Namespace: Rakuten.RMS.Api.RakutenPayOrderAPI

```csharp
public class SearchOrderItemRequest
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [SearchOrderItemRequest](./rakuten.rms.api.rakutenpayorderapi.searchorderitemrequest)

## Properties

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

### <a id="properties-enddatetime"/>**endDatetime**

```csharp
public DateTime endDatetime { get; set; }
```

#### Property Value

[DateTime](https://docs.microsoft.com/en-us/dotnet/api/system.datetime)<br>

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

### <a id="properties-paginationrequestmodel"/>**PaginationRequestModel**

```csharp
public PaginationRequestModel PaginationRequestModel { get; set; }
```

#### Property Value

[PaginationRequestModel](./rakuten.rms.api.rakutenpayorderapi.paginationrequestmodel)<br>

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

### <a id="constructors-.ctor"/>**SearchOrderItemRequest()**

```csharp
public SearchOrderItemRequest()
```


- - -
[**< クラス一覧**](./)
