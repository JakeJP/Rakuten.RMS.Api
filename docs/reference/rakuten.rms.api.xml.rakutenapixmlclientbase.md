[`< Back`](./)

---

# RakutenApiXmlClientBase

Namespace: Rakuten.RMS.Api.XML

```csharp
public abstract class RakutenApiXmlClientBase
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [RakutenApiXmlClientBase](./rakuten.rms.api.xml.rakutenapixmlclientbase)

## Methods

### **Get&lt;TResult&gt;(String, NameValueCollection)**

```csharp
protected TResult Get<TResult>(string url, NameValueCollection queryParameters)
```

#### Type Parameters

`TResult`<br>

#### Parameters

`url` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`queryParameters` NameValueCollection<br>

#### Returns

TResult<br>

### **Get&lt;TResult&gt;(NameValueCollection, String)**

```csharp
protected TResult Get<TResult>(NameValueCollection queryParameters, string methodName)
```

#### Type Parameters

`TResult`<br>

#### Parameters

`queryParameters` NameValueCollection<br>

`methodName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

TResult<br>

### **GetNamespaces()**

```csharp
protected XmlSerializerNamespaces GetNamespaces()
```

#### Returns

XmlSerializerNamespaces<br>

### **Post&lt;TResult&gt;(Object, String, XmlSerializerNamespaces)**

```csharp
protected TResult Post<TResult>(object request, string methodName, XmlSerializerNamespaces namespaces)
```

#### Type Parameters

`TResult`<br>

#### Parameters

`request` [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

`methodName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`namespaces` XmlSerializerNamespaces<br>

#### Returns

TResult<br>

### **PostFile&lt;TResult&gt;(String, Stream, String, String, NameValueCollection)**

```csharp
protected TResult PostFile<TResult>(string url, Stream fileStream, string paramName, string contentType, NameValueCollection nvc)
```

#### Type Parameters

`TResult`<br>

#### Parameters

`url` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`fileStream` [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)<br>

`paramName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`contentType` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`nvc` NameValueCollection<br>

#### Returns

TResult<br>

---

[`< Back`](./)
