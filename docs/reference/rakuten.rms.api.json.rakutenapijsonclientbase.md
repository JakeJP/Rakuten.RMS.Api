[`< Back`](./)

---

# RakutenApiJsonClientBase

Namespace: Rakuten.RMS.Api.JSON

```csharp
public class RakutenApiJsonClientBase
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [RakutenApiJsonClientBase](./rakuten.rms.api.json.rakutenapijsonclientbase)

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

---

[`< Back`](./)
