[`< Back`](./)

---

# RakutenApiJsonClientBase

Namespace: Rakuten.RMS.Api.JSON

```csharp
public class RakutenApiJsonClientBase : Rakuten.RMS.Api.REST.RakutenApiClientBaseCommon
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [RakutenApiClientBaseCommon](./rakuten.rms.api.rest.rakutenapiclientbasecommon) → [RakutenApiJsonClientBase](./rakuten.rms.api.json.rakutenapijsonclientbase)

## Methods

### **GetRequest&lt;TResult&gt;(String, String, NameValueCollection)**

```csharp
protected TResult GetRequest<TResult>(string url, string method, NameValueCollection queryParameters)
```

#### Type Parameters

`TResult`<br>

#### Parameters

`url` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`method` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`queryParameters` NameValueCollection<br>

#### Returns

TResult<br>

### **GetRequest&lt;TResult, TErrorResult&gt;(String, String, NameValueCollection)**

```csharp
protected TResult GetRequest<TResult, TErrorResult>(string url, string method, NameValueCollection queryParameters)
```

#### Type Parameters

`TResult`<br>

`TErrorResult`<br>

#### Parameters

`url` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`method` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`queryParameters` NameValueCollection<br>

#### Returns

TResult<br>

### **PostRequest&lt;TResult&gt;(String, Object, String, String)**

```csharp
protected TResult PostRequest<TResult>(string url, object request, string method, string dateFormtString)
```

#### Type Parameters

`TResult`<br>

#### Parameters

`url` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`request` [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

`method` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`dateFormtString` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

TResult<br>

### **PostRequest&lt;TResult, TErrorResult&gt;(String, Object, String, String)**

```csharp
protected TResult PostRequest<TResult, TErrorResult>(string url, object request, string method, string dateFormtString)
```

#### Type Parameters

`TResult`<br>

`TErrorResult`<br>

#### Parameters

`url` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`request` [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

`method` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`dateFormtString` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

TResult<br>

### **HandleResponse&lt;TResult&gt;(HttpWebRequest)**

```csharp
protected TResult HandleResponse<TResult>(HttpWebRequest req)
```

#### Type Parameters

`TResult`<br>

#### Parameters

`req` HttpWebRequest<br>

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
