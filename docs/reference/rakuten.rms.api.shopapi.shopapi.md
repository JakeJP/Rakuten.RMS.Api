[`< Back`](./)

---

# ShopAPI

Namespace: Rakuten.RMS.Api.ShopAPI

GetLastResult()

```csharp
public class ShopAPI : Rakuten.RMS.Api.XML.RakutenApiXmlClientBase
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [RakutenApiClientBaseCommon](./rakuten.rms.api.rest.rakutenapiclientbasecommon) → [RakutenApiXmlClientBase](./rakuten.rms.api.xml.rakutenapixmlclientbase) → [ShopAPI](./rakuten.rms.api.shopapi.shopapi)

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

### **HandleResponse&lt;TResult, TErrorResult&gt;(HttpWebRequest)**

```csharp
protected TResult HandleResponse<TResult, TErrorResult>(HttpWebRequest req)
```

#### Type Parameters

`TResult`<br>

`TErrorResult`<br>

#### Parameters

`req` HttpWebRequest<br>

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

### **GetLayoutTextSmall(Nullable&lt;Int32&gt;)**

共通説明文（小）の情報を取得

```csharp
public ShopBizApiResponseWithResult<LayoutTextSmallBizModel> GetLayoutTextSmall(Nullable<int> textSmallId)
```

#### Parameters

`textSmallId` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

#### Returns

[ShopBizApiResponseWithResult&lt;LayoutTextSmallBizModel&gt;](./rakuten.rms.api.shopapi.shopbizapiresponsewithresult-1)<br>

### **GetLayoutLossLeader(Nullable&lt;Int32&gt;)**

目玉商品（PC）のテンプレート設定情報のみを取得

```csharp
public IList<LayoutLossLeader> GetLayoutLossLeader(Nullable<int> lossLeaderId)
```

#### Parameters

`lossLeaderId` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
lossLeaderId

#### Returns

[IList&lt;LayoutLossLeader&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

### **GetLayoutItemMap(Nullable&lt;Int32&gt;)**

商品ページ表示項目並び順の情報を取得

```csharp
public IList<LayoutItemMap> GetLayoutItemMap(Nullable<int> itemMapId)
```

#### Parameters

`itemMapId` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

#### Returns

[IList&lt;LayoutItemMap&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

### **GetLayoutCategoryMap(Nullable&lt;Int32&gt;)**

カテゴリページ表示項目並び順の情報を取得

```csharp
public IList<LayoutCategoryMap> GetLayoutCategoryMap(Nullable<int> categoryMapId)
```

#### Parameters

`categoryMapId` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

#### Returns

[IList&lt;LayoutCategoryMap&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

### **GetShopCalendar(Nullable&lt;DateTime&gt;, Nullable&lt;Int32&gt;)**

営業日カレンダー設定・ショップからの重要なお知らせの情報を取得

```csharp
public ShopCalendar2 GetShopCalendar(Nullable<DateTime> fromDate, Nullable<int> period)
```

#### Parameters

`fromDate` [Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`period` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
取得する期間を指定します。(fromDate ～ fromDate + period)
 デフォルト値は90日。
 最大値は180日。

#### Returns

[ShopCalendar2](./rakuten.rms.api.shopapi.shopcalendar2)<br>

### **GetDelvdateMaster(String)**

納期情報設定の情報を取得

```csharp
public IList<DelvdateMaster> GetDelvdateMaster(string delvdateNumber)
```

#### Parameters

`delvdateNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
指定したdelvdateNumberの情報を取得します。指定しない場合はすべての納期情報設定の情報を取得します。

#### Returns

[IList&lt;DelvdateMaster&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

### **GetDeliverySetInfo(Nullable&lt;Int32&gt;)**

```csharp
public IList<DeliverySetInfo> GetDeliverySetInfo(Nullable<int> deliverySetId)
```

#### Parameters

`deliverySetId` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

#### Returns

[IList&lt;DeliverySetInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

### **GetSoryoKbn(Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;)**

```csharp
public SoryoKbnBizModel GetSoryoKbn(Nullable<int> kbnId, Nullable<int> id)
```

#### Parameters

`kbnId` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`id` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

#### Returns

[SoryoKbnBizModel](./rakuten.rms.api.shopapi.soryokbnbizmodel)<br>

### **GetShopAreaSoryo(Nullable&lt;Int32&gt;)**

```csharp
public ShopAreaSoryoWrapper GetShopAreaSoryo(Nullable<int> patternId)
```

#### Parameters

`patternId` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

#### Returns

[ShopAreaSoryoWrapper](./rakuten.rms.api.shopapi.shopareasoryowrapper)<br>

### **EditShopAreaSoryo(ShopAreaSoryoWrapperBizModel)**

```csharp
public ShopBizApiResponse EditShopAreaSoryo(ShopAreaSoryoWrapperBizModel model)
```

#### Parameters

`model` [ShopAreaSoryoWrapperBizModel](./rakuten.rms.api.shopapi.shopareasoryowrapperbizmodel)<br>

#### Returns

[ShopBizApiResponse](./rakuten.rms.api.shopapi.shopbizapiresponse)<br>

### **GetDelvAreaMaster(Nullable&lt;Int32&gt;)**

```csharp
public DelvAreaMasterBizModel GetDelvAreaMaster(Nullable<int> delvAreaId)
```

#### Parameters

`delvAreaId` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

#### Returns

[DelvAreaMasterBizModel](./rakuten.rms.api.shopapi.delvareamasterbizmodel)<br>

### **GetLayoutTextLarge()**

```csharp
public LayoutTextLargeBizModel GetLayoutTextLarge()
```

#### Returns

[LayoutTextLargeBizModel](./rakuten.rms.api.shopapi.layouttextlargebizmodel)<br>

### **EditLayoutTextLarge(LayoutTextLargeBizModel)**

```csharp
public ShopBizApiResponse EditLayoutTextLarge(LayoutTextLargeBizModel model)
```

#### Parameters

`model` [LayoutTextLargeBizModel](./rakuten.rms.api.shopapi.layouttextlargebizmodel)<br>

#### Returns

[ShopBizApiResponse](./rakuten.rms.api.shopapi.shopbizapiresponse)<br>

### **GetGoldTop()**

```csharp
public GoldTopBizModel GetGoldTop()
```

#### Returns

[GoldTopBizModel](./rakuten.rms.api.shopapi.goldtopbizmodel)<br>

### **EditGoldTop(GoldTopBizModel)**

```csharp
public ShopBizApiResponse EditGoldTop(GoldTopBizModel model)
```

#### Parameters

`model` [GoldTopBizModel](./rakuten.rms.api.shopapi.goldtopbizmodel)<br>

#### Returns

[ShopBizApiResponse](./rakuten.rms.api.shopapi.shopbizapiresponse)<br>

### **GetShopMaster()**

```csharp
public ShopMasterBizModel GetShopMaster()
```

#### Returns

[ShopMasterBizModel](./rakuten.rms.api.shopapi.shopmasterbizmodel)<br>

### **GetShopCalendarAndDesign()**

```csharp
public ShopCalendarAndDesignBizModel GetShopCalendarAndDesign()
```

#### Returns

[ShopCalendarAndDesignBizModel](./rakuten.rms.api.shopapi.shopcalendaranddesignbizmodel)<br>

### **EditShopCalendarAndDesign(ShopCalendarAndDesignBizModel, Nullable&lt;Boolean&gt;)**

営業日カレンダー・カレンダーデザイン設定を登録・更新・削除

```csharp
public ShopBizApiResponse EditShopCalendarAndDesign(ShopCalendarAndDesignBizModel model, Nullable<bool> clearCalendar)
```

#### Parameters

`model` [ShopCalendarAndDesignBizModel](./rakuten.rms.api.shopapi.shopcalendaranddesignbizmodel)<br>

`clearCalendar` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
clearCalendar=trueを年中無休フラグ（nonHolidayFlag=1）と合わせて使用します。

#### Returns

[ShopBizApiResponse](./rakuten.rms.api.shopapi.shopbizapiresponse)<br>

### **GetShopHoliday()**

```csharp
public ShopHolidayBizModel GetShopHoliday()
```

#### Returns

[ShopHolidayBizModel](./rakuten.rms.api.shopapi.shopholidaybizmodel)<br>

### **EditShopHoliday(ShopHolidayBizModel)**

```csharp
public ShopBizApiResponse EditShopHoliday(ShopHolidayBizModel model)
```

#### Parameters

`model` [ShopHolidayBizModel](./rakuten.rms.api.shopapi.shopholidaybizmodel)<br>

#### Returns

[ShopBizApiResponse](./rakuten.rms.api.shopapi.shopbizapiresponse)<br>

### **GetSpBigBanner()**

```csharp
public SpBigBannerBizModel GetSpBigBanner()
```

#### Returns

[SpBigBannerBizModel](./rakuten.rms.api.shopapi.spbigbannerbizmodel)<br>

### **EditSpBigBanner(SpBigBannerBizModel)**

```csharp
public ShopBizApiResponse EditSpBigBanner(SpBigBannerBizModel model)
```

#### Parameters

`model` [SpBigBannerBizModel](./rakuten.rms.api.shopapi.spbigbannerbizmodel)<br>

#### Returns

[ShopBizApiResponse](./rakuten.rms.api.shopapi.shopbizapiresponse)<br>

### **GetSpCategoryPage()**

```csharp
public SpCategoryPageBizModel GetSpCategoryPage()
```

#### Returns

[SpCategoryPageBizModel](./rakuten.rms.api.shopapi.spcategorypagebizmodel)<br>

### **EditSpCategoryPage(SpCategoryPageBizModel)**

```csharp
public void EditSpCategoryPage(SpCategoryPageBizModel model)
```

#### Parameters

`model` [SpCategoryPageBizModel](./rakuten.rms.api.shopapi.spcategorypagebizmodel)<br>

### **GetSpItemPage()**

```csharp
public SpItemPageBizModel GetSpItemPage()
```

#### Returns

[SpItemPageBizModel](./rakuten.rms.api.shopapi.spitempagebizmodel)<br>

### **EditSpItemPage(SpItemPageBizModel)**

```csharp
public ShopBizApiResponse EditSpItemPage(SpItemPageBizModel model)
```

#### Parameters

`model` [SpItemPageBizModel](./rakuten.rms.api.shopapi.spitempagebizmodel)<br>

#### Returns

[ShopBizApiResponse](./rakuten.rms.api.shopapi.shopbizapiresponse)<br>

### **GetSpMedamaCategory()**

```csharp
public SpMedamaCategoryBizModel GetSpMedamaCategory()
```

#### Returns

[SpMedamaCategoryBizModel](./rakuten.rms.api.shopapi.spmedamacategorybizmodel)<br>

### **EditSpMedamaCategory(SpMedamaCategoryBizModel)**

```csharp
public ShopBizApiResponse EditSpMedamaCategory(SpMedamaCategoryBizModel model)
```

#### Parameters

`model` [SpMedamaCategoryBizModel](./rakuten.rms.api.shopapi.spmedamacategorybizmodel)<br>

#### Returns

[ShopBizApiResponse](./rakuten.rms.api.shopapi.shopbizapiresponse)<br>

### **GetSpMedamaItem()**

```csharp
public ShopBizApiResponse GetSpMedamaItem()
```

#### Returns

[ShopBizApiResponse](./rakuten.rms.api.shopapi.shopbizapiresponse)<br>

### **EditSpMedamaItem(SpMedamaItemBizModel)**

```csharp
public ShopBizApiResponse EditSpMedamaItem(SpMedamaItemBizModel model)
```

#### Parameters

`model` [SpMedamaItemBizModel](./rakuten.rms.api.shopapi.spmedamaitembizmodel)<br>

#### Returns

[ShopBizApiResponse](./rakuten.rms.api.shopapi.shopbizapiresponse)<br>

### **GetSpSmallBanner()**

```csharp
public SpSmallBannerBizModel GetSpSmallBanner()
```

#### Returns

[SpSmallBannerBizModel](./rakuten.rms.api.shopapi.spsmallbannerbizmodel)<br>

### **EditSpSmallBanner(SpSmallBannerBizModel)**

```csharp
public ShopBizApiResponse EditSpSmallBanner(SpSmallBannerBizModel model)
```

#### Parameters

`model` [SpSmallBannerBizModel](./rakuten.rms.api.shopapi.spsmallbannerbizmodel)<br>

#### Returns

[ShopBizApiResponse](./rakuten.rms.api.shopapi.shopbizapiresponse)<br>

### **GetSpTopPage()**

```csharp
public SpTopPageBizModel GetSpTopPage()
```

#### Returns

[SpTopPageBizModel](./rakuten.rms.api.shopapi.sptoppagebizmodel)<br>

### **EditSpTopPage(SpTopPageBizModel)**

```csharp
public ShopBizApiResponse EditSpTopPage(SpTopPageBizModel model)
```

#### Parameters

`model` [SpTopPageBizModel](./rakuten.rms.api.shopapi.sptoppagebizmodel)<br>

#### Returns

[ShopBizApiResponse](./rakuten.rms.api.shopapi.shopbizapiresponse)<br>

### **GetSpTopPageDisplay()**

2022年4月18日（月）リリースのスマートフォン用トップページへの切替を行ったかを確認

```csharp
public int GetSpTopPageDisplay()
```

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
0: 従来版スマートフォン用トップページ 1: 2022年4月18日（月）リリースのスマートフォン用トップページ

### **GetShopStatus(String)**

skuMigration：SKU移行
 pcTopMigration：PC用トップページの移行

```csharp
public ShopStatusBizModel GetShopStatus(string statusKey)
```

#### Parameters

`statusKey` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[ShopStatusBizModel](./rakuten.rms.api.shopapi.shopstatusbizmodel)<br>

### **EditShopStatus(String, ShopStatus)**

```csharp
public ShopBizApiResponse EditShopStatus(string statusKey, ShopStatus status)
```

#### Parameters

`statusKey` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`status` [ShopStatus](./rakuten.rms.api.shopapi.shopstatus)<br>

#### Returns

[ShopBizApiResponse](./rakuten.rms.api.shopapi.shopbizapiresponse)<br>

### **GetOperationLeadTime(Nullable&lt;Int32&gt;)**

この機能を利用すると、出荷リードタイムを取得することができます。※SKU移行後の店舗様向けの機能です。

```csharp
public IList<OperationLeadTime> GetOperationLeadTime(Nullable<int> id)
```

#### Parameters

`id` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

#### Returns

[IList&lt;OperationLeadTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

### **GetShipFrom(Nullable&lt;Int32&gt;)**

出荷元住所を取得

```csharp
public void GetShipFrom(Nullable<int> shipFromId)
```

#### Parameters

`shipFromId` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **GetSignboard()**

スマートフォン用・PC用新店舗トップページの看板画像URLを取

```csharp
public ShopBizApiResponseWithResult<SignboardBizModel> GetSignboard()
```

#### Returns

[ShopBizApiResponseWithResult&lt;SignboardBizModel&gt;](./rakuten.rms.api.shopapi.shopbizapiresponsewithresult-1)<br>

### **EditSignboard(String, String)**

スマートフォン用小バナー設定の情報を登録・更新・削除・表示順変更

```csharp
public ShopBizApiResponse EditSignboard(string spSignboardUrl, string pcSignboardUrl)
```

#### Parameters

`spSignboardUrl` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`pcSignboardUrl` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[ShopBizApiResponse](./rakuten.rms.api.shopapi.shopbizapiresponse)<br>

---

[`< Back`](./)
