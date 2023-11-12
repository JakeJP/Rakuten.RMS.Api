<img align="left" style="height: 2em;" src="https://webservice.rakuten.co.jp/favicon.ico"><em>Rakuten RMS WEB API client for .NET</em>

[**< クラス一覧**](./)
- - -

# LicenseManagementAPI

Namespace: Rakuten.RMS.Api.LicenseManagementAPI

```csharp
public class LicenseManagementAPI : Rakuten.RMS.Api.JSON.RakutenApiJsonClientBase
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [RakutenApiClientBaseCommon](./rakuten.rms.api.rest.rakutenapiclientbasecommon) → [RakutenApiJsonClientBase](./rakuten.rms.api.json.rakutenapijsonclientbase) → [LicenseManagementAPI](./rakuten.rms.api.licensemanagementapi.licensemanagementapi)

## Methods

### <a id="methods-getexpirydate"/>**GetExpiryDate(String)**

```csharp
public DateTime GetExpiryDate(string licenseKey)
```

#### Parameters

`licenseKey` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[DateTime](https://docs.microsoft.com/en-us/dotnet/api/system.datetime)

### <a id="methods-getexpirydate"/>**GetExpiryDate()**

現在接続に使用している licenseKey の有効期限を取得。

```csharp
public DateTime GetExpiryDate()
```

#### Returns

[DateTime](https://docs.microsoft.com/en-us/dotnet/api/system.datetime)


- - -
[**< クラス一覧**](./)
