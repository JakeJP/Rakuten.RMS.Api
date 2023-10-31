[`< Back`](./)

---

# PaginationRequestModel

Namespace: Rakuten.RMS.Api.RakutenPayOrderAPI

```csharp
public class PaginationRequestModel
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PaginationRequestModel](./rakuten.rms.api.rakutenpayorderapi.paginationrequestmodel)

## Properties

### **requestRecordsAmount**

1ページあたりの取得結果数 最大 1,000 件まで指定可能

```csharp
public int requestRecordsAmount { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **requestPage**

リクエストページ番号

```csharp
public int requestPage { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **SortModelList**

```csharp
public IList<SortModel> SortModelList { get; set; }
```

#### Property Value

[IList&lt;SortModel&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

## Constructors

### **PaginationRequestModel()**

```csharp
public PaginationRequestModel()
```

---

[`< Back`](./)
