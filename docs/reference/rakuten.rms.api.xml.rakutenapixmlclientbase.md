[`< Back`](./)

---

# RakutenApiXmlClientBase

Namespace: Rakuten.RMS.Api.XML

```csharp
public abstract class RakutenApiXmlClientBase : Rakuten.RMS.Api.REST.RakutenApiClientBaseCommon
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [RakutenApiClientBaseCommon](./rakuten.rms.api.rest.rakutenapiclientbasecommon) → [RakutenApiXmlClientBase](./rakuten.rms.api.xml.rakutenapixmlclientbase)

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
