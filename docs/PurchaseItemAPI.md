# PurchaseItem API

## サンプル

```python
import datetime

sp = ServiceProvider # 初期化省略
api = sp.GetPurchaseItemAPI()

result = api.SearchOrderItem({
    "dateType": 1, 
    "orderProgressList":[100,200,300], 
    "startDatetime": datetime.datetime.now() + datetime.timedelta(-60),
    "endDatetime": datetime.date.today(),
    "PaginationRequestModel": {"requestRecordsAmount": 10 } })

```