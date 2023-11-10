[`< Back`](./)

---

# ItemBundleAPI

Namespace: Rakuten.RMS.Api.ItemBundleAPI

```csharp
public class ItemBundleAPI : Rakuten.RMS.Api.JSON.RakutenApiJsonClientBase
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [RakutenApiClientBaseCommon](./rakuten.rms.api.rest.rakutenapiclientbasecommon) → [RakutenApiJsonClientBase](./rakuten.rms.api.json.rakutenapijsonclientbase) → [ItemBundleAPI](./rakuten.rms.api.itembundleapi.itembundleapi)

## Methods

### **Create(BundleToCreate)**

```csharp
public Bundle Create(BundleToCreate bundle)
```

#### Parameters

`bundle` [BundleToCreate](./rakuten.rms.api.itembundleapi.bundletocreate)<br>

#### Returns

[Bundle](./rakuten.rms.api.itembundleapi.bundle)<br>

### **Delete(String)**

```csharp
public void Delete(string bundleManageNumber)
```

#### Parameters

`bundleManageNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **GetBundle(String)**

```csharp
public Bundle GetBundle(string bundleManageNumber)
```

#### Parameters

`bundleManageNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[Bundle](./rakuten.rms.api.itembundleapi.bundle)<br>

### **GetBundleList(BundleListRequest)**

```csharp
public BundleListResponse GetBundleList(BundleListRequest request)
```

#### Parameters

`request` [BundleListRequest](./rakuten.rms.api.itembundleapi.bundlelistrequest)<br>

#### Returns

[BundleListResponse](./rakuten.rms.api.itembundleapi.bundlelistresponse)<br>

### **Update(String, BundleToCreate)**

```csharp
public Bundle Update(string bundleManageNumber, BundleToCreate bundle)
```

#### Parameters

`bundleManageNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`bundle` [BundleToCreate](./rakuten.rms.api.itembundleapi.bundletocreate)<br>

#### Returns

[Bundle](./rakuten.rms.api.itembundleapi.bundle)<br>

---

[`< Back`](./)
