<img align="left" style="height: 2em;" src="https://webservice.rakuten.co.jp/favicon.ico"><em>Rakuten RMS WEB API client for .NET</em>

[**< クラス一覧**](./)
- - -

# PaginationRequestModel

Namespace: Rakuten.RMS.Api.RakutenPayOrderAPI

```csharp
public class PaginationRequestModel
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PaginationRequestModel](./rakuten.rms.api.rakutenpayorderapi.paginationrequestmodel)

## Properties

### <a id="properties-requestpage"/>**requestPage**

リクエストページ番号

```csharp
public int requestPage { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### <a id="properties-requestrecordsamount"/>**requestRecordsAmount**

1ページあたりの取得結果数 最大 1,000 件まで指定可能

```csharp
public int requestRecordsAmount { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### <a id="properties-sortmodellist"/>**SortModelList**

```csharp
public IList<SortModel> SortModelList { get; set; }
```

#### Property Value

[IList&lt;SortModel&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

## Constructors

### <a id="constructors-.ctor"/>**PaginationRequestModel()**

```csharp
public PaginationRequestModel()
```


- - -
[**< クラス一覧**](./)
