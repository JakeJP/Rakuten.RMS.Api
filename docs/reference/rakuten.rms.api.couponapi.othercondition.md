[`< Back`](./)

---

# OtherCondition

Namespace: Rakuten.RMS.Api.CouponAPI

```csharp
public class OtherCondition
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [OtherCondition](./rakuten.rms.api.couponapi.othercondition)

## Properties

### **conditionTypeCode**

RS001： デバイス指定（設定のない場合は自動的に設定される）
 RS002： 販売方法(設定のない場合は自動的に設定される）
 RS003： 利用金額
 RS004： 利用個数
 ※39ショップに限り、 利用個数(RS004) を設定した場合、複数商品(「itemType」に「3」)が設定可能です。
 ※ 対象商品リストが設定されている場合はクーポン発行条件を参照ください。

```csharp
public string conditionTypeCode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **startValue**

0： PC （設定のない場合は自動的に設定される）
 1： モバイル （設定のない場合は自動的に設定される）
 RS002	0： 通常購入
 RS003	1 ～ 999999999： 金額
 RS004	0 ～ 999999999： 個数

```csharp
public string startValue { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

## Constructors

### **OtherCondition()**

```csharp
public OtherCondition()
```

---

[`< Back`](./)
