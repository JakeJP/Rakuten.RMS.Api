<img align="left" style="height: 2em;" src="https://webservice.rakuten.co.jp/favicon.ico"><em>Rakuten RMS WEB API client for .NET</em>

[**< クラス一覧**](./)
- - -

# RakutenPayOrderService

Namespace: Rakuten.RMS.Api.RakutenPayOrderAPI

楽天ペイ受注API（RakutenPayOrderAPI）

```csharp
public class RakutenPayOrderService : Rakuten.RMS.Api.JSON.RakutenApiJsonClientBase
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [RakutenApiClientBaseCommon](./rakuten.rms.api.rest.rakutenapiclientbasecommon) → [RakutenApiJsonClientBase](./rakuten.rms.api.json.rakutenapijsonclientbase) → [RakutenPayOrderService](./rakuten.rms.api.rakutenpayorderapi.rakutenpayorderservice)

## Methods

### <a id="methods-cancelorder"/>**CancelOrder(String, Int32, Int32)**

次のステータスの注文にのみ有効<br>
 ・100: 注文確認待ち<br>
 ・200: 楽天処理中<br>
 ・300: 発送待ち<br>

```csharp
public IEnumerable<OrderMessageModel> CancelOrder(string orderNumber, int inventoryRestoreType, int changeReasonDetailApply)
```

#### Parameters

`orderNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
注文番号 キャンセル申請対象の受注番号。

`inventoryRestoreType` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
在庫連動区分<br> 0: 商品設定に合わせる<br> 1: 在庫連動する<br> 2: 在庫連動しない<br>

`changeReasonDetailApply` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
キャンセル理由<br>
 (お客様都合による)<br>
 1: キャンセル<br>
 2: 受取後の返品<br>
 3: 長期不在による受取拒否<br>
 4: 未入金<br>
 5: 代引決済の受取拒否<br>
 6: その他<br>
 (店舗都合による)<br>
 8: 欠品<br>
 10: その他<br>
 13: 発送遅延<br>
 14: 顧客・配送対応注意表示<br>
 15: 返品（破損・品間違い）

#### Returns

[IEnumerable&lt;OrderMessageModel&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)

### <a id="methods-cancelorderaftershipping"/>**CancelOrderAfterShipping(String, Int32, Int32)**

注文キャンセル（発送後）
 発送完了報告後の受注に対してキャンセルを要求する。
 次のステータスの注文にのみ有効
 ・500: 発送済
 ・600: 支払手続き中
 ・700: 支払手続き済
 ・800: キャンセル確定待ち
 ※キャンセル確定までを一括で行いますので、商品が返品されたことを確認後に実施してください。

```csharp
public IList<OrderMessageModel> CancelOrderAfterShipping(string orderNumber, int inventoryRestoreType, int changeReasonDetailApply)
```

#### Parameters

`orderNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
注文番号 キャンセル申請対象の受注番号。

`inventoryRestoreType` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
在庫連動区分
 以下のいずれか
 0: 商品設定に合わせる
 1: 在庫連動する
 2: 在庫連動しない

`changeReasonDetailApply` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
キャンセル理由
 以下のいずれか
 (お客様都合による)
 1: キャンセル
 2: 受取後の返品
 3: 長期不在による受取拒否
 4: 未入金
 5: 代引決済の受取拒否
 6: その他
 (店舗都合による)
 8: 欠品
 10: その他
 13: 発送遅延
 14: 顧客・配送対応注意表示
 15: 返品（破損・品間違い）

#### Returns

[IList&lt;OrderMessageModel&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)

### <a id="methods-confirmorder"/>**ConfirmOrder(IList&lt;String&gt;)**

楽天ペイ注文の「注文確認」を行うことができます。こちらは同期処理となります。

```csharp
public IEnumerable<OrderMessageModel> ConfirmOrder(IList<String> orderNumberList)
```

#### Parameters

`orderNumberList` [IList&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>
注文番号リスト 最大 100 件まで指定可能

#### Returns

[IEnumerable&lt;OrderMessageModel&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)

### <a id="methods-getorder"/>**GetOrder(IEnumerable&lt;String&gt;, Int32)**

複数の注文番号を指定して注文の詳細を取得する。

```csharp
public GetOrderResponse GetOrder(IEnumerable<String> orderNumberList, int version)
```

#### Parameters

`orderNumberList` [IEnumerable&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>
注文番号

`version` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
3: 消費税増税対応
 4: 共通の送料込みライン対応
 5: 領収書、前払い期限版
 6: 顧客・配送対応注意表示詳細対応
 7: SKU対応

#### Returns

[GetOrderResponse](./rakuten.rms.api.rakutenpayorderapi.getorderresponse)

### <a id="methods-getorder"/>**GetOrder(String, Int32)**

１つの注文詳細を取得。

```csharp
public OrderModel GetOrder(string orderNumber, int version)
```

#### Parameters

`orderNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
注文番号

`version` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
3: 消費税増税対応<br>
 4: 共通の送料込みライン対応<br>
 5: 領収書、前払い期限版<br>
 6: 顧客・配送対応注意表示詳細対応<br>
 7: SKU対応

#### Returns

[OrderModel](./rakuten.rms.api.rakutenpayorderapi.ordermodel)

#### Exceptions

[RakutenRMSApiException](./rakuten.rms.api.rakutenrmsapiexception)<br>

### <a id="methods-getpayment"/>**GetPayment(String, Int32)**

注文番号を指定して、支払明細情報を取得する。

```csharp
public GetPaymentResponse GetPayment(string orderNumber, int version)
```

#### Parameters

`orderNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
注文番号

`version` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

#### Returns

[GetPaymentResponse](./rakuten.rms.api.rakutenpayorderapi.getpaymentresponse)

### <a id="methods-getresultupdateordershippingasync"/>**GetResultUpdateOrderShippingAsync(String)**

```csharp
public UpdateOrderShippingResultResponse GetResultUpdateOrderShippingAsync(string requestId)
```

#### Parameters

`requestId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[UpdateOrderShippingResultResponse](./rakuten.rms.api.rakutenpayorderapi.updateordershippingresultresponse)

### <a id="methods-getsubstatuslist"/>**GetSubStatusList()**

```csharp
public GetSubStatusListResponse GetSubStatusList()
```

#### Returns

[GetSubStatusListResponse](./rakuten.rms.api.rakutenpayorderapi.getsubstatuslistresponse)

### <a id="methods-searchorder"/>**SearchOrder(SearchOrderRequest)**

```csharp
public SearchOrderResponse SearchOrder(SearchOrderRequest request)
```

#### Parameters

`request` [SearchOrderRequest](./rakuten.rms.api.rakutenpayorderapi.searchorderrequest)<br>

#### Returns

[SearchOrderResponse](./rakuten.rms.api.rakutenpayorderapi.searchorderresponse)

### <a id="methods-updateorderdelivery"/>**UpdateOrderDelivery(String, String)**

・配送方法（宅急便・国際配送・ゆうパック・自社配送・バイク便・その他配送方法１・その他配送方法２・その他配送方法３

```csharp
public IList<OrderMessageModel> UpdateOrderDelivery(string orderNumber, string deliveryName)
```

#### Parameters

`orderNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
注文番号

`deliveryName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
店舗設定で設定した配送方法を指定

#### Returns

[IList&lt;OrderMessageModel&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)

### <a id="methods-updateordermemo"/>**UpdateOrderMemo(UpdateOrderMemoRequest)**

以下の情報を更新可能
 ・ひとことメモ
 ・担当者
 ・利用サービス名（配送区分）
 ・お客様へのメッセージ
 ・お届け日指定
 ・お届け時間帯
 ・サブステータスID

```csharp
public IList<Message> UpdateOrderMemo(UpdateOrderMemoRequest request)
```

#### Parameters

`request` [UpdateOrderMemoRequest](./rakuten.rms.api.rakutenpayorderapi.updateordermemorequest)<br>

#### Returns

[IList&lt;Message&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)

### <a id="methods-updateorderorderer"/>**UpdateOrderOrderer(String, OrdererModel, Nullable&lt;Int32&gt;)**

・注文者 - 名前
 ・注文者 - フリガナ
 ・注文者 - 住所
 ・注文者 - 電話番号
 ・注文者 - メールアドレス
 ・注文者 - 性別
 ・注文者 - 誕生日

```csharp
public IList<OrderMessageModel> UpdateOrderOrderer(string orderNumber, OrdererModel ordererModel, Nullable<Int32> reductionReason)
```

#### Parameters

`orderNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
注文番号

`ordererModel` [OrdererModel](./rakuten.rms.api.rakutenpayorderapi.orderermodel)<br>

`reductionReason` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
以下のいずれか
 (お客様都合による)
 1: キャンセル
 2: 受取後の返品
 3: 長期不在による受取拒否
 4: 未入金
 5: 代引決済の受取拒否
 6: その他
 (店舗都合による)
 8: 欠品
 10: その他
 13: 発送遅延
 14: 顧客・配送対応注意表示
 15: 返品（破損・品間違い）
 ※以下の条件で必須。
 1. 減額変更時
 2. 楽天市場共通の後払い決済 かつ 発送完了報告後の変更時

#### Returns

[IList&lt;OrderMessageModel&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)

### <a id="methods-updateorderremarks"/>**UpdateOrderRemarks(String, String, Nullable&lt;Int32&gt;)**

以下の情報を更新可能・備考・ギフト配送（希望する・希望しない）

```csharp
public IList<Message> UpdateOrderRemarks(string orderNumber, string remarks, Nullable<Int32> giftCheck)
```

#### Parameters

`orderNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
注文番号

`remarks` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
コメント

`giftCheck` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
ギフト配送 0: 希望しない 1: 希望する

#### Returns

[IList&lt;Message&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)

### <a id="methods-updateordersender"/>**UpdateOrderSender(OrderSenderRequest)**

```csharp
public IList<OrderMessageModel> UpdateOrderSender(OrderSenderRequest request)
```

#### Parameters

`request` [OrderSenderRequest](./rakuten.rms.api.rakutenpayorderapi.ordersenderrequest)<br>

#### Returns

[IList&lt;OrderMessageModel&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)

### <a id="methods-updateordersenderaftershipping"/>**UpdateOrderSenderAfterShipping(OrderSenderRequest)**

```csharp
public IList<OrderMessageModel> UpdateOrderSenderAfterShipping(OrderSenderRequest request)
```

#### Parameters

`request` [OrderSenderRequest](./rakuten.rms.api.rakutenpayorderapi.ordersenderrequest)<br>

#### Returns

[IList&lt;OrderMessageModel&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)

### <a id="methods-updateordershipping"/>**UpdateOrderShipping(String, IEnumerable&lt;BasketidModel&gt;)**

１注文の配送情報の更新が可能。発送が完了した注文の、伝票番号、出荷日を登録して、注文を締める。

```csharp
public IEnumerable<OrderShippingMessageModel> UpdateOrderShipping(string orderNumber, IEnumerable<BasketidModel> BasketidModelList)
```

#### Parameters

`orderNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
注文番号

`BasketidModelList` [IEnumerable&lt;BasketidModel&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

#### Returns

[IEnumerable&lt;OrderShippingMessageModel&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)

### <a id="methods-updateordershippingasync"/>**UpdateOrderShippingAsync(IEnumerable&lt;OrderMessageModel&gt;)**

発送完了報告（非同期）
 「発送完了報告」処理を複数件一括で非同期更新する。
 機能呼び出しの返却値としてrequestId が発行され、この値を元に発送完了報告（非同期結果確認）を実行し、処理結果を確認する。

```csharp
public UpdateOrderShippingAsyncResponse UpdateOrderShippingAsync(IEnumerable<OrderMessageModel> messageModelList)
```

#### Parameters

`messageModelList` [IEnumerable&lt;OrderMessageModel&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

#### Returns

[UpdateOrderShippingAsyncResponse](./rakuten.rms.api.rakutenpayorderapi.updateordershippingasyncresponse)

### <a id="methods-updateordersubstatus"/>**UpdateOrderSubStatus(Int32, IEnumerable&lt;String&gt;)**

```csharp
public IEnumerable<OrderMessageModel> UpdateOrderSubStatus(int subStatusId, IEnumerable<String> orderNumberList)
```

#### Parameters

`subStatusId` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`orderNumberList` [IEnumerable&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

#### Returns

[IEnumerable&lt;OrderMessageModel&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)


- - -
[**< クラス一覧**](./)
