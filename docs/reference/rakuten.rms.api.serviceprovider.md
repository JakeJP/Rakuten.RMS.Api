<img align="left" style="height: 2em;" src="https://webservice.rakuten.co.jp/favicon.ico"><em>Rakuten RMS WEB API client for .NET</em>

[**< クラス一覧**](./)
- - -

# ServiceProvider

Namespace: Rakuten.RMS.Api

APIへのアクセスを提供する。アクセスキーとして serviceSecret, licenseKey の２つが必要。
 APIのグループごとにGet***メソッドでグループごとのAPIアクセスのためのクラスを取得する。

```csharp
public class ServiceProvider
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ServiceProvider](./rakuten.rms.api.serviceprovider)

## Properties

### <a id="properties-getcategoryapi"/>**GetCategoryAPI**

```csharp
public CategoryAPI GetCategoryAPI { get; }
```

#### Property Value

[CategoryAPI](./rakuten.rms.api.categoryapi.categoryapi)<br>

## Constructors

### <a id="constructors-.ctor"/>**ServiceProvider(String, String)**

serviceSecret と licenseKey.
 または serviceSecret = [serviceSecret]:[licenseKey], licenseKey = null の組み合わせも可能

```csharp
public ServiceProvider(string serviceSecret, string licenseKey)
```

#### Parameters

`serviceSecret` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`licenseKey` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="constructors-.ctor"/>**ServiceProvider(NameValueCollection)**

```csharp
public ServiceProvider(NameValueCollection registry)
```

#### Parameters

`registry` NameValueCollection<br>

## Methods

### <a id="methods-getcabinetapi"/>**GetCabinetAPI()**

R-CabinetAPI（CabinetAPI）

```csharp
public CabinetAPI GetCabinetAPI()
```

#### Returns

[CabinetAPI](./rakuten.rms.api.cabinetapi.cabinetapi)

### <a id="methods-getcategoryapi20"/>**GetCategoryAPI20()**

カテゴリAPI 2.0（CategoryAPI 2.0）

```csharp
public CategoryAPI20 GetCategoryAPI20()
```

#### Returns

[CategoryAPI20](./rakuten.rms.api.categoryapi20.categoryapi20)

### <a id="methods-getcouponapi"/>**GetCouponAPI()**

クーポンAPI（CouponAPI）

```csharp
public CouponAPI GetCouponAPI()
```

#### Returns

[CouponAPI](./rakuten.rms.api.couponapi.couponapi)

#### Exceptions

[NotImplementedException](https://docs.microsoft.com/en-us/dotnet/api/system.notimplementedexception)<br>

### <a id="methods-getinquirymanagementapi"/>**GetInquiryManagementAPI()**

問い合わせ管理API（InquiryManagementAPI）

```csharp
public InquiryManagementAPI GetInquiryManagementAPI()
```

#### Returns

[InquiryManagementAPI](./rakuten.rms.api.inquirymanagementapi.inquirymanagementapi)

#### Exceptions

[NotImplementedException](https://docs.microsoft.com/en-us/dotnet/api/system.notimplementedexception)<br>

### <a id="methods-getinventoryapi20"/>**GetInventoryAPI20()**

在庫API 2.0（InventoryAPI 2.0）

```csharp
public RakutenInventoryServiceV2 GetInventoryAPI20()
```

#### Returns

[RakutenInventoryServiceV2](./rakuten.rms.api.inventoryapi20.rakuteninventoryservicev2)

### <a id="methods-getinventoryapi21"/>**GetInventoryAPI21()**

在庫API 在庫API 2.1（InventoryAPI 2.1）

```csharp
public RakutenInventoryServiceV21 GetInventoryAPI21()
```

#### Returns

[RakutenInventoryServiceV21](./rakuten.rms.api.inventoryapi21.rakuteninventoryservicev21)

### <a id="methods-getitemapi"/>**GetItemAPI()**

```csharp
public ItemAPI GetItemAPI()
```

#### Returns

[ItemAPI](./rakuten.rms.api.itemapi.itemapi)

### <a id="methods-getitemapi20"/>**GetItemAPI20()**

商品API 2.0（ItemAPI 2.0）

```csharp
public ItemAPI20 GetItemAPI20()
```

#### Returns

[ItemAPI20](./rakuten.rms.api.itemapi20.itemapi20)

### <a id="methods-getitembundleapi"/>**GetItemBundleAPI()**

組み合わせ販売API（ItemBundleAPI））

```csharp
public ItemBundleAPI GetItemBundleAPI()
```

#### Returns

[ItemBundleAPI](./rakuten.rms.api.itembundleapi.itembundleapi)

### <a id="methods-getlicensemanagementapi"/>**GetLicenseManagementAPI()**

ライセンス管理API（LicenseManagementAPI）

```csharp
public LicenseManagementAPI GetLicenseManagementAPI()
```

#### Returns

[LicenseManagementAPI](./rakuten.rms.api.licensemanagementapi.licensemanagementapi)

### <a id="methods-getnavigationapi20"/>**GetNavigationAPI20()**

ナビゲーションAPI ジャンル・商品属性情報検索API（NavigationAPI 2.0）

```csharp
public NavigationAPI20 GetNavigationAPI20()
```

#### Returns

[NavigationAPI20](./rakuten.rms.api.navigationapi20.navigationapi20)

### <a id="methods-getproductapi"/>**GetProductAPI()**

製品API（ProductAPI）

```csharp
public ProductAPI GetProductAPI()
```

#### Returns

[ProductAPI](./rakuten.rms.api.productapi.productapi)

### <a id="methods-getpurchaseitemapi"/>**GetPurchaseItemAPI()**

購入商品API（PurchaseItemAPI）

```csharp
public PurchaseItemAPI GetPurchaseItemAPI()
```

#### Returns

[PurchaseItemAPI](./rakuten.rms.api.purchaseitemapi.purchaseitemapi)

#### Exceptions

[NotImplementedException](https://docs.microsoft.com/en-us/dotnet/api/system.notimplementedexception)<br>

### <a id="methods-getrakutenpayorderapi"/>**GetRakutenPayOrderAPI()**

楽天ペイ受注API（RakutenPayOrderAPI）

```csharp
public RakutenPayOrderService GetRakutenPayOrderAPI()
```

#### Returns

[RakutenPayOrderService](./rakuten.rms.api.rakutenpayorderapi.rakutenpayorderservice)

### <a id="methods-getreserveapi"/>**GetReserveAPI()**

購入申込API（ReserveAPI）

```csharp
public ReserveAPI GetReserveAPI()
```

#### Returns

[ReserveAPI](./rakuten.rms.api.reserveapi.reserveapi)

#### Exceptions

[NotImplementedException](https://docs.microsoft.com/en-us/dotnet/api/system.notimplementedexception)<br>

### <a id="methods-getshopapi"/>**GetShopAPI()**

店舗情報API（ShopAPI）

```csharp
public ShopAPI GetShopAPI()
```

#### Returns

[ShopAPI](./rakuten.rms.api.shopapi.shopapi)

### <a id="methods-getshoppageapi"/>**GetShopPageAPI()**

店舗ページAPI（ShopPageAPI）

```csharp
public ShopPageAPI GetShopPageAPI()
```

#### Returns

[ShopPageAPI](./rakuten.rms.api.shoppageapi.shoppageapi)

#### Exceptions

[NotImplementedException](https://docs.microsoft.com/en-us/dotnet/api/system.notimplementedexception)<br>


- - -
[**< クラス一覧**](./)
