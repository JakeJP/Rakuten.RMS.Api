#  InventoryAPI2.0 2.1

InventoryAPI 2.0 は在庫情報の取得・更新を行います。

InventoryAPI 2.1 は加えて出荷リードタイム・出荷元住所情報を取得・更新できます。

クラス定義のすべては 2.0 2.1 共通して Rakuten.RMS.Api.InventoryAPI20 名前空間に定義されています。

## サンプルコード

```python
sp = ServiceProvider # 初期化処理省略
invApi = sp.GetInventoryAPI21()

from Rakuten.RMS.Api.InventoryAPI20 import UpsertMode

# manageNumber variantId 指定で取得
result = invApi.BulkGet( [
    {"maangeNumber":"manageNumber1", "variantId":"variantId1"},
    {"maangeNumber":"manageNumber2", "variantId":"variantId2"})

# 1SKUの更新
invApi.Upsert("manageNumber1","variantId1", UpsertMode.RELATIVE, 1)

# 在庫数指定で取得
result = invApi.BulkGet( 0, 10 ) 

# 取得したSKUの在庫をすべて +1 して更新
invApi.BulkUpsert( [ {"manageNumber": i.manageNumber, "variantId": i.variantId, "mode": UpsertMode.RELATIVE, "quantity": 1} for i in result])
```