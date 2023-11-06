[`< Back`](./)

---

# SearchCondition

Namespace: Rakuten.RMS.Api.ProductAPI

```csharp
public class SearchCondition
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [SearchCondition](./rakuten.rms.api.productapi.searchcondition)

## Properties

### **productId**

```csharp
public string productId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **keyword**

```csharp
public string keyword { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **genreId**

```csharp
public string genreId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **makerName**

```csharp
public string makerName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **releaseDateFrom**

```csharp
public Nullable<DateTime> releaseDateFrom { get; set; }
```

#### Property Value

[Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **releaseDataTo**

```csharp
public Nullable<DateTime> releaseDataTo { get; set; }
```

#### Property Value

[Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **sortBy**

```csharp
public string sortBy { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **offset**

0を基準値とした検索結果取得開始位置
 例：11件目から25件目の情報を取得する場合は、offset=10、limit=15
 null の場合はデフォルト値で検索されます。

```csharp
public Nullable<int> offset { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **limit**

検索結果の取得上限数
 例：11件目から25件目の情報を取得する場合は、offset=10、limit=15
 null の場合はデフォルト値で検索されます。
 ※値は30まで指定可能です。

```csharp
public Nullable<int> limit { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

## Constructors

### **SearchCondition()**

```csharp
public SearchCondition()
```

## Methods

### **ToNameValueCollection()**

```csharp
internal NameValueCollection ToNameValueCollection()
```

#### Returns

NameValueCollection<br>

---

[`< Back`](./)
