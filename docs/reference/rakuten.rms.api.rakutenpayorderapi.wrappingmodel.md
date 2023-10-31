[`< Back`](./)

---

# WrappingModel

Namespace: Rakuten.RMS.Api.RakutenPayOrderAPI

```csharp
public class WrappingModel
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [WrappingModel](./rakuten.rms.api.rakutenpayorderapi.wrappingmodel)

## Properties

### **title**

以下のいずれか
 1: 包装紙
 2: リボン

```csharp
public int title { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **name**

```csharp
public string name { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **price**

```csharp
public Nullable<int> price { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **includeTaxFlag**

税込別
 0: 税別
 1: 税込

```csharp
public int includeTaxFlag { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **deleteWrappingFlag**

ラッピング削除フラグ

```csharp
public int deleteWrappingFlag { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

## Constructors

### **WrappingModel()**

```csharp
public WrappingModel()
```

---

[`< Back`](./)
