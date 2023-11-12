<img align="left" style="height: 2em;" src="https://webservice.rakuten.co.jp/favicon.ico"><em>Rakuten RMS WEB API client for .NET</em>

[**< クラス一覧**](./)
- - -

# SearchCondition

Namespace: Rakuten.RMS.Api.ProductAPI

```csharp
public class SearchCondition
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [SearchCondition](./rakuten.rms.api.productapi.searchcondition)

## Properties

### <a id="properties-genreid"/>**genreId**

```csharp
public string genreId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-keyword"/>**keyword**

```csharp
public string keyword { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-limit"/>**limit**

検索結果の取得上限数
 例：11件目から25件目の情報を取得する場合は、offset=10、limit=15
 null の場合はデフォルト値で検索されます。
 ※値は30まで指定可能です。

```csharp
public Nullable<Int32> limit { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### <a id="properties-makername"/>**makerName**

```csharp
public string makerName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-offset"/>**offset**

0を基準値とした検索結果取得開始位置
 例：11件目から25件目の情報を取得する場合は、offset=10、limit=15
 null の場合はデフォルト値で検索されます。

```csharp
public Nullable<Int32> offset { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### <a id="properties-productid"/>**productId**

```csharp
public string productId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-releasedatato"/>**releaseDataTo**

```csharp
public Nullable<DateTime> releaseDataTo { get; set; }
```

#### Property Value

[Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### <a id="properties-releasedatefrom"/>**releaseDateFrom**

```csharp
public Nullable<DateTime> releaseDateFrom { get; set; }
```

#### Property Value

[Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### <a id="properties-sortby"/>**sortBy**

```csharp
public string sortBy { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

## Constructors

### <a id="constructors-.ctor"/>**SearchCondition()**

```csharp
public SearchCondition()
```


- - -
[**< クラス一覧**](./)
