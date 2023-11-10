# Coupon API

## サンプルコード

### クーポン（配布型）の操作

```python
sp = ServiceProvider # 初期化部分省略
api = sp.GetCouponAPI()
coupon = api.Issue({
    "couponName": "TEST3",
    "couponCaption":"TEST TEST",
    "couponStartDate": datetime.datetime.now() + datetime.timedelta(10),
    "couponEndDate": datetime.datetime.now() + datetime.timedelta(11),
    "issueCount": 0,
    "itemType": 5,
    #"items": [],
    "discountType": 4,
    "discountFactor": 1,
    "memberAvailMaxCount": 0,
    "combineFlag": 0,
    "displayFlag": 0,
    "multiRankCond": [0]
})
api.Delete(coupon.couponCode)
```

### サンキュークーポン（自動付与型）の操作

```python
sp = ServiceProvider # 初期化部分省略
api = sp.GetCouponAPI()
coupon = api.IssueThanksCoupon({
    "couponName": "TEST3",
    "couponCaption":"TEST TEST",
    "discountType": 1,
    "discountFactor": 1,
    "couponUnavailableTerm": 30,
    "couponTerm": 1,
    "memberAvailMaxCount": 0,
    "combineFlag": 0,
    "thanksAutoGetConditions": [{
        "getCondCd": "grantTerm",
        "startValue": "2024-02-25 19:00:00",
        "endValue": "2024-02-26 23:59:59",
        "compOperatorCd": 1
    },{
        "getCondCd": "totalPrice",
        "startValue": "10",
        "compOperatorCd": 1
    }]
})
api.StopThanksCoupon(coupon)
```