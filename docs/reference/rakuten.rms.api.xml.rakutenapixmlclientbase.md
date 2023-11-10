[`< Back`](./)

---

# RakutenApiXmlClientBase

Namespace: Rakuten.RMS.Api.XML

```csharp
public abstract class RakutenApiXmlClientBase : Rakuten.RMS.Api.REST.RakutenApiClientBaseCommon
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [RakutenApiClientBaseCommon](./rakuten.rms.api.rest.rakutenapiclientbasecommon) → [RakutenApiXmlClientBase](./rakuten.rms.api.xml.rakutenapixmlclientbase)

## Methods

### **Get&lt;TResult&gt;(String, NameValueCollection, String)**

```csharp
protected TResult Get<TResult>(string url, NameValueCollection queryParameters, string httpMethod)
```

#### Type Parameters

`TResult`<br>

#### Parameters

`url` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`queryParameters` NameValueCollection<br>

`httpMethod` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

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

### **Post&lt;TResult, TErrorResult&gt;(Object, String, XmlSerializerNamespaces)**

```csharp
protected TResult Post<TResult, TErrorResult>(object request, string methodName, XmlSerializerNamespaces namespaces)
```

#### Type Parameters

`TResult`<br>

`TErrorResult`<br>

#### Parameters

`request` [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

`methodName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`namespaces` XmlSerializerNamespaces<br>

#### Returns

TResult<br>

### **Post&lt;TResult&gt;(String, Object, XmlSerializerNamespaces, String)**

```csharp
protected TResult Post<TResult>(string url, object request, XmlSerializerNamespaces namespaces, string httpMethod)
```

#### Type Parameters

`TResult`<br>

#### Parameters

`url` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`request` [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

`namespaces` XmlSerializerNamespaces<br>

`httpMethod` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

TResult<br>

### **Post&lt;TResult, TErrorResult&gt;(String, Object, XmlSerializerNamespaces, String)**

```csharp
protected TResult Post<TResult, TErrorResult>(string url, object request, XmlSerializerNamespaces namespaces, string httpMethod)
```

#### Type Parameters

`TResult`<br>

`TErrorResult`<br>

#### Parameters

`url` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`request` [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

`namespaces` XmlSerializerNamespaces<br>

`httpMethod` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

TResult<br>

### **GetRequestXmlAttributeOverrides(Type)**

```csharp
protected XmlAttributeOverrides GetRequestXmlAttributeOverrides(Type o)
```

#### Parameters

`o` [Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)<br>

#### Returns

XmlAttributeOverrides<br>

### **HandleResponse&lt;TResult, TErrorResult&gt;(HttpWebRequest)**

```csharp
protected TResult HandleResponse<TResult, TErrorResult>(HttpWebRequest req)
```

#### Type Parameters

`TResult`<br>

`TErrorResult`<br>

#### Parameters

`req` HttpWebRequest<br>

#### Returns

TResult<br>

---

[`< Back`](./)
