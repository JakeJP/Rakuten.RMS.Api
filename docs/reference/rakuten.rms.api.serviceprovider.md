[`< Back`](./)

---

# ServiceProvider

Namespace: Rakuten.RMS.Api

APIへのアクセスを提供する。アクセスキーとして serviceSecret, licenseKey の２つが必要。
 APIのグループごとにGet***メソッドでグループごとのAPIアクセスのためのクラスを取得する。

```csharp
public class ServiceProvider
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ServiceProvider](./rakuten.rms.api.serviceprovider)

## Properties

### **GetCategoryAPI**

```csharp
public CategoryAPI GetCategoryAPI { get; }
```

#### Property Value

[CategoryAPI](./rakuten.rms.api.categoryapi.categoryapi)<br>

## Constructors

### **ServiceProvider(String, String)**

serviceSecret と licenseKey.
 または serviceSecret = [serviceSecret]:[licenseKey], licenseKey = null の組み合わせも可能

```csharp
public ServiceProvider(string serviceSecret, string licenseKey)
```

#### Parameters

`serviceSecret` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`licenseKey` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ServiceProvider(NameValueCollection)**

```csharp
public ServiceProvider(NameValueCollection registry)
```

#### Parameters

`registry` NameValueCollection<br>

## Methods

### **GetItemAPI20()**

商品API 2.0（ItemAPI 2.0）

```csharp
public ItemAPI20 GetItemAPI20()
```

#### Returns

[ItemAPI20](./rakuten.rms.api.itemapi20.itemapi20)<br>

### **GetItemAPI()**

```csharp
public ItemAPI GetItemAPI()
```

#### Returns

[ItemAPI](./rakuten.rms.api.itemapi.itemapi)<br>

### **GetCategoryAPI20()**

カテゴリAPI 2.0（CategoryAPI 2.0）

```csharp
public CategoryAPI20 GetCategoryAPI20()
```

#### Returns

[CategoryAPI20](./rakuten.rms.api.categoryapi20.categoryapi20)<br>

### **GetInventoryAPI21()**

在庫API 在庫API 2.1（InventoryAPI 2.1）

```csharp
public RakutenInventoryServiceV21 GetInventoryAPI21()
```

#### Returns

[RakutenInventoryServiceV21](./rakuten.rms.api.inventoryapi21.rakuteninventoryservicev21)<br>

### **GetInventoryAPI20()**

在庫API 2.0（InventoryAPI 2.0）

```csharp
public RakutenInventoryServiceV2 GetInventoryAPI20()
```

#### Returns

[RakutenInventoryServiceV2](./rakuten.rms.api.inventoryapi20.rakuteninventoryservicev2)<br>

### **GetNavigationAPI20()**

ナビゲーションAPI ジャンル・商品属性情報検索API（NavigationAPI 2.0）

```csharp
public NavigationAPI20 GetNavigationAPI20()
```

#### Returns

[NavigationAPI20](./rakuten.rms.api.navigationapi20.navigationapi20)<br>

### **GetItemBundleAPI()**

組み合わせ販売API（ItemBundleAPI））

```csharp
public void GetItemBundleAPI()
```

#### Exceptions

[NotImplementedException](https://docs.microsoft.com/en-us/dotnet/api/system.notimplementedexception)<br>

### **GetCabinetAPI()**

R-CabinetAPI（CabinetAPI）

```csharp
public CabinetAPI GetCabinetAPI()
```

#### Returns

[CabinetAPI](./rakuten.rms.api.cabinetapi.cabinetapi)<br>

### **GetProductAPI()**

製品API（ProductAPI）

```csharp
public ProductAPI GetProductAPI()
```

#### Returns

[ProductAPI](./rakuten.rms.api.productapi.productapi)<br>

### **GetRakutenPayOrderAPI()**

楽天ペイ受注API（RakutenPayOrderAPI）

```csharp
public RakutenPayOrderService GetRakutenPayOrderAPI()
```

#### Returns

[RakutenPayOrderService](./rakuten.rms.api.rakutenpayorderapi.rakutenpayorderservice)<br>

### **GetPurchaseItemAPI()**

購入商品API（PurchaseItemAPI）

```csharp
public PurchaseItemAPI GetPurchaseItemAPI()
```

#### Returns

[PurchaseItemAPI](./rakuten.rms.api.purchaseitemapi.purchaseitemapi)<br>

#### Exceptions

[NotImplementedException](https://docs.microsoft.com/en-us/dotnet/api/system.notimplementedexception)<br>

### **GetReserveAPI()**

購入申込API（ReserveAPI）

```csharp
public ReserveAPI GetReserveAPI()
```

#### Returns

[ReserveAPI](./rakuten.rms.api.reserveapi.reserveapi)<br>

#### Exceptions

[NotImplementedException](https://docs.microsoft.com/en-us/dotnet/api/system.notimplementedexception)<br>

### **GetInquiryManagementAPI()**

問い合わせ管理API（InquiryManagementAPI）

```csharp
public InquiryManagementAPI GetInquiryManagementAPI()
```

#### Returns

[InquiryManagementAPI](./rakuten.rms.api.inquirymanagementapi.inquirymanagementapi)<br>

#### Exceptions

[NotImplementedException](https://docs.microsoft.com/en-us/dotnet/api/system.notimplementedexception)<br>

### **GetShopAPI()**

店舗情報API（ShopAPI）

```csharp
public ShopAPI GetShopAPI()
```

#### Returns

[ShopAPI](./rakuten.rms.api.shopapi.shopapi)<br>

### **GetShopPageAPI()**

店舗ページAPI（ShopPageAPI）

```csharp
public void GetShopPageAPI()
```

#### Exceptions

[NotImplementedException](https://docs.microsoft.com/en-us/dotnet/api/system.notimplementedexception)<br>

### **GetCouponAPI()**

クーポンAPI（CouponAPI）

```csharp
public void GetCouponAPI()
```

#### Exceptions

[NotImplementedException](https://docs.microsoft.com/en-us/dotnet/api/system.notimplementedexception)<br>

### **GetLicenseManagementAPI()**

ライセンス管理API（LicenseManagementAPI）

```csharp
public LicenseManagementAPI GetLicenseManagementAPI()
```

#### Returns

[LicenseManagementAPI](./rakuten.rms.api.licensemanagementapi.licensemanagementapi)<br>

---

[`< Back`](./)
