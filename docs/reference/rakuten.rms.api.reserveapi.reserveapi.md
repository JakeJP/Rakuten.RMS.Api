<img align="left" style="height: 2em;" src="https://webservice.rakuten.co.jp/favicon.ico"><em>Rakuten RMS WEB API client for .NET</em>

[**< クラス一覧**](./)
- - -

# ReserveAPI

Namespace: Rakuten.RMS.Api.ReserveAPI

```csharp
public class ReserveAPI : Rakuten.RMS.Api.JSON.RakutenApiJsonClientBase
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [RakutenApiClientBaseCommon](./rakuten.rms.api.rest.rakutenapiclientbasecommon) → [RakutenApiJsonClientBase](./rakuten.rms.api.json.rakutenapijsonclientbase) → [ReserveAPI](./rakuten.rms.api.reserveapi.reserveapi)

## Methods

### <a id="methods-getreserveinfolist"/>**GetReserveInfoList(InfoListRequest)**

申込情報一覧を取得

```csharp
public InfoListResponse GetReserveInfoList(InfoListRequest request)
```

#### Parameters

`request` [InfoListRequest](./rakuten.rms.api.reserveapi.infolistrequest)<br>

#### Returns

[InfoListResponse](./rakuten.rms.api.reserveapi.infolistresponse)

### <a id="methods-updatereserveearlycommit"/>**UpdateReserveEarlyCommit(IList&lt;ReserveKeyListModel&gt;)**

一括で早期確定を行う

```csharp
public ReserveUpdateResponse UpdateReserveEarlyCommit(IList<ReserveKeyListModel> reserveKeyList)
```

#### Parameters

`reserveKeyList` [IList&lt;ReserveKeyListModel&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

#### Returns

[ReserveUpdateResponse](./rakuten.rms.api.reserveapi.reserveupdateresponse)


- - -
[**< クラス一覧**](./)
