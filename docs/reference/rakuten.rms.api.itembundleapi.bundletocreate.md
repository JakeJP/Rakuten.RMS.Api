[`< Back`](./)

---

# BundleToCreate

Namespace: Rakuten.RMS.Api.ItemBundleAPI

```csharp
public class BundleToCreate
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BundleToCreate](./rakuten.rms.api.itembundleapi.bundletocreate)

## Properties

### **parentItemManageNumber**

```csharp
public string parentItemManageNumber { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **bundleManageNumber**

2	組み合わせ管理番号

```csharp
public string bundleManageNumber { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **bundleState**

3	表示設定 
 ・ACTIVE
 ・INACTIVE ACTIVE

```csharp
public string bundleState { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **bundleItems**

組み合わせ商品リスト

```csharp
public List<BundleItemToCreate> bundleItems { get; set; }
```

#### Property Value

[List&lt;BundleItemToCreate&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>

### **bundleName**

// 5	組み合わせ管理名称

```csharp
public string bundleName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **bundleDescription**

6	組み合わせ販売説明文

```csharp
public string bundleDescription { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

## Constructors

### **BundleToCreate()**

```csharp
public BundleToCreate()
```

---

[`< Back`](./)
