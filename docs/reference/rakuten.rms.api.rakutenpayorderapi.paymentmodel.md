[`< Back`](./)

---

# PaymentModel

Namespace: Rakuten.RMS.Api.RakutenPayOrderAPI

```csharp
public class PaymentModel
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PaymentModel](./rakuten.rms.api.rakutenpayorderapi.paymentmodel)

## Properties

### **orderPaymentNumber**

決済番号 
 yes String	392	-		502763-20171027-00006701-1

```csharp
public string orderPaymentNumber { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **paymentMethod**

決済手段 
 1: クレジットカード
 2: 代金引換
 3: 後払い（選択制決済）
 4: ショッピングクレジット／ローン
 5: オートローン
 6: リース
 7: 請求書払い
 8: ポイント
 9: 銀行振込
 12: Apple Pay
 13: セブンイレブン（前払）
 14: ローソン、郵便局ATM等（前払）
 16: Alipay
 17: PayPal
 21: 後払い決済（楽天市場の共通決済）
 27: Alipay（支付宝）	1

```csharp
public int paymentMethod { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **paymentAmount**

決済額

```csharp
public int paymentAmount { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **paymentCharge**

決済手数料

```csharp
public int paymentCharge { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **paymentStatus**

決済ステータス
 30000: 決済なし
 30100: 決済手続き待ち
 30110: 決済手続き待ち（前処理待ち）
 30200: 決済手続き依頼
 30300: 決済手続き完了
 30400: 決済手続きNG
 30500: 決済依頼
 30600: 決済確定
 30610: 決済確定（取消NG）
 30700: 決済NG
 30710: 決済NG（店舗引渡）
 31100: 決済手続き取消中
 31110: 決済手続き取消待ち
 31120: 決済手続き取消待ち（前処理待ち）
 31200: 決済手続き取消完了
 31300: 決済手続き取消NG
 31400: 決済取消中
 31410: 決済取消待ち
 31420: 決済取消待ち（前処理待ち）
 31500: 決済取消完了
 31800: 決済取消完了（チャージバック）

```csharp
public int paymentStatus { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **paymentProcReqDatetime**

決済手続き依頼日時

```csharp
public Nullable<DateTime> paymentProcReqDatetime { get; set; }
```

#### Property Value

[Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **paymentProcNgDatetime**

決済手続きNG日時

```csharp
public Nullable<DateTime> paymentProcNgDatetime { get; set; }
```

#### Property Value

[Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **paymentProcCmplDatetime**

決済手続き完了日時

```csharp
public Nullable<DateTime> paymentProcCmplDatetime { get; set; }
```

#### Property Value

[Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **paymentProcCancelNgDate**

決済手続き取消NG日時

```csharp
public Nullable<DateTime> paymentProcCancelNgDate { get; set; }
```

#### Property Value

[Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **paymentProcCancelCmplDatetime**

決済手続き取消完了日時

```csharp
public Nullable<DateTime> paymentProcCancelCmplDatetime { get; set; }
```

#### Property Value

[Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **paymentReqDatetime**

決済依頼日時

```csharp
public Nullable<DateTime> paymentReqDatetime { get; set; }
```

#### Property Value

[Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **paymentNgDatetime**

決済NG日時

```csharp
public Nullable<DateTime> paymentNgDatetime { get; set; }
```

#### Property Value

[Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **paymentFixDatetime**

決済確定日時

```csharp
public Nullable<DateTime> paymentFixDatetime { get; set; }
```

#### Property Value

[Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **paymentCancelNgDatetime**

決済確定(取消NG)日時

```csharp
public Nullable<DateTime> paymentCancelNgDatetime { get; set; }
```

#### Property Value

[Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **paymentCancelCmplDatetime**

決済取消完了日時

```csharp
public Nullable<DateTime> paymentCancelCmplDatetime { get; set; }
```

#### Property Value

[Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **paymentCancelFixDatetime**

決済取消確定日時

```csharp
public Nullable<DateTime> paymentCancelFixDatetime { get; set; }
```

#### Property Value

[Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **payExpectDate**

支払予定日

```csharp
public Nullable<DateTime> payExpectDate { get; set; }
```

#### Property Value

[Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **minusPayExpectDate**

マイナス支払予定日

```csharp
public Nullable<DateTime> minusPayExpectDate { get; set; }
```

#### Property Value

[Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **paymentOrganizationLinkageNumberList**

決済機関連携番号

```csharp
public List<string> paymentOrganizationLinkageNumberList { get; set; }
```

#### Property Value

[List&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>

### **PaymentCardModel**

カード決済モデル

```csharp
public PaymentCardModel PaymentCardModel { get; set; }
```

#### Property Value

[PaymentCardModel](./rakuten.rms.api.rakutenpayorderapi.paymentcardmodel)<br>

### **PaymentMultiModel**

マルチ決済モデル

```csharp
public PaymentMultiModel PaymentMultiModel { get; set; }
```

#### Property Value

[PaymentMultiModel](./rakuten.rms.api.rakutenpayorderapi.paymentmultimodel)<br>

### **PaymentBankModel**

銀行振込決済モデル

```csharp
public PaymentBankModel PaymentBankModel { get; set; }
```

#### Property Value

[PaymentBankModel](./rakuten.rms.api.rakutenpayorderapi.paymentbankmodel)<br>

### **PaymentPayAfterModel**

後払い決済モデル

```csharp
public PaymentPayAfterModel PaymentPayAfterModel { get; set; }
```

#### Property Value

[PaymentPayAfterModel](./rakuten.rms.api.rakutenpayorderapi.paymentpayaftermodel)<br>

### **RefundModelList**

返金モデルリスト

```csharp
public List<RefundModel> RefundModelList { get; set; }
```

#### Property Value

[List&lt;RefundModel&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>

### **AdditionalFeeModelList**

負担金情報モデルリスト

```csharp
public List<AdditionalFeeModel> AdditionalFeeModelList { get; set; }
```

#### Property Value

[List&lt;AdditionalFeeModel&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>

### **PaymentPaypalModel**

PayPal決済モデル

```csharp
public PaymentPaypalModel PaymentPaypalModel { get; set; }
```

#### Property Value

[PaymentPaypalModel](./rakuten.rms.api.rakutenpayorderapi.paymentpaypalmodel)<br>

## Constructors

### **PaymentModel()**

```csharp
public PaymentModel()
```

---

[`< Back`](./)
