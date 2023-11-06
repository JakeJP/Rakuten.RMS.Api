[`< Back`](./)

---

# CategoryIdWithChildren

Namespace: Rakuten.RMS.Api.CategoryAPI20

```csharp
public class CategoryIdWithChildren
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [CategoryIdWithChildren](./rakuten.rms.api.categoryapi20.categoryidwithchildren)

## Properties

### **categoryId**

```csharp
public string categoryId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **children**

```csharp
public IList<CategoryIdWithChildren> children { get; set; }
```

#### Property Value

[IList&lt;CategoryIdWithChildren&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

## Constructors

### **CategoryIdWithChildren()**

```csharp
public CategoryIdWithChildren()
```

### **CategoryIdWithChildren(String, IList&lt;CategoryIdWithChildren&gt;)**

```csharp
public CategoryIdWithChildren(string categoryId, IList<CategoryIdWithChildren> children)
```

#### Parameters

`categoryId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`children` [IList&lt;CategoryIdWithChildren&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

## Methods

### **Add(CategoryIdWithChildren)**

```csharp
public void Add(CategoryIdWithChildren child)
```

#### Parameters

`child` [CategoryIdWithChildren](./rakuten.rms.api.categoryapi20.categoryidwithchildren)<br>

### **Add(String, IList&lt;CategoryIdWithChildren&gt;)**

```csharp
public void Add(string categoryId, IList<CategoryIdWithChildren> children)
```

#### Parameters

`categoryId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`children` [IList&lt;CategoryIdWithChildren&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

---

[`< Back`](./)
