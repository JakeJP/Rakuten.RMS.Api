<img align="left" style="height: 2em;" src="https://webservice.rakuten.co.jp/favicon.ico"><em>Rakuten RMS WEB API client for .NET</em>

[**< クラス一覧**](./)
- - -

# ItemAPI

Namespace: Rakuten.RMS.Api.ItemAPI

```csharp
public class ItemAPI : Rakuten.RMS.Api.XML.RakutenApiXmlClientBase
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [RakutenApiClientBaseCommon](./rakuten.rms.api.rest.rakutenapiclientbasecommon) → [RakutenApiXmlClientBase](./rakuten.rms.api.xml.rakutenapixmlclientbase) → [ItemAPI](./rakuten.rms.api.itemapi.itemapi)

## Constructors

### <a id="constructors-.ctor"/>**ItemAPI(ServiceProvider)**

```csharp
public ItemAPI(ServiceProvider provider)
```

#### Parameters

`provider` [ServiceProvider](./rakuten.rms.api.serviceprovider)<br>

## Methods

### <a id="methods-get"/>**Get(String)**

```csharp
public GetResponse Get(string itemUrl)
```

#### Parameters

`itemUrl` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[GetResponse](./rakuten.rms.api.itemapi.itemapi.getresponse)

### <a id="methods-updateitems"/>**UpdateItems(IEnumerable&lt;ItemModelToUpdate&gt;)**

```csharp
public void UpdateItems(IEnumerable<ItemModelToUpdate> items)
```

#### Parameters

`items` [IEnumerable&lt;ItemModelToUpdate&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>


- - -
[**< クラス一覧**](./)
