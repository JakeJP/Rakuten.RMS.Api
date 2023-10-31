# Python 環境での実行

Python.NET(pythonnet) モジュールを使用することで、Python から各種APIにアクセスすることができます。

## 環境構築

pythonnet のインストール

```shell
python -m pip install pythonnet
```

### Python 実行時のプログラム内初期化

Python.NET から使用する際の、次の内容の初期設定を行います。

- pythonnet `import crl`
- `Rakuten.RMS.Api.dll`` への参照
- .NET のネットワークライブラリに TLS 1.2 バージョンの指定
- .NET の IList, IEnumerable, ICollection などとの変換をサポートするため Python.Runtime.Codecs の登録

APIアクセスのための serviceSecret, licenseKey をコマンドラインから取得して ServiceProvider を取得するまでの例

```python
import argparse
import clr
import pythonnet

import Python.Runtime
from System.Net import ServicePointManager, SecurityProtocolType 

# Rakuten.RMS.Api.DLL への参照
clr.AddReference('Rakuten.RMS.Api')

from Rakuten.RMS.Api import ServiceProvider

# TLS 1.2 対応
ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

# Python.NET における IList, IEnumerable, ICollection の変換処理対応
Python.Runtime.Codecs.ListDecoder.Register()
Python.Runtime.Codecs.SequenceDecoder.Register()
Python.Runtime.Codecs.IterableDecoder.Register()

parser = argparse.ArgumentParser()
#parser.add_argument("testcase")
parser.add_argument("-ss", "--serviceSecret", help="serviceSecret", required=True)
parser.add_argument("-lk", "--licenseKey", help="licenseKey", required=True)
args = parser.parse_args()

sp = ServiceProvider(args.serviceSecret, args.licenseKey)
```

各種APIへのアクセスはこの **ServiceProvider** を通じて分類別のAPIアクセスクラスを取得します。

RakutenPay 注文APIを取得して、注文を検索する例:

```python
orderApi = sp.GetRakutenPayOrderAPI()

from Rakuten.RMS.Api.RakutenPayOrderAPI import SearchOrderRequest
from System import DateTime

req = SearchOrderRequest()
req.dateType = 1
req.orderProgressList = [100,200,300]
req.startDatetime = DateTime.Now.AddDays(-60)
req.endDatetime = DateTime.Now
result = api.SearchOrder(req)

if( result.orderNumberList ):
    orders = api.GetOrder( [result.orderNumberList[0]] )
    for m in orders.MessageModelList:
        print(m.messageType, m.messageCode, m.message)
    for order in orders.OrderModelList:
        ....

```

## .NET オブジェクトへアクセスするための注意点

