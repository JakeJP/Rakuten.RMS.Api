[`< Back`](./)

---

# ShopAPI

Namespace: Rakuten.RMS.Api.ShopAPI

GetLastResult()

```csharp
public class ShopAPI : Rakuten.RMS.Api.XML.RakutenApiXmlClientBase
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [RakutenApiXmlClientBase](./rakuten.rms.api.xml.rakutenapixmlclientbase) → [ShopAPI](./rakuten.rms.api.shopapi.shopapi)

## Fields

### **ModelNamespace**

```csharp
public static string ModelNamespace;
```

## Properties

### **LastResult**

```csharp
public ShopBizApiResponse LastResult { get; protected set; }
```

#### Property Value

[ShopBizApiResponse](./rakuten.rms.api.shopapi.shopbizapiresponse)<br>

## Methods

### **Get&lt;TResult&gt;(String, NameValueCollection)**

```csharp
protected TResult Get<TResult>(string url, NameValueCollection queryParameters)
```

#### Type Parameters

`TResult`<br>

#### Parameters

`url` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`queryParameters` NameValueCollection<br>

#### Returns

TResult<br>

### **GetNamespaces()**

```csharp
protected XmlSerializerNamespaces GetNamespaces()
```

#### Returns

XmlSerializerNamespaces<br>

### **GetTopDisplay()**

```csharp
public TopDisplay GetTopDisplay()
```

#### Returns

[TopDisplay](./rakuten.rms.api.shopapi.topdisplay)<br>

### **EditTopDisplay(TopDisplay)**

```csharp
public ShopBizApiResponse EditTopDisplay(TopDisplay model)
```

#### Parameters

`model` [TopDisplay](./rakuten.rms.api.shopapi.topdisplay)<br>

#### Returns

[ShopBizApiResponse](./rakuten.rms.api.shopapi.shopbizapiresponse)<br>

### **GetShopLayoutImage()**

```csharp
public ShopLayoutImage GetShopLayoutImage()
```

#### Returns

[ShopLayoutImage](./rakuten.rms.api.shopapi.shoplayoutimage)<br>

### **EditShopLayoutImage(ShopLayoutImage)**

```csharp
public ShopBizApiResponse EditShopLayoutImage(ShopLayoutImage model)
```

#### Parameters

`model` [ShopLayoutImage](./rakuten.rms.api.shopapi.shoplayoutimage)<br>

#### Returns

[ShopBizApiResponse](./rakuten.rms.api.shopapi.shopbizapiresponse)<br>

### **GetShopLayoutCommon(Nullable&lt;Int64&gt;)**

```csharp
public IList<ShopLayoutCommon> GetShopLayoutCommon(Nullable<long> layoutCommonId)
```

#### Parameters

`layoutCommonId` [Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

#### Returns

[IList&lt;ShopLayoutCommon&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

### **EditShopLayoutCommon(shopLayoutCommonBizModelRequest)**

```csharp
public ShopBizApiResponse<ShopLayoutCommonResultMessage> EditShopLayoutCommon(shopLayoutCommonBizModelRequest request)
```

#### Parameters

`request` [shopLayoutCommonBizModelRequest](./rakuten.rms.api.shopapi.shoplayoutcommonbizmodelrequest)<br>

#### Returns

[ShopBizApiResponse&lt;ShopLayoutCommonResultMessage&gt;](./rakuten.rms.api.shopapi.shopbizapiresponse-1)<br>

### **GetNaviButtonInfo(Nullable&lt;Int64&gt;)**

```csharp
public IList<NaviButtonInfo> GetNaviButtonInfo(Nullable<long> naviId)
```

#### Parameters

`naviId` [Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

#### Returns

[IList&lt;NaviButtonInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

### **EditNaviButtonInfo(NaviButtonInfoBizModelRequest)**

```csharp
public ShopBizApiResponseWithResult<ShopLayoutCommonBizModel> EditNaviButtonInfo(NaviButtonInfoBizModelRequest request)
```

#### Parameters

`request` [NaviButtonInfoBizModelRequest](./rakuten.rms.api.shopapi.navibuttoninfobizmodelrequest)<br>

#### Returns

[ShopBizApiResponseWithResult&lt;ShopLayoutCommonBizModel&gt;](./rakuten.rms.api.shopapi.shopbizapiresponsewithresult-1)<br>

### **GetNaviButton()**

```csharp
public NaviButton GetNaviButton()
```

#### Returns

[NaviButton](./rakuten.rms.api.shopapi.navibutton)<br>

### **EditNaviButton(NaviButtonBizModelRequest)**

```csharp
public ShopBizApiResponseWithResult<NaviButtonBizModel> EditNaviButton(NaviButtonBizModelRequest request)
```

#### Parameters

`request` [NaviButtonBizModelRequest](./rakuten.rms.api.shopapi.navibuttonbizmodelrequest)<br>

#### Returns

[ShopBizApiResponseWithResult&lt;NaviButtonBizModel&gt;](./rakuten.rms.api.shopapi.shopbizapiresponsewithresult-1)<br>

### **GetLayoutTextSmall()**

```csharp
public void GetLayoutTextSmall()
```

### **GetLayoutLossLeader()**

```csharp
public void GetLayoutLossLeader()
```

### **GetLayoutItemMap()**

```csharp
public void GetLayoutItemMap()
```

### **GetLayoutCategoryMap()**

```csharp
public void GetLayoutCategoryMap()
```

### **GetShopCalendar()**

```csharp
public void GetShopCalendar()
```

### **GetDelvdateMaster(String)**

RMS WEB SERVICE : shop.delvdateMaster.get

```csharp
public IList<DelvdateMaster> GetDelvdateMaster(string delvdateNumber)
```

#### Parameters

`delvdateNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[IList&lt;DelvdateMaster&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

### **GetDeliverySetInfo()**

```csharp
public void GetDeliverySetInfo()
```

### **GetSoryoKbn()**

```csharp
public void GetSoryoKbn()
```

### **GetShopAreaSoryo()**

```csharp
public void GetShopAreaSoryo()
```

### **EditShopAreaSoryo()**

```csharp
public void EditShopAreaSoryo()
```

### **GetDelvAreaMaster()**

```csharp
public void GetDelvAreaMaster()
```

### **GetLayoutTextLarge()**

```csharp
public void GetLayoutTextLarge()
```

### **EditLayoutTextLarge()**

```csharp
public void EditLayoutTextLarge()
```

### **GetGoldTop()**

```csharp
public void GetGoldTop()
```

### **EditGoldTop()**

```csharp
public void EditGoldTop()
```

### **GetShopMaster()**

```csharp
public void GetShopMaster()
```

### **GetShopCalendarAndDesign()**

```csharp
public void GetShopCalendarAndDesign()
```

### **EditShopCalendarAndDesign()**

```csharp
public void EditShopCalendarAndDesign()
```

### **GetShopHoliday()**

```csharp
public void GetShopHoliday()
```

### **EditShopHoliday()**

```csharp
public void EditShopHoliday()
```

### **GetSpBigBanner()**

```csharp
public void GetSpBigBanner()
```

### **EditSpBigBanner()**

```csharp
public void EditSpBigBanner()
```

### **GetSpCategoryPage()**

```csharp
public void GetSpCategoryPage()
```

### **EditSpCategoryPage()**

```csharp
public void EditSpCategoryPage()
```

### **GetSpItemPage()**

```csharp
public void GetSpItemPage()
```

### **EditSpItemPage()**

```csharp
public void EditSpItemPage()
```

### **GetSpMedamaCategory()**

```csharp
public void GetSpMedamaCategory()
```

### **EditSpMedamaCategory()**

```csharp
public void EditSpMedamaCategory()
```

### **GetSpMedamaItem()**

```csharp
public void GetSpMedamaItem()
```

### **EditSpMedamaItem()**

```csharp
public void EditSpMedamaItem()
```

### **GetSpSmallBanner()**

```csharp
public void GetSpSmallBanner()
```

### **EditSpSmallBanner()**

```csharp
public void EditSpSmallBanner()
```

### **GetSpTopPage()**

```csharp
public void GetSpTopPage()
```

### **EditSpTopPage()**

```csharp
public void EditSpTopPage()
```

### **GetSpTopPageDisplay()**

```csharp
public void GetSpTopPageDisplay()
```

### **GetShopStatus()**

```csharp
public void GetShopStatus()
```

### **EditShopStatus()**

```csharp
public void EditShopStatus()
```

### **GetOperationLeadTime(Nullable&lt;Int32&gt;)**

この機能を利用すると、出荷リードタイムを取得することができます。※SKU移行後の店舗様向けの機能です。

```csharp
public IList<OperationLeadTime> GetOperationLeadTime(Nullable<int> id)
```

#### Parameters

`id` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

#### Returns

[IList&lt;OperationLeadTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

### **GetShipFrom()**

```csharp
public void GetShipFrom()
```

### **GetSignboard()**

```csharp
public void GetSignboard()
```

### **EditSignboard()**

```csharp
public void EditSignboard()
```

---

[`< Back`](./)
