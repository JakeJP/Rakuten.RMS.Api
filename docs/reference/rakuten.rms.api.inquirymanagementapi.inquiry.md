[`< Back`](./)

---

# Inquiry

Namespace: Rakuten.RMS.Api.InquiryManagementAPI

```csharp
public class Inquiry
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Inquiry](./rakuten.rms.api.inquirymanagementapi.inquiry)

## Properties

### **inquiryNumber**

問い合わせ番号

```csharp
public string inquiryNumber { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **shopId**

店舗ID

```csharp
public int shopId { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **userName**

ユーザ氏名

```csharp
public string userName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **userMaskEmail**

ユーザーマスクメールアドレス

```csharp
public string userMaskEmail { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **message**

メッセージ

```csharp
public string message { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **regDate**

問い合わせ日時

```csharp
public DateTime regDate { get; set; }
```

#### Property Value

[DateTime](https://docs.microsoft.com/en-us/dotnet/api/system.datetime)<br>

### **itemUrl**

商品URL

```csharp
public string itemUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **itemName**

商品名

```csharp
public string itemName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **itemNumber**

商品番号

```csharp
public string itemNumber { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **isCompleted**

処理完了フラグ

```csharp
public bool isCompleted { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **completedDate**

処理完了日時

```csharp
public Nullable<DateTime> completedDate { get; set; }
```

#### Property Value

[Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **orderNumber**

受注番号

```csharp
public string orderNumber { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **readByMerchant**

店舗既読フラグ

```csharp
public bool readByMerchant { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **attachments**

attachments 添付ファイル

```csharp
public List<Attachment> attachments { get; set; }
```

#### Property Value

[List&lt;Attachment&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>

### **replies**

返信

```csharp
public List<Reply> replies { get; set; }
```

#### Property Value

[List&lt;Reply&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>

### **category**

問い合わせカテゴリ

```csharp
public string category { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **type**

問い合わせタイプ

```csharp
public string type { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **isMessageDeleted**

メッセージ削除 boolean メッセージが楽天によって削除されたか否かを表します。

```csharp
public bool isMessageDeleted { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **lastUpdateDate**

最終更新日

```csharp
public DateTime lastUpdateDate { get; set; }
```

#### Property Value

[DateTime](https://docs.microsoft.com/en-us/dotnet/api/system.datetime)<br>

## Constructors

### **Inquiry()**

```csharp
public Inquiry()
```

---

[`< Back`](./)
