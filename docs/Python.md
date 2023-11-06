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
- `Rakuten.RMS.Api.dll` への参照
- オプションで `Rakuten.RMS.Api.Python.dll` への参照
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
clr.AddReference('Rakuten.RMS.Api.Python') # Python.NET 用の拡張ライブラリ
from Rakuten.RMS.Api import ServiceProvider
import Rakuten.RMS.Api.Python # Python.NET 用の拡張ライブラリ
# TLS 1.2 対応
ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

# Python.NET における IList, IEnumerable, ICollection の変換処理対応
Python.Runtime.Codecs.ListDecoder.Register()
Python.Runtime.Codecs.SequenceDecoder.Register()
Python.Runtime.Codecs.IterableDecoder.Register()
# Python.NET 用の拡張ライブラリのAPI呼び出しパラメータの変換サポートを追加
Rakuten.RMS.Api.Python.ModelDecoder.Register()

parser = argparse.ArgumentParser()
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

## Rakuten.RMS.Api.Python.dll Python.NET 拡張ライブラリ

Python.NET 環境で、.NETのクラスオブジェクトの扱いをさらに簡単にするために追加的に使用することができます。

通常、APIメソッドの呼び出しのパラメータがー.NETクラスの場合、.NET クラスへの参照を `from... import...`
の記述を使って宣言する必要があります。`Rakuten.RMS.Api.Python` ライブラリを使うと この記述を python の dictionary とすることができます。

拡張ライブラリを有効にするには Python.NET の初期化の後 `Rakuten.RMS.Api.Python.dll` への参照を追加し、
`Rakuten.RMS.Api.Python.ModelDecoder.Register()` で Python.NET にカスタム Codec を追加します。
```python
clr.AddReference('Rakuten.RMS.Api.Python')
Rakuten.RMS.Api.Python.ModelDecoder.Register()
```

引数で python の dict を .NET のクラスのオブジェクトに変換可能なクラスはソースコードで `[DecodableObject]` 属性が付属しています。ほとんどの呼び出し用のパラメーターは対応しています。

また datetime モジュールの DateTime への変換も内蔵しています。

## サンプルコード

拡張ライブラリなしの場合

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
```

拡張ライブラリ有効の場合、次のように記述を簡単にすることができます。

```python
import datetime
orderApi = sp.GetRakutenPayOrderAPI()
result = api.SearchOrder({
    "dateType": 1,
    "orderProgressList": [100,200,300],
    "startDatetime", datetime.datetime.now() + datetime.timedelta(-60),
    "endDatetime": datetime.datetime.now() })
```

`dict` から .NET クラスへの変換は、プロパティ名が一致していることが必須。プロパティは省略可能。

## エラー処理

APIメソッドのほとんどは正常終了時以外 .NET の例外が発生します。エラー処理には例外処理を追加します。
APIが返すエラーは `RakutenRMSApiException` と派生クラスが内容を保持します。通信レベル、HTTPレベルのエラーの場合 `System.Net.WebException` が
発生する場合があります。

```python
from Rakuten.RMS.Api import RakutenRMSApiException
api = sp.GetRakutenPayOrderAPI()
try:
    result = api.SearchOrder({
        "dateType": 1,
        "orderProgressList": [100,200,300],
        "startDatetime", datetime.datetime.now() + datetime.timedelta(-60),
        "endDatetime": datetime.datetime.now() })
except RakutenRMSApiException as e:
    print(e)
```