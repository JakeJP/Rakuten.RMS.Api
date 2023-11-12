<img align="left" style="height: 2em;" src="https://webservice.rakuten.co.jp/favicon.ico"><em>Rakuten RMS WEB API client for .NET</em>

[**< クラス一覧**](./)
- - -

# ShopAPI

Namespace: Rakuten.RMS.Api.ShopAPI

GetLastResult()

```csharp
public class ShopAPI : Rakuten.RMS.Api.XML.RakutenApiXmlClientBase
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [RakutenApiClientBaseCommon](./rakuten.rms.api.rest.rakutenapiclientbasecommon) → [RakutenApiXmlClientBase](./rakuten.rms.api.xml.rakutenapixmlclientbase) → [ShopAPI](./rakuten.rms.api.shopapi.shopapi)

## Fields

### <a id="fields-modelnamespace"/>**ModelNamespace**

```csharp
public static string ModelNamespace;
```

## Properties

### <a id="properties-lastresult"/>**LastResult**

```csharp
public ShopBizApiResponse LastResult { get; protected set; }
```

#### Property Value

[ShopBizApiResponse](./rakuten.rms.api.shopapi.shopbizapiresponse)<br>

## Methods

### <a id="methods-editgoldtop"/>**EditGoldTop(GoldTopBizModel)**

```csharp
public ShopBizApiResponse EditGoldTop(GoldTopBizModel model)
```

#### Parameters

`model` [GoldTopBizModel](./rakuten.rms.api.shopapi.goldtopbizmodel)<br>

#### Returns

[ShopBizApiResponse](./rakuten.rms.api.shopapi.shopbizapiresponse)

### <a id="methods-editlayouttextlarge"/>**EditLayoutTextLarge(LayoutTextLargeBizModel)**

```csharp
public ShopBizApiResponse EditLayoutTextLarge(LayoutTextLargeBizModel model)
```

#### Parameters

`model` [LayoutTextLargeBizModel](./rakuten.rms.api.shopapi.layouttextlargebizmodel)<br>

#### Returns

[ShopBizApiResponse](./rakuten.rms.api.shopapi.shopbizapiresponse)

### <a id="methods-editnavibutton"/>**EditNaviButton(NaviButtonBizModelRequest)**

```csharp
public ShopBizApiResponseWithResult<NaviButtonBizModel> EditNaviButton(NaviButtonBizModelRequest request)
```

#### Parameters

`request` [NaviButtonBizModelRequest](./rakuten.rms.api.shopapi.navibuttonbizmodelrequest)<br>

#### Returns

[ShopBizApiResponseWithResult&lt;NaviButtonBizModel&gt;](./rakuten.rms.api.shopapi.shopbizapiresponsewithresult-1)

### <a id="methods-editnavibuttoninfo"/>**EditNaviButtonInfo(NaviButtonInfoBizModelRequest)**

```csharp
public ShopBizApiResponseWithResult<ShopLayoutCommonBizModel> EditNaviButtonInfo(NaviButtonInfoBizModelRequest request)
```

#### Parameters

`request` [NaviButtonInfoBizModelRequest](./rakuten.rms.api.shopapi.navibuttoninfobizmodelrequest)<br>

#### Returns

[ShopBizApiResponseWithResult&lt;ShopLayoutCommonBizModel&gt;](./rakuten.rms.api.shopapi.shopbizapiresponsewithresult-1)

### <a id="methods-editshopareasoryo"/>**EditShopAreaSoryo(ShopAreaSoryoWrapperBizModel)**

```csharp
public ShopBizApiResponse EditShopAreaSoryo(ShopAreaSoryoWrapperBizModel model)
```

#### Parameters

`model` [ShopAreaSoryoWrapperBizModel](./rakuten.rms.api.shopapi.shopareasoryowrapperbizmodel)<br>

#### Returns

[ShopBizApiResponse](./rakuten.rms.api.shopapi.shopbizapiresponse)

### <a id="methods-editshopcalendaranddesign"/>**EditShopCalendarAndDesign(ShopCalendarAndDesignBizModel, Nullable&lt;Boolean&gt;)**

営業日カレンダー・カレンダーデザイン設定を登録・更新・削除

```csharp
public ShopBizApiResponse EditShopCalendarAndDesign(ShopCalendarAndDesignBizModel model, Nullable<Boolean> clearCalendar)
```

#### Parameters

`model` [ShopCalendarAndDesignBizModel](./rakuten.rms.api.shopapi.shopcalendaranddesignbizmodel)<br>

`clearCalendar` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
clearCalendar=trueを年中無休フラグ（nonHolidayFlag=1）と合わせて使用します。

#### Returns

[ShopBizApiResponse](./rakuten.rms.api.shopapi.shopbizapiresponse)

### <a id="methods-editshopholiday"/>**EditShopHoliday(ShopHolidayBizModel)**

```csharp
public ShopBizApiResponse EditShopHoliday(ShopHolidayBizModel model)
```

#### Parameters

`model` [ShopHolidayBizModel](./rakuten.rms.api.shopapi.shopholidaybizmodel)<br>

#### Returns

[ShopBizApiResponse](./rakuten.rms.api.shopapi.shopbizapiresponse)

### <a id="methods-editshoplayoutcommon"/>**EditShopLayoutCommon(shopLayoutCommonBizModelRequest)**

```csharp
public ShopBizApiResponse<ShopLayoutCommonResultMessage> EditShopLayoutCommon(shopLayoutCommonBizModelRequest request)
```

#### Parameters

`request` [shopLayoutCommonBizModelRequest](./rakuten.rms.api.shopapi.shoplayoutcommonbizmodelrequest)<br>

#### Returns

[ShopBizApiResponse&lt;ShopLayoutCommonResultMessage&gt;](./rakuten.rms.api.shopapi.shopbizapiresponse-1)

### <a id="methods-editshoplayoutimage"/>**EditShopLayoutImage(ShopLayoutImage)**

```csharp
public ShopBizApiResponse EditShopLayoutImage(ShopLayoutImage model)
```

#### Parameters

`model` [ShopLayoutImage](./rakuten.rms.api.shopapi.shoplayoutimage)<br>

#### Returns

[ShopBizApiResponse](./rakuten.rms.api.shopapi.shopbizapiresponse)

### <a id="methods-editshopstatus"/>**EditShopStatus(String, ShopStatus)**

```csharp
public ShopBizApiResponse EditShopStatus(string statusKey, ShopStatus status)
```

#### Parameters

`statusKey` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`status` [ShopStatus](./rakuten.rms.api.shopapi.shopstatus)<br>

#### Returns

[ShopBizApiResponse](./rakuten.rms.api.shopapi.shopbizapiresponse)

### <a id="methods-editsignboard"/>**EditSignboard(String, String)**

スマートフォン用小バナー設定の情報を登録・更新・削除・表示順変更

```csharp
public ShopBizApiResponse EditSignboard(string spSignboardUrl, string pcSignboardUrl)
```

#### Parameters

`spSignboardUrl` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`pcSignboardUrl` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[ShopBizApiResponse](./rakuten.rms.api.shopapi.shopbizapiresponse)

### <a id="methods-editspbigbanner"/>**EditSpBigBanner(SpBigBannerBizModel)**

```csharp
public ShopBizApiResponse EditSpBigBanner(SpBigBannerBizModel model)
```

#### Parameters

`model` [SpBigBannerBizModel](./rakuten.rms.api.shopapi.spbigbannerbizmodel)<br>

#### Returns

[ShopBizApiResponse](./rakuten.rms.api.shopapi.shopbizapiresponse)

### <a id="methods-editspcategorypage"/>**EditSpCategoryPage(SpCategoryPageBizModel)**

```csharp
public void EditSpCategoryPage(SpCategoryPageBizModel model)
```

#### Parameters

`model` [SpCategoryPageBizModel](./rakuten.rms.api.shopapi.spcategorypagebizmodel)<br>

### <a id="methods-editspitempage"/>**EditSpItemPage(SpItemPageBizModel)**

```csharp
public ShopBizApiResponse EditSpItemPage(SpItemPageBizModel model)
```

#### Parameters

`model` [SpItemPageBizModel](./rakuten.rms.api.shopapi.spitempagebizmodel)<br>

#### Returns

[ShopBizApiResponse](./rakuten.rms.api.shopapi.shopbizapiresponse)

### <a id="methods-editspmedamacategory"/>**EditSpMedamaCategory(SpMedamaCategoryBizModel)**

```csharp
public ShopBizApiResponse EditSpMedamaCategory(SpMedamaCategoryBizModel model)
```

#### Parameters

`model` [SpMedamaCategoryBizModel](./rakuten.rms.api.shopapi.spmedamacategorybizmodel)<br>

#### Returns

[ShopBizApiResponse](./rakuten.rms.api.shopapi.shopbizapiresponse)

### <a id="methods-editspmedamaitem"/>**EditSpMedamaItem(SpMedamaItemBizModel)**

```csharp
public ShopBizApiResponse EditSpMedamaItem(SpMedamaItemBizModel model)
```

#### Parameters

`model` [SpMedamaItemBizModel](./rakuten.rms.api.shopapi.spmedamaitembizmodel)<br>

#### Returns

[ShopBizApiResponse](./rakuten.rms.api.shopapi.shopbizapiresponse)

### <a id="methods-editspsmallbanner"/>**EditSpSmallBanner(SpSmallBannerBizModel)**

```csharp
public ShopBizApiResponse EditSpSmallBanner(SpSmallBannerBizModel model)
```

#### Parameters

`model` [SpSmallBannerBizModel](./rakuten.rms.api.shopapi.spsmallbannerbizmodel)<br>

#### Returns

[ShopBizApiResponse](./rakuten.rms.api.shopapi.shopbizapiresponse)

### <a id="methods-editsptoppage"/>**EditSpTopPage(SpTopPageBizModel)**

```csharp
public ShopBizApiResponse EditSpTopPage(SpTopPageBizModel model)
```

#### Parameters

`model` [SpTopPageBizModel](./rakuten.rms.api.shopapi.sptoppagebizmodel)<br>

#### Returns

[ShopBizApiResponse](./rakuten.rms.api.shopapi.shopbizapiresponse)

### <a id="methods-edittopdisplay"/>**EditTopDisplay(TopDisplay)**

```csharp
public ShopBizApiResponse EditTopDisplay(TopDisplay model)
```

#### Parameters

`model` [TopDisplay](./rakuten.rms.api.shopapi.topdisplay)<br>

#### Returns

[ShopBizApiResponse](./rakuten.rms.api.shopapi.shopbizapiresponse)

### <a id="methods-getdeliverysetinfo"/>**GetDeliverySetInfo(Nullable&lt;Int32&gt;)**

```csharp
public IList<DeliverySetInfo> GetDeliverySetInfo(Nullable<Int32> deliverySetId)
```

#### Parameters

`deliverySetId` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

#### Returns

[IList&lt;DeliverySetInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)

### <a id="methods-getdelvareamaster"/>**GetDelvAreaMaster(Nullable&lt;Int32&gt;)**

```csharp
public DelvAreaMasterBizModel GetDelvAreaMaster(Nullable<Int32> delvAreaId)
```

#### Parameters

`delvAreaId` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

#### Returns

[DelvAreaMasterBizModel](./rakuten.rms.api.shopapi.delvareamasterbizmodel)

### <a id="methods-getdelvdatemaster"/>**GetDelvdateMaster(String)**

納期情報設定の情報を取得

```csharp
public IList<DelvdateMaster> GetDelvdateMaster(string delvdateNumber)
```

#### Parameters

`delvdateNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
指定したdelvdateNumberの情報を取得します。指定しない場合はすべての納期情報設定の情報を取得します。

#### Returns

[IList&lt;DelvdateMaster&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)

### <a id="methods-getgoldtop"/>**GetGoldTop()**

```csharp
public GoldTopBizModel GetGoldTop()
```

#### Returns

[GoldTopBizModel](./rakuten.rms.api.shopapi.goldtopbizmodel)

### <a id="methods-getlayoutcategorymap"/>**GetLayoutCategoryMap(Nullable&lt;Int32&gt;)**

カテゴリページ表示項目並び順の情報を取得

```csharp
public IList<LayoutCategoryMap> GetLayoutCategoryMap(Nullable<Int32> categoryMapId)
```

#### Parameters

`categoryMapId` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

#### Returns

[IList&lt;LayoutCategoryMap&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)

### <a id="methods-getlayoutitemmap"/>**GetLayoutItemMap(Nullable&lt;Int32&gt;)**

商品ページ表示項目並び順の情報を取得

```csharp
public IList<LayoutItemMap> GetLayoutItemMap(Nullable<Int32> itemMapId)
```

#### Parameters

`itemMapId` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

#### Returns

[IList&lt;LayoutItemMap&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)

### <a id="methods-getlayoutlossleader"/>**GetLayoutLossLeader(Nullable&lt;Int32&gt;)**

目玉商品（PC）のテンプレート設定情報のみを取得

```csharp
public IList<LayoutLossLeader> GetLayoutLossLeader(Nullable<Int32> lossLeaderId)
```

#### Parameters

`lossLeaderId` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
lossLeaderId

#### Returns

[IList&lt;LayoutLossLeader&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)

### <a id="methods-getlayouttextlarge"/>**GetLayoutTextLarge()**

```csharp
public LayoutTextLargeBizModel GetLayoutTextLarge()
```

#### Returns

[LayoutTextLargeBizModel](./rakuten.rms.api.shopapi.layouttextlargebizmodel)

### <a id="methods-getlayouttextsmall"/>**GetLayoutTextSmall(Nullable&lt;Int32&gt;)**

共通説明文（小）の情報を取得

```csharp
public ShopBizApiResponseWithResult<LayoutTextSmallBizModel> GetLayoutTextSmall(Nullable<Int32> textSmallId)
```

#### Parameters

`textSmallId` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

#### Returns

[ShopBizApiResponseWithResult&lt;LayoutTextSmallBizModel&gt;](./rakuten.rms.api.shopapi.shopbizapiresponsewithresult-1)

### <a id="methods-getnavibutton"/>**GetNaviButton()**

```csharp
public NaviButton GetNaviButton()
```

#### Returns

[NaviButton](./rakuten.rms.api.shopapi.navibutton)

### <a id="methods-getnavibuttoninfo"/>**GetNaviButtonInfo(Nullable&lt;Int64&gt;)**

```csharp
public IList<NaviButtonInfo> GetNaviButtonInfo(Nullable<Int64> naviId)
```

#### Parameters

`naviId` [Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

#### Returns

[IList&lt;NaviButtonInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)

### <a id="methods-getoperationleadtime"/>**GetOperationLeadTime(Nullable&lt;Int32&gt;)**

この機能を利用すると、出荷リードタイムを取得することができます。※SKU移行後の店舗様向けの機能です。

```csharp
public IList<OperationLeadTime> GetOperationLeadTime(Nullable<Int32> id)
```

#### Parameters

`id` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

#### Returns

[IList&lt;OperationLeadTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)

### <a id="methods-getshipfrom"/>**GetShipFrom(Nullable&lt;Int32&gt;)**

出荷元住所を取得

```csharp
public void GetShipFrom(Nullable<Int32> shipFromId)
```

#### Parameters

`shipFromId` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### <a id="methods-getshopareasoryo"/>**GetShopAreaSoryo(Nullable&lt;Int32&gt;)**

```csharp
public ShopAreaSoryoWrapper GetShopAreaSoryo(Nullable<Int32> patternId)
```

#### Parameters

`patternId` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

#### Returns

[ShopAreaSoryoWrapper](./rakuten.rms.api.shopapi.shopareasoryowrapper)

### <a id="methods-getshopcalendar"/>**GetShopCalendar(Nullable&lt;DateTime&gt;, Nullable&lt;Int32&gt;)**

営業日カレンダー設定・ショップからの重要なお知らせの情報を取得

```csharp
public ShopCalendar2 GetShopCalendar(Nullable<DateTime> fromDate, Nullable<Int32> period)
```

#### Parameters

`fromDate` [Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`period` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
取得する期間を指定します。(fromDate ～ fromDate + period)
 デフォルト値は90日。
 最大値は180日。

#### Returns

[ShopCalendar2](./rakuten.rms.api.shopapi.shopcalendar2)

### <a id="methods-getshopcalendaranddesign"/>**GetShopCalendarAndDesign()**

```csharp
public ShopCalendarAndDesignBizModel GetShopCalendarAndDesign()
```

#### Returns

[ShopCalendarAndDesignBizModel](./rakuten.rms.api.shopapi.shopcalendaranddesignbizmodel)

### <a id="methods-getshopholiday"/>**GetShopHoliday()**

```csharp
public ShopHolidayBizModel GetShopHoliday()
```

#### Returns

[ShopHolidayBizModel](./rakuten.rms.api.shopapi.shopholidaybizmodel)

### <a id="methods-getshoplayoutcommon"/>**GetShopLayoutCommon(Nullable&lt;Int64&gt;)**

```csharp
public IList<ShopLayoutCommon> GetShopLayoutCommon(Nullable<Int64> layoutCommonId)
```

#### Parameters

`layoutCommonId` [Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

#### Returns

[IList&lt;ShopLayoutCommon&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)

### <a id="methods-getshoplayoutimage"/>**GetShopLayoutImage()**

```csharp
public ShopLayoutImage GetShopLayoutImage()
```

#### Returns

[ShopLayoutImage](./rakuten.rms.api.shopapi.shoplayoutimage)

### <a id="methods-getshopmaster"/>**GetShopMaster()**

```csharp
public ShopMasterBizModel GetShopMaster()
```

#### Returns

[ShopMasterBizModel](./rakuten.rms.api.shopapi.shopmasterbizmodel)

### <a id="methods-getshopstatus"/>**GetShopStatus(String)**

skuMigration：SKU移行
 pcTopMigration：PC用トップページの移行

```csharp
public ShopStatusBizModel GetShopStatus(string statusKey)
```

#### Parameters

`statusKey` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[ShopStatusBizModel](./rakuten.rms.api.shopapi.shopstatusbizmodel)

### <a id="methods-getsignboard"/>**GetSignboard()**

スマートフォン用・PC用新店舗トップページの看板画像URLを取

```csharp
public ShopBizApiResponseWithResult<SignboardBizModel> GetSignboard()
```

#### Returns

[ShopBizApiResponseWithResult&lt;SignboardBizModel&gt;](./rakuten.rms.api.shopapi.shopbizapiresponsewithresult-1)

### <a id="methods-getsoryokbn"/>**GetSoryoKbn(Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;)**

```csharp
public SoryoKbnBizModel GetSoryoKbn(Nullable<Int32> kbnId, Nullable<Int32> id)
```

#### Parameters

`kbnId` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`id` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

#### Returns

[SoryoKbnBizModel](./rakuten.rms.api.shopapi.soryokbnbizmodel)

### <a id="methods-getspbigbanner"/>**GetSpBigBanner()**

```csharp
public SpBigBannerBizModel GetSpBigBanner()
```

#### Returns

[SpBigBannerBizModel](./rakuten.rms.api.shopapi.spbigbannerbizmodel)

### <a id="methods-getspcategorypage"/>**GetSpCategoryPage()**

```csharp
public SpCategoryPageBizModel GetSpCategoryPage()
```

#### Returns

[SpCategoryPageBizModel](./rakuten.rms.api.shopapi.spcategorypagebizmodel)

### <a id="methods-getspitempage"/>**GetSpItemPage()**

```csharp
public SpItemPageBizModel GetSpItemPage()
```

#### Returns

[SpItemPageBizModel](./rakuten.rms.api.shopapi.spitempagebizmodel)

### <a id="methods-getspmedamacategory"/>**GetSpMedamaCategory()**

```csharp
public SpMedamaCategoryBizModel GetSpMedamaCategory()
```

#### Returns

[SpMedamaCategoryBizModel](./rakuten.rms.api.shopapi.spmedamacategorybizmodel)

### <a id="methods-getspmedamaitem"/>**GetSpMedamaItem()**

```csharp
public ShopBizApiResponse GetSpMedamaItem()
```

#### Returns

[ShopBizApiResponse](./rakuten.rms.api.shopapi.shopbizapiresponse)

### <a id="methods-getspsmallbanner"/>**GetSpSmallBanner()**

```csharp
public SpSmallBannerBizModel GetSpSmallBanner()
```

#### Returns

[SpSmallBannerBizModel](./rakuten.rms.api.shopapi.spsmallbannerbizmodel)

### <a id="methods-getsptoppage"/>**GetSpTopPage()**

```csharp
public SpTopPageBizModel GetSpTopPage()
```

#### Returns

[SpTopPageBizModel](./rakuten.rms.api.shopapi.sptoppagebizmodel)

### <a id="methods-getsptoppagedisplay"/>**GetSpTopPageDisplay()**

2022年4月18日（月）リリースのスマートフォン用トップページへの切替を行ったかを確認

```csharp
public int GetSpTopPageDisplay()
```

#### Returns

0: 従来版スマートフォン用トップページ 1: 2022年4月18日（月）リリースのスマートフォン用トップページ

### <a id="methods-gettopdisplay"/>**GetTopDisplay()**

```csharp
public TopDisplay GetTopDisplay()
```

#### Returns

[TopDisplay](./rakuten.rms.api.shopapi.topdisplay)


- - -
[**< クラス一覧**](./)
