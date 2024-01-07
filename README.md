# Rakuten RMS WEB API .NET client library

楽天RMS WEB API へ接続するための .NET Framework クライアント用ライブラリです。

楽天RMSは楽天出店者が商品や注文の管理を行うウェブプラットフォームです。RMSでは出店者用にWEB APIが公開されており
APIを通じて商品、注文、在庫などほとんどの管理を行うことができます。

本ライブラリは、このRMS WEB APIへ接続をサポートする .NET Framework で動作するクライアントライブラリです。Python.NET を使用すると Python から API を利用することもできます。

煩雑な通信部分、メッセージの読み書き部分を内蔵しているため、プログラマーは用途に合ったロジックの構築に集中できます。

-------

本ライブラリは楽天RMS APIへ接続する社内受注管理システムの開発、評価のために作られました。

サーバーサイドAPIと、その仕様、関連するドキュメントは楽天が所有するものであり、それらの詳細については楽天RMS
で参照してください。なお楽天RMS APIの利用について、楽天と正式な契約関係のある開発者を支援することを前提としています。

**本ライブラリは楽天とは一切関係がありません。動作の安定性、整合性など、楽天の認証や監修を受けたものではありません。このライブラリについて楽天へ問い合わせ等は遠慮ください。**

また、RMS APIの仕様、動作などに関する当方へのお問合せもご遠慮ください。

本ライブラリについての議論、未完成部分の実装、バグの報告・修正など、外部からのコミット(pull request等)は常に歓迎します。

## 履歴

- 2024-01-07 システムイベント系DLL分離とバグ修正
- 2023-11-10 全メソッドの実装
- 2023-11-01 ドキュメント類追加
- 2023-09-30 最初のコミット

## Copyright and license

Copyright (c) 2023 Jake Yoshimura, Yokinsoft.
Released under MIT license.

https://opensource.org/license/mit/

## 動作環境

- .NET Framework 4.8
- Newtonsoft Json.NET (latest version)
- (Python.NET)


## 使い方

[詳細なドキュメントはこちら](https://jakejp.github.io/Rakuten.RMS.Api/)

### API

ServiceProvider クラスがクライアントの認証情報とカテゴリ別のAPIへアクセスするクラスへのアクセスを提供します。

```csharp
var provider = new ServiceProvider( serviceSecret, licenseKey );
```

serviceSecret と licenseKey はRMSのAPI設定から取得できる認証用の文字列です。


各カテゴリ別のAPI群へのアクセスは ServiceProvider のメソッドからオブジェクトを取得します。APIの分類別にアクセスするためのクラスが対応します。

| RMS WEB API カテゴリ | ServiceProvider メソッド | 対応クラス |
|:---|:---|:---
| 商品API<br/>	[商品API 2.0（ItemAPI 2.0）](https://jakejp.github.io/Rakuten.RMS.Api/ItemAPI20)| GetItemAPI20() | [ItemAPI20.ItemAPI20](https://jakejp.github.io/Rakuten.RMS.Api/reference/rakuten.rms.api.itemapi20.itemapi20)
| カテゴリAPI<br/>	[カテゴリAPI 2.0（CategoryAPI 2.0）](https://jakejp.github.io/Rakuten.RMS.Api/CategoryAPI20)| GetCategoryAPI20() | [CategoryAPI20.CategoryAPI20](https://jakejp.github.io/Rakuten.RMS.Api/reference/rakuten.rms.api.categoryapi20.categoryapi20)
| [在庫API	在庫API 2.1（InventoryAPI 2.1）](https://jakejp.github.io/Rakuten.RMS.Api/InventoryAPI21)| GetInventoryAPI21() | [InventoryAPI21.RakutenInventoryServiceV21](https://jakejp.github.io/Rakuten.RMS.Api/reference/rakuten.rms.api.inventoryapi21.rakuteninventoryservicev21)
| [在庫API 2.0（InventoryAPI 2.0）](https://jakejp.github.io/Rakuten.RMS.Api/InventoryAPI21)| GetInventoryAPI20() | [InventoryAPI20.RakutenInventoryServiceV2](https://jakejp.github.io/Rakuten.RMS.Api/reference/rakuten.rms.api.inventoryapi20.rakuteninventoryservicev2)
| ナビゲーションAPI	ジャンル・商品属性情報検索API（NavigationAPI 2.0）| GetNavigationAPI20() | [NavigationAPI20.NavigationAPI20](https://jakejp.github.io/Rakuten.RMS.Api/reference/rakuten.rms.api.navigationapi20.navigationapi20)
| 組み合わせ販売API（ItemBundleAPI）| GetItemBundleAPI() | [ItemBundleAPI.ItemBundleAPI](https://jakejp.github.io/Rakuten.RMS.Api/reference/rakuten.rms.api.itembundleapi.bundleitemapi)
| [R-CabinetAPI（CabinetAPI）](https://jakejp.github.io/Rakuten.RMS.Api/CabinetAPI) | GetCabinetAPI() | [CabinetAPI.CabinetAPI](https://jakejp.github.io/Rakuten.RMS.Api/reference/rakuten.rms.api.cabinetapi.cabinetapi)
| [製品API（ProductAPI）](https://jakejp.github.io/Rakuten.RMS.Api/ProductAPI)| GetProductAPI() | [ProductAPI.ProductAPI](https://jakejp.github.io/Rakuten.RMS.Api/reference/rakuten.rms.api.productapi.productapi)
| [楽天ペイ受注API（RakutenPayOrderAPI）](https://jakejp.github.io/Rakuten.RMS.Api/RakutenPayOrderAPI)| GetRakutenPayOrderAPI() | [RakutenPayOrderAPI.RakutenPayOrderService](https://jakejp.github.io/Rakuten.RMS.Api/reference/rakuten.rms.api.rakutenpayorderapi.rakutenpayorderservice)
| [購入商品API（PurchaseItemAPI）](https://jakejp.github.io/Rakuten.RMS.Api/PurchaseItemAPI)  | GetPurchaseItemAPI() | [PurchaseItemAPI.PurchaseItemAPI](https://jakejp.github.io/Rakuten.RMS.Api/reference/rakuten.rms.api.purchaseitemapi.purchaseitemapi)
| [購入申込API（ReserveAPI）](https://jakejp.github.io/Rakuten.RMS.Api/ReserveAPI)  | GetReserveAPI() | [ReserveAPI.ReserveAPI](https://jakejp.github.io/Rakuten.RMS.Api/reference/rakuten.rms.api.reserveapi.reserveapi)
| 問い合わせ管理API（InquiryManagementAPI）  | GetInquiryManagementAPI() | [InquiryManagementAPI.InquiryManagementAPI](https://jakejp.github.io/Rakuten.RMS.Api/reference/rakuten.rms.api.inquirymanagementapi.inquirymanagementapi)
| [店舗情報API（ShopAPI）](https://jakejp.github.io/Rakuten.RMS.Api/ShopAPI)| GetShopAPI() | [ShopAPI.ShopAPI](https://jakejp.github.io/Rakuten.RMS.Api/reference/rakuten.rms.api.shopapi.shopapi)
| 店舗ページAPI（ShopPageAPI）| GetShopPageAPI() | [ShopPageAPI.ShopPageAPI](https://jakejp.github.io/Rakuten.RMS.Api/reference/rakuten.rms.api.shoppageapi.shoppageapi)
| [クーポンAPI（CouponAPI）](https://jakejp.github.io/Rakuten.RMS.Api/CouponAPI)| GetCouponAPI() | [CouponAPI.CouponAPI](https://jakejp.github.io/Rakuten.RMS.Api/reference/rakuten.rms.api.couponapi.couponapi)
| ライセンス管理API（LicenseManagementAPI）| GetLicenseManagementAPI() | [LicenseManagementAPI.LicenseManagementAPI](https://jakejp.github.io/Rakuten.RMS.Api/reference/rakuten.rms.api.licensemanagementapi.licensemanagementapi)

API呼び出しメソッドは、基本的にサービスのエンドポイントで定義されている名前を尊重し、C# 形式、また　[動詞][目的語] (GetItemなど)の順になるように定義しなおしています。


## コードサンプル

### 特定の注文番号を指定して注文データを取得する例

```csharp
using Rakuten.RMS.Api;

var provider = new ServiceProvider( "SPxxxxxxxxxxxxxxxxx","SLxxxxxxxxxxxxxx" );
var orderApi = provider.GetRakutenPayOrderAPI();
var orderList = orderApi.GetOrder( new [] { "123456-12341234-1234567890" } );
```

### Python から利用する方法

Python.NET を使用して Python からAPIにアクセスることができます。

[Python.NET を使用して Python から使用するための環境の構築と使用方法の詳細](https://jakejp.github.io/Rakuten.RMS.Api/Python) 

Python から使用では、list や パラメータのクラスオブジェクトの指定が簡単になります。

注文データの取得の例

```python
sp = ServiceProvider('SPxxxxxxxxxxxxxxxxx','SLxxxxxxxxxxxxxx')
api = sp.GetRakutenPayOrderAPI()

orders = api.GetOrder( ["123456-12341234-1234567890"])
```

### システム通知イベント

２種類ある通知メッセージに対応する２つのハンドラーが用意されています。いずれも、ASP.NETの HTTP ハンドラ内でメッセージの読み込みに対応します。
メッセージのハンドリングはメソッドのコールバック内で、開発者が記述します。

Rakuten.RMS.Api.SystemEventNotification.dll をプロジェクトから参照

注文通知系

```csharp
public static void HandleOrderNoify(HttpRequest request, HttpResponse response, Func<OrderNotifyModel, ResultCode> handler)
```

システム情報系

```csharp
public static void HandleSystemInfoNotify(HttpRequest request, HttpResponse response, Func<SystemNotifyModel, ResultCode> handler)
```

#### 例

```csharp
Notification.HandleOrderNoify(HttpContext.Current.Request, HttpContext.Current.Response,
    (model) => {
        // 任意の実装
        var orderNumbers = model.OrderInfoNotifyModel.Select(m => m.OrderNumber).ToList();
    }
);
```

## 実装状況

現在、すべてのAPIとメソッドが実装されているわけではありません。
当面は最新バージョンのAPIのみの実装を目標とします。
SOAP形式など旧来のAPIや廃止されたAPIの実装は省略します。

### 商品・画像管理

| API   |   メソッド |   実装
| --- | --- | ---
| 商品API	商品API 2.0（ItemAPI 2.0）| items.get   |〇
| |items.upsert   |〇
| |items.patch   |〇
| |items.delete   |〇
| |items.search   |〇
||items.inventory-related-settings.get   |〇
||items.inventory-related-settings.update   |〇
|カテゴリAPI	カテゴリAPI 2.0（CategoryAPI 2.0）| category.shop-categories.get  |〇
||category.shop-categories.insert |〇
||category.shop-categories.update |〇
||category.item-mappings.get |〇
||category.item-mappings.upsert |〇
||category.item-mappings.delete |〇
||category.category-trees.get |〇
||category.category-trees.upsert |〇
||category.category-set-lists.get |〇
|在庫API	在庫API 2.1（InventoryAPI 2.1）|inventories.variants.get   |〇
||inventories.variants.upsert   |〇
||inventories.variants.delete   |〇
||inventories.bulk.get.range   |〇
||inventories.bulk.get   |〇
||inventories.bulk.upsert   |〇
|在庫API 2.0（InventoryAPI 2.0）|inventories.variants.get   |〇
||inventories.variants.upsert   |〇
||inventories.variants.delete   |〇
||inventories.bulk.get.range   |〇
||inventories.bulk.get   |〇
||inventories.bulk.upsert   |〇
|ナビゲーションAPI	ジャンル・商品属性情報検索API（NavigationAPI 2.0））|version.get   |〇
||genres.get   |〇
||genres.attributes.get   |〇
||genres.attributes.dictionaryValues.get |〇
|組み合わせ販売API（ItemBundleAPI））|ItemBundle.create   |△
||ItemBundle.delete   |△
||ItemBundle.getBundleList  |△
||ItemBundle.update   |△
|R-CabinetAPI（CabinetAPI）|cabinet.usage.get   |〇
||cabinet.folders.get  |〇
||cabinet.folder.files.get  |〇
||cabinet.files.search  |〇
||cabinet.file.delete  |〇
||cabinet.trashbox.files.get  |〇
||cabinet.trashbox.files.revert  |〇
||cabinet.file.insert  |〇
||cabinet.file.update  |〇
||cabinet.folder.insert  |〇
|製品API（ProductAPI）|product.search  |〇

### 受注・問い合わせ管理

| API   |   メソッド|   実装
| --- | --- | ---
|楽天ペイ受注API（RakutenPayOrderAPI）|searchOrder |〇
||getOrder   |〇
||confirmOrder   |〇
||updateOrdershipping   |〇
||updateOrderShippingAsync   |〇
||getResultUpdateOrderShippingAsync   |〇
||getSubStatusList   |〇
||updateOrderSubStatus   |〇
||updateOrderMemo   |〇
||updateOrderRemarks   |〇
||updateOrderSender   |〇
||updateOrderSenderAfterShipping   |〇
||cancelOrder   |〇
||cancelOrderAfterShipping   |〇
||updateOrderOrderer   |〇
||updateOrderDelivery   |〇
||simulateCouponAmount |〇
||getPayment|〇
|購入商品API（PurchaseItemAPI）  |searchOrderItem|〇
|| getOrderItem|〇
|購入申込API（ReserveAPI）  |reserve.infoList.get|〇
||reserve.earlyCommit.update|〇
|問い合わせ管理API（InquiryManagementAPI）  |inquirymngapi.counts.get|〇
||inquirymngapi.inquiries.get|〇
||inquirymngapi.inquiry.get|〇
||inquirymngapi.reply.post|〇
||inquirymngapi.attachment.post|〇
||inquirymngapi.attachment.get|〇
||inquirymngapi.inquiries.patch.read|〇
||inquirymngapi.inquiries.patch.complete/incomplete|〇


### 店舗情報

| API   |   メソッド|   実装
| --- | --- | ---
|店舗情報API（ShopAPI）|	shop.topDisplay.get	| 〇
||	shop.topDisplay.edit	| 〇
||	shop.shopLayoutImage.get	| 〇
||	shop.shopLayoutImage.edit	| 〇
||	shop.shopLayoutCommon.get	| 〇
||	shop.shopLayoutCommon.edit	| 〇
||	shop.naviButtonInfo.get	| 〇
||	shop.naviButtonInfo.edit	| 〇
||	shop.naviButton.get	| 〇
||	shop.naviButton.edit	| 〇
||	shop.layoutTextSmall.get	| 〇
||	shop.layoutLossLeader.get	| 〇
||	shop.layoutItemMap.get	| 〇
||	shop.layoutCategoryMap.get	| 〇
||	shop.shopCalendar.get	| 〇
||	shop.delvdateMaster.get	| 〇
||	shop.deliverySetInfo.get	| 〇
||	shop.soryoKbn.get	| 〇
||	shop.shopAreaSoryo.get	| 〇
||	shop.shopAreaSoryo.edit	| 〇
||	shop.delvAreaMaster.get	| 〇
||	shop.layoutTextLarge.get	| 〇
||	shop.layoutTextLarge.edit	| 〇
||	shop.goldTop.get	| 〇
||	shop.goldTop.edit	| 〇
||	shop.shopMaster.get	| 〇
||	shop.shopCalendarAndDesign.get	| 〇
||	shop.shopCalendarAndDesign.edit	| 〇
||	shop.shopHoliday.get	| 〇
||	shop.shopHoliday.edit	| 〇
||	shop.spBigBanner.get	| 〇
||	shop.spBigBanner.edit	| 〇
||	shop.spCategoryPage.get	| 〇
||	shop.spCategoryPage.edit	| 〇
||	shop.spItemPage.get	| 〇
||	shop.spItemPage.edit	| 〇
||	shop.spMedamaCategory.get	| 〇
||	shop.spMedamaCategory.edit	| 〇
||	shop.spMedamaItem.get	| 〇
||	shop.spMedamaItem.edit	| 〇
||	shop.spSmallBanner.get	| 〇
||	shop.spSmallBanner.edit	| 〇
||	shop.spTopPage.get	| 〇
||	shop.spTopPage.edit	| 〇
||	shop.spTopPageDisplay.get	| 〇
||	shop.shopStatus.get	| 〇
||	shop.shopStatus.edit	| 〇
||	shop.operationLeadTime.get	| 〇
||	shop.shipFrom.get	| 〇
||	shop.signboard.get	| 〇
||	shop.signboard.edit	| 〇
|店舗ページAPI（ShopPageAPI）|| 〇
||ShopPage.navigations.insert| 〇
||ShopPage.navigations.list| 〇
||ShopPage.navigations.get| 〇
||ShopPage.navigations.update| 〇
||ShopPage.widgets.insert| 〇
||ShopPage.widgets.list| 〇
||ShopPage.widgets.get| 〇
||ShopPage.widgets.update| 〇
||ShopPage.widgets.delete| 〇
||ShopPage.layouts.insert| 〇
||ShopPage.layouts.list| 〇
||ShopPage.layouts.published.list| 〇
||ShopPage.layouts.get| 〇
||ShopPage.layouts.replace| 〇
||ShopPage.layouts.update| 〇
||ShopPage.layouts.delete| 〇
|クーポンAPI（CouponAPI）|coupon.issue| 〇
||coupon.update| 〇
||coupon.delete| 〇
||coupon.get| 〇
||coupon.search| 〇
||thankscoupon.issue| 〇
||thankscoupon.update| 〇
||thankscoupon.stop| 〇
||thankscoupon.get| 〇
||thankscoupon.search| 〇
|ライセンス管理API（LicenseManagementAPI）|license.expiryDate.get| 〇

### その他

| API   |   メソッド|   実装
| --- | --- | ---
|システムイベント通知サービス（System Event Notification Service）| HandleOrderNoify | 〇
| | HandleSystemInfoNotify | 〇


## TODO

- 実装はかなり進みましたが、動作検証がかなり手抜きです。
- 実装途中のプロジェクトのため、メソッドの引数、戻り値など、破壊的な変更が起こりえます。

