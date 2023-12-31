# Rakuten.RMS.Api client library for .NET Framework

楽天RMS WEB API へ接続するための .NET Framework クライアント用ライブラリです。

楽天RMSは楽天出店者が商品や注文の管理を行うウェブプラットフォームです。RMSでは出店者用にWEB APIが公開されており
APIを通じて商品、注文、在庫などほとんどの管理を行うことができます。

本ライブラリは、このRMS WEB APIへ接続をサポートする .NET Framework で動作するクライアントライブラリです。

## 動作環境

- .NET Framework 4.8
- Newtonsoft Json.NET (latest version)
- (Python.NET)

.NET Framework 4.8 環境で動作確認しています。メッセージの JSON 処理に Json.NET を使用しています。
また、Python.NET を使うことで、python からこのライブラリを使用することができます。

[python (Python.NET) での使用方法について](./Python)


## 使用方法

[全クラスリファレンス](./reference/index)

ServiceProvider クラスがクライアントの認証情報とカテゴリ別のAPIへアクセスするクラスへのアクセスを提供します。

```csharp
using Rakuten.RMS.Api;
var provider = new ServiceProvider( serviceSecret, licenseKey );
```

serviceSecret と licenseKey はRMSのAPI設定から取得できる認証用の文字列です。

各カテゴリ別のAPI群へのアクセスは ServiceProvider のメソッドからオブジェクトを取得します。APIの分類別にアクセスするためのクラスが対応します。

```csharp
var api = provider.GetItemAPI20();
```


| RMS WEB API カテゴリ | ServiceProvider メソッド | 対応クラス |
|:---|:---|:---
| 商品API<br/>	[商品API 2.0（ItemAPI 2.0）](ItemAPI20)| GetItemAPI20() | [ItemAPI20.ItemAPI20](./reference/rakuten.rms.api.itemapi20.itemapi20)
| カテゴリAPI<br/>	[カテゴリAPI 2.0（CategoryAPI 2.0）](./CategoryAPI20)| GetCategoryAPI20() | [CategoryAPI20.CategoryAPI20](./reference/rakuten.rms.api.categoryapi20.categoryapi20)
| [在庫API	在庫API 2.1（InventoryAPI 2.1）](./InventoryAPI21)| GetInventoryAPI21() | [InventoryAPI21.RakutenInventoryServiceV21](./reference/rakuten.rms.api.inventoryapi21.rakuteninventoryservicev21)
| [在庫API 2.0（InventoryAPI 2.0）](./InventoryAPI21)| GetInventoryAPI20() | [InventoryAPI20.RakutenInventoryServiceV2](./reference/rakuten.rms.api.inventoryapi20.rakuteninventoryservicev2)
| ナビゲーションAPI	ジャンル・商品属性情報検索API（NavigationAPI 2.0）| GetNavigationAPI20() | [NavigationAPI20.NavigationAPI20](./reference/rakuten.rms.api.navigationapi20.navigationapi20)
| 組み合わせ販売API（ItemBundleAPI））| GetItemBundleAPI() | [ItemBundleAPI.ItemBundleAPI](./reference/rakuten.rms.api.itembundleapi.bundleitemapi)
| [R-CabinetAPI（CabinetAPI）](./CabinetAPI) | GetCabinetAPI() | [CabinetAPI.CabinetAPI](./reference/rakuten.rms.api.cabinetapi.cabinetapi)
| [製品API（ProductAPI）](./ProductAPI)| GetProductAPI() | [ProductAPI.ProductAPI](./reference/rakuten.rms.api.productapi.productapi)
| [楽天ペイ受注API（RakutenPayOrderAPI）](./RakutenPayOrderAPI)| GetRakutenPayOrderAPI() | [RakutenPayOrderAPI.RakutenPayOrderService](./reference/rakuten.rms.api.rakutenpayorderapi.rakutenpayorderservice)
| [購入商品API（PurchaseItemAPI）](./PurchaseItemAPI)  | GetPurchaseItemAPI() | [PurchaseItemAPI.PurchaseItemAPI](./reference/rakuten.rms.api.purchaseitemapi.purchaseitemapi)
| [購入申込API（ReserveAPI）](./ReserveAPI)  | GetReserveAPI() | [ReserveAPI.ReserveAPI](./reference/rakuten.rms.api.reserveapi.reserveapi)
| 問い合わせ管理API（InquiryManagementAPI）  | GetInquiryManagementAPI() | [InquiryManagementAPI.InquiryManagementAPI](./reference/rakuten.rms.api.inquirymanagementapi.inquirymanagementapi)
| [店舗情報API（ShopAPI）](ShopAPI)| GetShopAPI() | [ShopAPI.ShopAPI](./reference/rakuten.rms.api.shopapi.shopapi)
| 店舗ページAPI（ShopPageAPI）| GetShopPageAPI() | [ShopPageAPI.ShopPageAPI](./reference/rakuten.rms.api.shoppageapi.shoppageapi)
| [クーポンAPI（CouponAPI）](CouponAPI)| GetCouponAPI() | [CouponAPI.CouponAPI](./reference/rakuten.rms.api.couponapi.couponapi)
| ライセンス管理API（LicenseManagementAPI）| GetLicenseManagementAPI() | [LicenseManagementAPI.LicenseManagementAPI](./reference/rakuten.rms.api.licensemanagementapi.licensemanagementapi)

## メソッドの実装ルール

APIグループごとに、設計上の違いから、メソッドの命名方法、エラー処理等に関して作法の違いがあります。.NET への実装は基本的に次のようなルールに則っています。

- オリジナルの仕様で定義されている内容を尊重
- C# 形式、また　[動詞][目的語] (GetItemなど) の順になるように定義しなおし
- メソッド名やオブジェクト名で、一部直感的に理解しにくいもの、英語の単数形・複数形の違いが実際に即していないものなど、あえて名前を変える
- １つのメソッド呼び出しで、複数の種類の情報が取得できる場合、メソッドを別々に実装して １メソッド、1種類の情報の取得を原則とする。
- パラメータが少ない場合は、リクエストをクラスオブジェクトにまとめるのではなく、メソッドのパラメータとして展開

## エラー処理

エラーの形式はAPIグループごとに異なり、そのフォーマット、エラーコードの定義などもそれぞれ異なり統一されいません。このAPIライブラリでは基本的な考え方として、正常時以外はすべて例外として throw することにしています。一部のAPIグループでは、応答メッセージの中にエラーが内包されるものがあります。この場合はエラーであっても例外にならず応答メッセージをそのまま返す仕様となっています。

### RakuteRMSApiException

[`class RakutenRMSApiException`](./reference/rakuten.rms.api.rakutenrmsapiexception) がすべての例外のベースクラスとなっています。この例外を捕捉することでエラー処理を行うことができます。HTTPなどネットワークレベルのエラーの場合 .NET の `System.Net.WebException` などの例外が飛ぶことがあります。

各APIグループごとのエラーのフォーマットに対応するため各APIグループごとに
`RakuteRMSApiException` の派生クラスを定義している場合があります。より詳細なえらーを参照するためには個別の例外クラスを捕捉します。

# グループ別解説とクラスリファレンス

## Rakuten.RMS.Api.CabinetAPI

[CabinetAPI](./CabinetAPI)

[CabinetAPI クラスリファレンス](./reference/rakuten.rms.api.cabinetapi.cabinetapi)

## Rakuten.RMS.Api.CategoryAPI20

[CategoryAPI20](./CategoryAPI20)

[CategoryAPI20 クラスリファレンス](./reference/rakuten.rms.api.categoryapi20.categoryapi20)

## Rakuten.RMS.Api.InventoryAPI20

[InventoryAPI20](./InventoryAPI21)

[RakutenInventoryServiceV2 クラスリファレンス](./reference/rakuten.rms.api.inventoryapi20.rakuteninventoryservicev2)

## Rakuten.RMS.Api.InventoryAPI21

[InventoryAPI20](./InventoryAPI21)

[RakutenInventoryServiceV21 クラスリファレンス](./reference/rakuten.rms.api.inventoryapi21.rakuteninventoryservicev21)

## Rakuten.RMS.Api.ItemAPI20

[ItemAPI20](./ItemAPI20)

[ItemAPI20 クラスリファレンス](./reference/rakuten.rms.api.itemapi20.itemapi20)

## Rakuten.RMS.Api.LicenseManagementAPI

[LicenseManagementAPI](./LicenseManagement)

[LicenseManagementAPI クラスリファレンス](./reference/rakuten.rms.api.licensemanagementapi.licensemanagementapi)

## Rakuten.RMS.Api.NavigationAPI20

[NavigationAPI20 クラスリファレンス](./reference/rakuten.rms.api.navigationapi20.navigationapi20)

## Rakuten.RMS.Api.ProductAPI

[ProductAPI](./ProductAPI)

[ProductAPI クラスリファレンス](./reference/rakuten.rms.api.productapi.productapi)

## Rakuten.RMS.Api.RakutenPayOrderAPI

[RakutenPayOrderAPI](./RakutenPayOrderAPI)

[RakutenPayOrderService クラスリファレンス](./reference/rakuten.rms.api.rakutenpayorderapi.rakutenpayorderservice)


## Rakuten.RMS.Api.PurchaseItemAPI

[購入商品API（PurchaseItemAPI）](./PurchaseItemAPI)

[PurchaseItemAPI クラスリファレンス](./reference/rakuten.rms.api.purchaseitemapi.purchaseitemapi)

## Rakuten.RMS.Api.ShopAPI

[ShopAPI クラスリファレンス](./reference/rakuten.rms.api.shopapi.shopapi)

## Rakuten.RMS.Api.ShopPageAPI

[ShopPageAPI クラスリファレンス](./reference/rakuten.rms.api.shoppageapi.shoppageapi)

## Rakuten.RMS.Api.SystemEventNotification

[Rakuten.RMS.Api.SystemEventNotification.Notification](./reference/rakuten.rms.api.systemeventnotification.notification)