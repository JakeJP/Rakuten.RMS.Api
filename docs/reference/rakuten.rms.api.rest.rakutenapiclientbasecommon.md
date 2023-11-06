[`< Back`](./)

---

# RakutenApiClientBaseCommon

Namespace: Rakuten.RMS.Api.REST

```csharp
public abstract class RakutenApiClientBaseCommon
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [RakutenApiClientBaseCommon](./rakuten.rms.api.rest.rakutenapiclientbasecommon)

## Methods

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

### **PostFile&lt;TResult, TErrorResult&gt;(String, Stream, String, String, NameValueCollection)**

```csharp
protected TResult PostFile<TResult, TErrorResult>(string url, Stream fileStream, string paramName, string contentType, NameValueCollection nvc)
```

#### Type Parameters

`TResult`<br>

`TErrorResult`<br>

#### Parameters

`url` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`fileStream` [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)<br>

`paramName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`contentType` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`nvc` NameValueCollection<br>

#### Returns

TResult<br>

### **HandleResponse&lt;TResult, TErrorResult&gt;(HttpWebRequest)**

```csharp
protected abstract TResult HandleResponse<TResult, TErrorResult>(HttpWebRequest req)
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
