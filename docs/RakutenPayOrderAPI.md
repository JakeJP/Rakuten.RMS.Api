# 楽天ペイ受注API（RakutenPayOrderAPI）

- [クラスリファレンス](./reference/rakuten.rms.api.rakutenpayorderapi.rakutenpayorderservice)
- サンプルコード(python)

### 1注文データの格納モデル

[OrderModel](./reference/rakuten.rms.api.rakutenpayorderapi.ordermodel)

## サンプルコード

### 検索から最初の１注文の詳細を取得(c#)

```csharp
var api = sp.GetRakutenPayOrderService();
var searchResult = api.SearchOrder(new SearchOrderRequest { 
    dataType = 1,
    orderProgressList = new[] { 100, 200, 300 },
    startDatetime = DateTime.Now.AddDays(-60),
    endDatetime = DateTime.Now });

foreach( var orderNumber in searchResult.orderNumberList)
{
    var orderResponse = api.GetOrder(new[] { orderNumber });
    var order = orderResponse.OrderModelList[0];
    ...
}
```

### 検索から最初の１注文の詳細を取得(python)

```python
sp = ServiceProvider # 初期化部分省略
api = sp.GetRakutenPayOrderAPI()

from Rakuten.RMS.Api.RakutenPayOrderAPI import SearchOrderRequest
from System import DateTime

req = SearchOrderRequest()
req.dateType = 1
req.orderProgressList = [100,200,300]
req.startDatetime = DateTime.Now.AddDays(-60)
req.endDatetime = DateTime.Now
result = api.SearchOrder(req)

for m in result.MessageModelList:
    print(m.messageType, m.messageCode, m.message)

if( result.orderNumberList ):
    # 0番目の注文詳細を取得
    orders = api.GetOrder( [result.orderNumberList[0]] )
    for order in orders.OrderModelList:
        # order に１注文の詳細が格納
        ...

```

### 楽天ペイ注文の「注文確認」

c#
```csharp
api.ConfirmOrder( new [] {"123456-12341234-1234567890"});
```

python
```python
api.ConfirmOrder(["123456-12341234-1234567890"])
```