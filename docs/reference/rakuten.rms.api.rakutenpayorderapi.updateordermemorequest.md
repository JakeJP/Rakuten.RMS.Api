[`< Back`](./)

---

# UpdateOrderMemoRequest

Namespace: Rakuten.RMS.Api.RakutenPayOrderAPI

```csharp
public class UpdateOrderMemoRequest
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [UpdateOrderMemoRequest](./rakuten.rms.api.rakutenpayorderapi.updateordermemorequest)

## Properties

### **orderNumber**

注文番号

```csharp
public string orderNumber { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **subStatusId**

サブステータスID

```csharp
public Nullable<long> subStatusId { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **deliveryClass**

配送区分
 0: 選択なし
 1: 普通
 2: 冷蔵
 3: 冷凍
 4: その他1
 5: その他2
 6: その他3
 7: その他4
 8: その他5

```csharp
public Nullable<long> deliveryClass { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **deliveryDate**

お届け日指定 no Date	10	-	YYYY-MM-DD	2017-11-30

```csharp
public Nullable<DateTime> deliveryDate { get; set; }
```

#### Property Value

[Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **shippingTerm**

お届け時間帯
 0: なし
 1: 午前
 2: 午後
 9: その他
 h1h2: h1時-h2時(h1は7～24まで任意で数値指定可能。h2は07～24まで任意で数値指定可能)

```csharp
public Nullable<int> shippingTerm { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **memo**

ひとことメモ

```csharp
public string memo { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Operator**

担当者

```csharp
public string Operator { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **mailPlugSentence**

メール差込文(お客様へのメッセージ)

```csharp
public string mailPlugSentence { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

## Constructors

### **UpdateOrderMemoRequest()**

```csharp
public UpdateOrderMemoRequest()
```

---

[`< Back`](./)
