<img align="left" style="height: 2em;" src="https://webservice.rakuten.co.jp/favicon.ico"><em>Rakuten RMS WEB API client for .NET</em>

[**< クラス一覧**](./)
- - -

# ItemBundleAPI

Namespace: Rakuten.RMS.Api.ItemBundleAPI

```csharp
public class ItemBundleAPI : Rakuten.RMS.Api.JSON.RakutenApiJsonClientBase
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [RakutenApiClientBaseCommon](./rakuten.rms.api.rest.rakutenapiclientbasecommon) → [RakutenApiJsonClientBase](./rakuten.rms.api.json.rakutenapijsonclientbase) → [ItemBundleAPI](./rakuten.rms.api.itembundleapi.itembundleapi)

## Methods

### <a id="methods-create"/>**Create(BundleToCreate)**

```csharp
public Bundle Create(BundleToCreate bundle)
```

#### Parameters

`bundle` [BundleToCreate](./rakuten.rms.api.itembundleapi.bundletocreate)<br>

#### Returns

[Bundle](./rakuten.rms.api.itembundleapi.bundle)

### <a id="methods-delete"/>**Delete(String)**

```csharp
public void Delete(string bundleManageNumber)
```

#### Parameters

`bundleManageNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="methods-getbundle"/>**GetBundle(String)**

```csharp
public Bundle GetBundle(string bundleManageNumber)
```

#### Parameters

`bundleManageNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[Bundle](./rakuten.rms.api.itembundleapi.bundle)

### <a id="methods-getbundlelist"/>**GetBundleList(BundleListRequest)**

```csharp
public BundleListResponse GetBundleList(BundleListRequest request)
```

#### Parameters

`request` [BundleListRequest](./rakuten.rms.api.itembundleapi.bundlelistrequest)<br>

#### Returns

[BundleListResponse](./rakuten.rms.api.itembundleapi.bundlelistresponse)

### <a id="methods-update"/>**Update(String, BundleToCreate)**

```csharp
public Bundle Update(string bundleManageNumber, BundleToCreate bundle)
```

#### Parameters

`bundleManageNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`bundle` [BundleToCreate](./rakuten.rms.api.itembundleapi.bundletocreate)<br>

#### Returns

[Bundle](./rakuten.rms.api.itembundleapi.bundle)


- - -
[**< クラス一覧**](./)
