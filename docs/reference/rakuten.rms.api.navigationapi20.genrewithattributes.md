[`< Back`](./)

---

# GenreWithAttributes

Namespace: Rakuten.RMS.Api.NavigationAPI20

```csharp
public class GenreWithAttributes : Genre
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BaseGenre](./rakuten.rms.api.navigationapi20.basegenre) → [Genre](./rakuten.rms.api.navigationapi20.genre) → [GenreWithAttributes](./rakuten.rms.api.navigationapi20.genrewithattributes)

## Properties

### **attributes**

```csharp
public IList<Attribute> attributes { get; set; }
```

#### Property Value

[IList&lt;Attribute&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

### **ancestors**

```csharp
public IList<BaseGenre> ancestors { get; set; }
```

#### Property Value

[IList&lt;BaseGenre&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

### **siblings**

```csharp
public IList<BaseGenre> siblings { get; set; }
```

#### Property Value

[IList&lt;BaseGenre&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

### **children**

```csharp
public IList<BaseGenre> children { get; set; }
```

#### Property Value

[IList&lt;BaseGenre&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

### **genreId**

```csharp
public long genreId { get; set; }
```

#### Property Value

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>

### **genreIdPath**

```csharp
public IList<long> genreIdPath { get; set; }
```

#### Property Value

[IList&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

### **nameJa**

```csharp
public string nameJa { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **nameJaPath**

```csharp
public IList<string> nameJaPath { get; set; }
```

#### Property Value

[IList&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

### **level**

```csharp
public int level { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **lowest**

```csharp
public bool lowest { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **properties**

```csharp
public Property properties { get; set; }
```

#### Property Value

[Property](./rakuten.rms.api.navigationapi20.property)<br>

## Constructors

### **GenreWithAttributes()**

```csharp
public GenreWithAttributes()
```

---

[`< Back`](./)
