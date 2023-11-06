[`< Back`](./)

---

# LicenseManagementAPI

Namespace: Rakuten.RMS.Api.LicenseManagementAPI

```csharp
public class LicenseManagementAPI : Rakuten.RMS.Api.JSON.RakutenApiJsonClientBase
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [RakutenApiClientBaseCommon](./rakuten.rms.api.rest.rakutenapiclientbasecommon) → [RakutenApiJsonClientBase](./rakuten.rms.api.json.rakutenapijsonclientbase) → [LicenseManagementAPI](./rakuten.rms.api.licensemanagementapi.licensemanagementapi)

## Methods

### **GetExpiryDate(String)**

```csharp
public DateTime GetExpiryDate(string licenseKey)
```

#### Parameters

`licenseKey` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[DateTime](https://docs.microsoft.com/en-us/dotnet/api/system.datetime)<br>

### **GetExpiryDate()**

現在接続に使用している licenseKey の有効期限を取得。

```csharp
public DateTime GetExpiryDate()
```

#### Returns

[DateTime](https://docs.microsoft.com/en-us/dotnet/api/system.datetime)<br>

---

[`< Back`](./)
