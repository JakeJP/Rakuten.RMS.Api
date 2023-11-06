[`< Back`](./)

---

# InfoListRequest

Namespace: Rakuten.RMS.Api.ReserveAPI

```csharp
public class InfoListRequest
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [InfoListRequest](./rakuten.rms.api.reserveapi.infolistrequest)

## Properties

### **dateType**

期間指定種類 
 1：申込日
 2：お届け予定日
 3：注文確定日

```csharp
public int dateType { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **reserveType**

商品種別
 1：定期購入
 2：頒布会
 3：予約

```csharp
public IList<int> reserveType { get; set; }
```

#### Property Value

[IList&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

### **keywordType**

検索方法
 1: 商品管理番号で検索
 こちらを指定した場合、「商品管理番号」が必須

```csharp
public Nullable<int> keywordType { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **keyword**

商品管理番号

```csharp
public string keyword { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **startDate**

開始日
 最大検索期間：前年の本日より来年本日の前日までの2年間

```csharp
public Nullable<DateTime> startDate { get; set; }
```

#### Property Value

[Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **endDate**

終了日

```csharp
public Nullable<DateTime> endDate { get; set; }
```

#### Property Value

[Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **reserveStatusName**

申込ステータス名
 各店舗で利用している申込ステータスを参照し、完全一致の名称を指定

```csharp
public string reserveStatusName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **deviceCode**

利用端末
 1 : PC
 2 : モバイル
 3 : スマートフォン
 4 : タブレット

```csharp
public IList<int> deviceCode { get; set; }
```

#### Property Value

[IList&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

### **settlementName**

支払方法 
 各店舗で利用している決済方法を参照し、完全一致の名称を指定

```csharp
public string settlementName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **deliveryName**

配送方法 
 基本情報設定の配送方法・送料設定ページにある「配送方法」と「配送キャリア」を完全一致で指定

```csharp
public string deliveryName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **modifyFlag**

申込履歴修正有無フラグ
 0：申込履歴からの修正なし
 1：申込履歴からの修正あり

```csharp
public Nullable<int> modifyFlag { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **limit**

取得件数
 指定なしの場合先頭100件のみ取得対象となります。値の範囲: 1 - 1000

```csharp
public Nullable<int> limit { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **offset**

取得位置
 例：1000件データのうちの501件目～700件目の200件のみ取得したい場合、limit=200&amp;offset=500で設定します。

```csharp
public Nullable<int> offset { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

## Constructors

### **InfoListRequest()**

```csharp
public InfoListRequest()
```

---

[`< Back`](./)
