[`< Back`](./)

---

# NaviButtonInfo

Namespace: Rakuten.RMS.Api.ShopAPI

```csharp
public class NaviButtonInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [NaviButtonInfo](./rakuten.rms.api.shopapi.navibuttoninfo)

## Properties

### **naviId**

```csharp
public long naviId { get; set; }
```

#### Property Value

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>

### **buttonOrder**

```csharp
public int buttonOrder { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **imgType**

```csharp
public int imgType { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **imgPath**

```csharp
public string imgPath { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **buttonText**

```csharp
public string buttonText { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **buttonTextFont**

```csharp
public int buttonTextFont { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **buttonTextSize**

```csharp
public long buttonTextSize { get; set; }
```

#### Property Value

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>

### **marginWidth**

```csharp
public long marginWidth { get; set; }
```

#### Property Value

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>

### **marginHeight**

枠線から文字までの間隔(縦）

```csharp
public long marginHeight { get; set; }
```

#### Property Value

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>

### **outsideFrame**

形状 Short 5	No 1: 平面

```csharp
public int outsideFrame { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **buttonBgcolor**

背景色 String 6	No

```csharp
public string buttonBgcolor { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **textColor**

文字色 String 6	No

```csharp
public string textColor { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **href**

リンク先ページ Short 5	Yes 1: 買い物かご
 2: 会社概要
 3: 決済・配送・返品
 6: R-Mail購読申込み
 7: 商品検索
 9: 楽天市場
 10: その他のリンク先
 12: カテゴリトップ
 13: 店舗トップ

```csharp
public int href { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **href2**

「その他のリンク先」の場合のURL String	255	No

```csharp
public string href2 { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

## Constructors

### **NaviButtonInfo()**

```csharp
public NaviButtonInfo()
```

---

[`< Back`](./)
