<img align="left" style="height: 2em;" src="https://webservice.rakuten.co.jp/favicon.ico"><em>Rakuten RMS WEB API client for .NET</em>

[**< クラス一覧**](./)
- - -

# ShopPageAPI

Namespace: Rakuten.RMS.Api.ShopPageAPI

```csharp
public class ShopPageAPI : Rakuten.RMS.Api.JSON.RakutenApiJsonClientBase
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [RakutenApiClientBaseCommon](./rakuten.rms.api.rest.rakutenapiclientbasecommon) → [RakutenApiJsonClientBase](./rakuten.rms.api.json.rakutenapijsonclientbase) → [ShopPageAPI](./rakuten.rms.api.shoppageapi.shoppageapi)

## Methods

### <a id="methods-deletelayouts"/>**DeleteLayouts(String, LayoutStatus)**

```csharp
public void DeleteLayouts(string layoutId, LayoutStatus status)
```

#### Parameters

`layoutId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`status` [LayoutStatus](./rakuten.rms.api.shoppageapi.layoutstatus)<br>

### <a id="methods-deletewidgets"/>**DeleteWidgets(String)**

```csharp
public void DeleteWidgets(string widgetId)
```

#### Parameters

`widgetId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="methods-getlayouts"/>**GetLayouts(String, LayoutStatus, Nullable&lt;Boolean&gt;)**

```csharp
public Layout GetLayouts(string layoutId, LayoutStatus status, Nullable<Boolean> isFullContents)
```

#### Parameters

`layoutId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`status` [LayoutStatus](./rakuten.rms.api.shoppageapi.layoutstatus)<br>

`isFullContents` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

#### Returns

[Layout](./rakuten.rms.api.shoppageapi.layout)

### <a id="methods-getnavigations"/>**GetNavigations(String)**

```csharp
public Navigation GetNavigations(string navigationId)
```

#### Parameters

`navigationId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[Navigation](./rakuten.rms.api.shoppageapi.navigation)

### <a id="methods-getwidgets"/>**GetWidgets(String)**

```csharp
public void GetWidgets(string widgetId)
```

#### Parameters

`widgetId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="methods-insertlayouts"/>**InsertLayouts(LayoutToRequest, LayoutStatus, Nullable&lt;Boolean&gt;)**

```csharp
public string InsertLayouts(LayoutToRequest layout, LayoutStatus status, Nullable<Boolean> migratePcTopPage)
```

#### Parameters

`layout` [LayoutToRequest](./rakuten.rms.api.shoppageapi.layouttorequest)<br>

`status` [LayoutStatus](./rakuten.rms.api.shoppageapi.layoutstatus)<br>

`migratePcTopPage` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

### <a id="methods-insertnavigations"/>**InsertNavigations(NavigationRequest)**

```csharp
public ResultBase InsertNavigations(NavigationRequest navigation)
```

#### Parameters

`navigation` [NavigationRequest](./rakuten.rms.api.shoppageapi.navigationrequest)<br>

#### Returns

[ResultBase](./rakuten.rms.api.json.resultbase)

### <a id="methods-insertwidgets"/>**InsertWidgets(WidgetToRequest)**

```csharp
public ResultBase InsertWidgets(WidgetToRequest widget)
```

#### Parameters

`widget` [WidgetToRequest](./rakuten.rms.api.shoppageapi.widgettorequest)<br>

#### Returns

[ResultBase](./rakuten.rms.api.json.resultbase)

### <a id="methods-listlayouts"/>**ListLayouts(LayoutStatus)**

```csharp
public IList<Layout> ListLayouts(LayoutStatus status)
```

#### Parameters

`status` [LayoutStatus](./rakuten.rms.api.shoppageapi.layoutstatus)<br>

#### Returns

[IList&lt;Layout&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)

### <a id="methods-listnavigations"/>**ListNavigations()**

```csharp
public IList<Navigation> ListNavigations()
```

#### Returns

[IList&lt;Navigation&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)

### <a id="methods-listpublishedlayouts"/>**ListPublishedLayouts(LayoutType)**

```csharp
public IList<Layout> ListPublishedLayouts(LayoutType layoutType)
```

#### Parameters

`layoutType` [LayoutType](./rakuten.rms.api.shoppageapi.layouttype)<br>

#### Returns

[IList&lt;Layout&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)

### <a id="methods-listwidgets"/>**ListWidgets()**

```csharp
public IList<Widget> ListWidgets()
```

#### Returns

[IList&lt;Widget&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)

### <a id="methods-replacelayouts"/>**ReplaceLayouts(String, LayoutToReplace)**

```csharp
public string ReplaceLayouts(string targetLayoutId, LayoutToReplace layout)
```

#### Parameters

`targetLayoutId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`layout` [LayoutToReplace](./rakuten.rms.api.shoppageapi.layouttoreplace)<br>

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

### <a id="methods-updatelayouts"/>**UpdateLayouts(String, LayoutToReplace)**

```csharp
public void UpdateLayouts(string layoutId, LayoutToReplace layout)
```

#### Parameters

`layoutId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`layout` [LayoutToReplace](./rakuten.rms.api.shoppageapi.layouttoreplace)<br>

### <a id="methods-updatenavigations"/>**UpdateNavigations(String, NavigationRequest)**

```csharp
public ResultBase UpdateNavigations(string navigationId, NavigationRequest navigation)
```

#### Parameters

`navigationId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`navigation` [NavigationRequest](./rakuten.rms.api.shoppageapi.navigationrequest)<br>

#### Returns

[ResultBase](./rakuten.rms.api.json.resultbase)

### <a id="methods-updatewidgets"/>**UpdateWidgets(String, WidgetToRequest)**

```csharp
public ResultBase UpdateWidgets(string widgetId, WidgetToRequest widget)
```

#### Parameters

`widgetId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`widget` [WidgetToRequest](./rakuten.rms.api.shoppageapi.widgettorequest)<br>

#### Returns

[ResultBase](./rakuten.rms.api.json.resultbase)


- - -
[**< クラス一覧**](./)
