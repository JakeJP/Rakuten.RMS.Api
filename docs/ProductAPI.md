# ProductAPI

製品情報を取得するAPI

## サンプルコード

```python
sp = ServiceProvider # 初期化部分省略
api = sp.GetProductAPI()

result = api.SearchAll({ "keyword": "ABCDEFG" } )

for p in result:
    print( p.productName, p.rank, p.rank, p.rankTargetGenreId, p.rankTargetProductCount )

```
