[`< Back`](./)

---

# PaymentCardModel

Namespace: Rakuten.RMS.Api.RakutenPayOrderAPI

```csharp
public class PaymentCardModel
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PaymentCardModel](./rakuten.rms.api.rakutenpayorderapi.paymentcardmodel)

## Properties

### **cardName**

種類

```csharp
public string cardName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **cardYm**

有効期限

```csharp
public string cardYm { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **cardOwner**

名義人

```csharp
public string cardOwner { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **cardNumber**

番号

```csharp
public string cardNumber { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **cardPayType**

支払方法
 0: 一括払い
 1: リボ払い
 2: 分割払い
 3: その他払い
 4: ボーナス一括払い

```csharp
public int cardPayType { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **cardInstallmentDesc**

支払回数 
 103: 3回払い
 105: 5回払い
 106: 6回払い
 110: 10回払い
 112: 12回払い
 115: 15回払い
 118: 18回払い
 120: 20回払い
 124: 24回払い

```csharp
public string cardInstallmentDesc { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

## Constructors

### **PaymentCardModel()**

```csharp
public PaymentCardModel()
```

---

[`< Back`](./)
