[`< Back`](./)

---

# ItemAPI

Namespace: Rakuten.RMS.Api.ItemAPI

```csharp
public class ItemAPI : Rakuten.RMS.Api.XML.RakutenApiXmlClientBase
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [RakutenApiXmlClientBase](./rakuten.rms.api.xml.rakutenapixmlclientbase) → [ItemAPI](./rakuten.rms.api.itemapi.itemapi)

## Constructors

### **ItemAPI(ServiceProvider)**

```csharp
public ItemAPI(ServiceProvider provider)
```

#### Parameters

`provider` [ServiceProvider](./rakuten.rms.api.serviceprovider)<br>

## Methods

### **Get(String)**

```csharp
public GetResponse Get(string itemUrl)
```

#### Parameters

`itemUrl` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[GetResponse](./rakuten.rms.api.itemapi.itemapi.getresponse)<br>

### **UpdateItems(IEnumerable&lt;ItemModelToUpdate&gt;)**

```csharp
public void UpdateItems(IEnumerable<ItemModelToUpdate> items)
```

#### Parameters

`items` [IEnumerable&lt;ItemModelToUpdate&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

---

[`< Back`](./)
