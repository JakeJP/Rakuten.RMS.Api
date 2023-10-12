# Rakuten RMS WEB API .NET client library

楽天RMS WEB API へ接続するための .NET Framework クライアント用ライブラリです。

楽天RMSは楽天出店者が商品や注文の管理を行うウェブプラットフォームです。RMSでは出店者用にWEB APIが公開されており
APIを通じて商品、注文、在庫などほとんどの管理を行うことができます。

本ライブラリは、このRMS WEB APIへ接続をサポートする .NET Framework で動作するクライアントライブラリです。


本ライブラリは楽天RMS APIへ接続する社内受注管理システムの開発、評価のために作られました。

サーバーサイドAPIと、その仕様、関連するドキュメントは楽天が所有するものであり、それらの詳細については楽天RMS
で参照してください。なお楽天RMS APIの利用について、楽天と正式な契約関係のある開発者を支援することを前提としています。

**本ライブラリは楽天とは一切関係がありません。動作の安定性、整合性など、楽天の認証や監修を受けたものではありません。このライブラリについて楽天へ問い合わせ等は遠慮ください。**

また、RMS APIの仕様、動作などに関する当方へのお問合せもご遠慮ください。

未完成部分の実装、バグの修正など、外部からのコミット(push)は常に歓迎します。

## 履歴

- 2023-09-30 最初のコミット

## Copyright and license

Copyright (c) 2023 Jake Yoshimura, Yokinsoft.
Released under MIT license.

https://opensource.org/license/mit/

## 動作環境

- .NET Framework 4.8
- Newtonsoft Json.NET (latest version)

## 使い方

### API

ServiceProvider クラスがクライアントの認証情報とカテゴリ別のAPIへアクセスするクラスへのアクセスを提供します。

各カテゴリ別のAPI群へのアクセスは ServiceProvider のメソッドからオブジェクトを取得します。

特定の注文番号を指定して注文データを取得する例。

```csharp
using Rakuten.RMS.Api;

var provider = new ServiceProvider( serviceSecret, licenseKey );
var orderApi = provider.GetRakutenPayOrderAPI();
var orderList = orderApi.GetOrder( new [] { "1234-1234-1234" } );
```

### システム通知イベント

ASP.NETの HTTP ハンドラ内でメッセージの読み込みに対応します。メッセージのハンドリングはメソッドのコールバック内で、開発者が記述します。

```csharp
Notification.HandleOrderNoify(HttpContext.Current.Request, HttpContext.Current.Response,
(model) => {
    var orderNumbers = model.OrderInfoNotifyModel.Select(m => m.OrderNumber).ToList();
});
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
| |items.search   |×
| |items.upsert   |〇
||items.inventory-related-settings.get   |〇
||items.inventory-related-settings.update   |〇
|商品API（ItemAPI）|-  |-
|カテゴリAPI	カテゴリAPI 2.0（CategoryAPI 2.0）| category.shop-categories.get  |〇
||category.shop-categories.insert |〇
||category.shop-categories.update |〇
||category.item-mappings.get |×
||category.item-mappings.upsert |×
||category.item-mappings.delete |×
||category.category-trees.get |〇
||category.category-trees.upsert |×
||category.category-set-lists.get |〇
|カテゴリAPI（CategoryAPI）| - | -
|在庫API	在庫API 2.1（InventoryAPI 2.1）|inventories.variants.get   |〇
||inventories.variants.upsert   |〇
||inventories.variants.delete   |〇
||inventories.bulk.get.range   |×
||inventories.bulk.get   |〇
||inventories.bulk.upsert   |〇
|在庫API 2.0（InventoryAPI 2.0）|inventories.variants.get   |〇
||inventories.variants.upsert   |〇
||inventories.variants.delete   |〇
||inventories.bulk.get.range   |×
||inventories.bulk.get   |〇
||inventories.bulk.upsert   |〇
|在庫API（InventoryAPI） | - | - 
|ナビゲーションAPI	ジャンル・商品属性情報検索API（NavigationAPI 2.0））|version.get   |〇
||version.get   |〇
||genres.get   |〇
||genres.attributes.get   |〇
||genres.attributes.dictionaryValues.get |〇
|ジャンル・タグ検索API（NavigationAPI）|-   |-
|組み合わせ販売API（ItemBundleAPI））|ItemBundle.create   |×
||ItemBundle.delete   |×
||ItemBundle.getBundleList  |×
||ItemBundle.update   |×
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
|製品API（ProductAPI）|product.search  |×

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
||updateOrderMemo   |×
||updateOrderRemarks   |〇
||updateOrderSender   |×
||updateOrderSenderAfterShipping   |〇
||cancelOrder   |×
||cancelOrderAfterShipping   |〇
||updateOrderOrderer   |×
||updateOrderDelivery   |×
||simulateCouponAmount |〇
||getPayment|×
|購入商品API（PurchaseItemAPI）  |searchOrderItem|×
|| getOrderItem|×
|購入申込API（ReserveAPI）  |reserve.infoList.get|×
||reserve.earlyCommit.update|×
|問い合わせ管理API（InquiryManagementAPI）  |inquirymngapi.counts.get|×
||inquirymngapi.inquiries.get|×
||inquirymngapi.inquiry.get|×
||inquirymngapi.reply.post|×
||inquirymngapi.attachment.post|×
||inquirymngapi.attachment.get|×
||inquirymngapi.inquiries.patch.read|×
||inquirymngapi.inquiries.patch.complete/incomplete|×


### 店舗情報

| API   |   メソッド|   実装
| --- | --- | ---
|店舗情報API（ShopAPI）|	shop.topDisplay.get	| ×
||	shop.topDisplay.edit	| ×
||	shop.shopLayoutImage.get	| ×
||	shop.shopLayoutImage.edit	| ×
||	shop.shopLayoutCommon.get	| ×
||	shop.shopLayoutCommon.edit	| ×
||	shop.naviButtonInfo.get	| ×
||	shop.naviButtonInfo.edit	| ×
||	shop.naviButton.get	| ×
||	shop.naviButton.edit	| ×
||	shop.layoutTextSmall.get	| ×
||	shop.layoutLossLeader.get	| ×
||	shop.layoutItemMap.get	| ×
||	shop.layoutCategoryMap.get	| ×
||	shop.shopCalendar.get	| ×
||	shop.delvdateMaster.get	| 〇
||	shop.deliverySetInfo.get	| ×
||	shop.soryoKbn.get	| ×
||	shop.shopAreaSoryo.get	| ×
||	shop.shopAreaSoryo.edit	| ×
||	shop.delvAreaMaster.get	| ×
||	shop.layoutTextLarge.get	| ×
||	shop.layoutTextLarge.edit	| ×
||	shop.goldTop.get	| ×
||	shop.goldTop.edit	| ×
||	shop.shopMaster.get	| ×
||	shop.shopCalendarAndDesign.get	| ×
||	shop.shopCalendarAndDesign.edit	| ×
||	shop.shopHoliday.get	| ×
||	shop.shopHoliday.edit	| ×
||	shop.spBigBanner.get	| ×
||	shop.spBigBanner.edit	| ×
||	shop.spCategoryPage.get	| ×
||	shop.spCategoryPage.edit	| ×
||	shop.spItemPage.get	| ×
||	shop.spItemPage.edit	| ×
||	shop.spMedamaCategory.get	| ×
||	shop.spMedamaCategory.edit	| ×
||	shop.spMedamaItem.get	| ×
||	shop.spMedamaItem.edit	| ×
||	shop.spSmallBanner.get	| ×
||	shop.spSmallBanner.edit	| ×
||	shop.spTopPage.get	| ×
||	shop.spTopPage.edit	| ×
||	shop.spTopPageDisplay.get	| ×
||	shop.shopStatus.get	| ×
||	shop.shopStatus.edit	| ×
||	shop.operationLeadTime.get	| 〇
||	shop.shipFrom.get	| ×
||	shop.signboard.get	| ×
||	shop.signboard.edit	| ×
|店舗ページAPI（ShopPageAPI）|| ×
||ShopPage.navigations.insert| ×
||ShopPage.navigations.list| ×
||ShopPage.navigations.get| ×
||ShopPage.navigations.update| ×
||ShopPage.widgets.insert| ×
||ShopPage.widgets.list| ×
||ShopPage.widgets.get| ×
||ShopPage.widgets.update| ×
||ShopPage.widgets.delete| ×
||ShopPage.layouts.insert| ×
||ShopPage.layouts.list| ×
||ShopPage.layouts.published.list| ×
||ShopPage.layouts.get| ×
||ShopPage.layouts.replace| ×
||ShopPage.layouts.update| ×
||ShopPage.layouts.delete| ×
|クーポンAPI（CouponAPI）|coupon.issue| ×
||coupon.update| ×
||coupon.delete| ×
||coupon.get| ×
||coupon.search| ×
||thankscoupon.issue| ×
||thankscoupon.update| ×
||thankscoupon.stop| ×
||thankscoupon.get| ×
||thankscoupon.search| ×
|ライセンス管理API（LicenseManagementAPI）|license.expiryDate.get| 〇

### その他

| API   |   メソッド|   実装
| --- | --- | ---
|システムイベント通知サービス（System Event Notification Service）


