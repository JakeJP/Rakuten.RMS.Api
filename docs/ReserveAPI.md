# 購入申込API（ReserveAPI）

## サンプルコード

```python
import datetime

sp = ServiceProvider # 初期化部分省略
api = sp.GetReserveAPI()

res = api.GetReserveInfoList({
    "dateType": 1,
    "reserveType": [3],
    "startDate": datetime.datetime.now() + datetime.timedelta(-60),
    "endDate": datetime.datetime.now()
})

```