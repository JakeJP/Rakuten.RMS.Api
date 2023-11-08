[`< Back`](./)

---

# InfoListResponse

Namespace: Rakuten.RMS.Api.ReserveAPI

```csharp
public class InfoListResponse
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [InfoListResponse](./rakuten.rms.api.reserveapi.infolistresponse)

## Properties

### **resultCodeInt**

処理結果

```csharp
public int resultCodeInt { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **resultCode**

処理結果コード N00-000

```csharp
public string resultCode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **resultMessage**

処理結果メッセージ

```csharp
public string resultMessage { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **responseDatetime**

レスポンス日時

```csharp
public DateTime responseDatetime { get; set; }
```

#### Property Value

[DateTime](https://docs.microsoft.com/en-us/dotnet/api/system.datetime)<br>

### **totalCount**

検索条件に一致したデータの総数

```csharp
public int totalCount { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **resultCount**

limit の設定により、実際に取得したデータの件数
 値の範囲: 1 - 1000

```csharp
public int resultCount { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **limit**

取得件数
 リクエストの値が設定されます。

```csharp
public int limit { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **offset**

取得位置

```csharp
public int offset { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **publicReserveModelList**

申込情報リスト

```csharp
public List<ReserveModel> publicReserveModelList { get; set; }
```

#### Property Value

[List&lt;ReserveModel&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>

## Constructors

### **InfoListResponse()**

```csharp
public InfoListResponse()
```

---

[`< Back`](./)
