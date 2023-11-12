<img align="left" style="height: 2em;" src="https://webservice.rakuten.co.jp/favicon.ico"><em>Rakuten RMS WEB API client for .NET</em>

[**< クラス一覧**](./)
- - -

# CouponAPI

Namespace: Rakuten.RMS.Api.CouponAPI

```csharp
public class CouponAPI : Rakuten.RMS.Api.XML.RakutenApiXmlClientBase
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [RakutenApiClientBaseCommon](./rakuten.rms.api.rest.rakutenapiclientbasecommon) → [RakutenApiXmlClientBase](./rakuten.rms.api.xml.rakutenapixmlclientbase) → [CouponAPI](./rakuten.rms.api.couponapi.couponapi)

## Methods

### <a id="methods-delete"/>**Delete(String)**

```csharp
public void Delete(string couponCode)
```

#### Parameters

`couponCode` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="methods-get"/>**Get(String)**

```csharp
public Coupon Get(string couponCode)
```

#### Parameters

`couponCode` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[Coupon](./rakuten.rms.api.couponapi.coupon)

### <a id="methods-getthankscoupon"/>**GetThanksCoupon(Int64)**

```csharp
public ThanksCouponToIssue GetThanksCoupon(long thanksCouponId)
```

#### Parameters

`thanksCouponId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>

#### Returns

[ThanksCouponToIssue](./rakuten.rms.api.couponapi.thankscoupontoissue)

### <a id="methods-issue"/>**Issue(CouponToIssue)**

```csharp
public IssuedCoupon Issue(CouponToIssue coupon)
```

#### Parameters

`coupon` [CouponToIssue](./rakuten.rms.api.couponapi.coupontoissue)<br>

#### Returns

[IssuedCoupon](./rakuten.rms.api.couponapi.issuedcoupon)

### <a id="methods-issuethankscoupon"/>**IssueThanksCoupon(ThanksCouponToIssue)**

```csharp
public long IssueThanksCoupon(ThanksCouponToIssue coupon)
```

#### Parameters

`coupon` [ThanksCouponToIssue](./rakuten.rms.api.couponapi.thankscoupontoissue)<br>

#### Returns

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)

### <a id="methods-search"/>**Search(SearchCondition)**

```csharp
public SearchResponse Search(SearchCondition condition)
```

#### Parameters

`condition` [SearchCondition](./rakuten.rms.api.couponapi.searchcondition)<br>

#### Returns

[SearchResponse](./rakuten.rms.api.couponapi.searchresponse)

### <a id="methods-searchall"/>**SearchAll(SearchCondition)**

```csharp
public IEnumerable<Coupon> SearchAll(SearchCondition condition)
```

#### Parameters

`condition` [SearchCondition](./rakuten.rms.api.couponapi.searchcondition)<br>

#### Returns

[IEnumerable&lt;Coupon&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)

### <a id="methods-searchallthankscoupon"/>**SearchAllThanksCoupon(SearchThanksCouponCondition)**

```csharp
public IEnumerable<ThanksCoupon> SearchAllThanksCoupon(SearchThanksCouponCondition condition)
```

#### Parameters

`condition` [SearchThanksCouponCondition](./rakuten.rms.api.couponapi.searchthankscouponcondition)<br>

#### Returns

[IEnumerable&lt;ThanksCoupon&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)

### <a id="methods-searchthankscoupon"/>**SearchThanksCoupon(SearchThanksCouponCondition)**

```csharp
public SearchThanksCouponResponse SearchThanksCoupon(SearchThanksCouponCondition condition)
```

#### Parameters

`condition` [SearchThanksCouponCondition](./rakuten.rms.api.couponapi.searchthankscouponcondition)<br>

#### Returns

[SearchThanksCouponResponse](./rakuten.rms.api.couponapi.searchthankscouponresponse)

### <a id="methods-stopthankscoupon"/>**StopThanksCoupon(Int64)**

```csharp
public long StopThanksCoupon(long thanksCouponId)
```

#### Parameters

`thanksCouponId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>

#### Returns

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)

### <a id="methods-update"/>**Update(Coupon)**

```csharp
public void Update(Coupon coupon)
```

#### Parameters

`coupon` [Coupon](./rakuten.rms.api.couponapi.coupon)<br>

### <a id="methods-updatethankscoupon"/>**UpdateThanksCoupon(Int64, ThanksCouponToIssue)**

```csharp
public long UpdateThanksCoupon(long thanksCouponId, ThanksCouponToIssue coupon)
```

#### Parameters

`thanksCouponId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>

`coupon` [ThanksCouponToIssue](./rakuten.rms.api.couponapi.thankscoupontoissue)<br>

#### Returns

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)


- - -
[**< クラス一覧**](./)
