# Item API 2.0

商品情報の取得・登録・更新・削除

- [クラスリファレンス](reference/rakuten.rms.api.itemapi20.itemapi20)
- サンプルコード(python)


## class Item

商品情報の保持形態はAPIの種類によっていくつかの派生クラスが存在。

- **ItemCommon** 商品情報のほぼすべてを保持するオブジェクト
- **Item** 登録済みの既存の商品情報を保持。ItemCommonに加え、manageNumber 作成・更新日時を含む。
- **UpsertItem** ItemCommon と内容は同じ。更新・登録時のオブジェクト
- **PatchItem** 商品情報のうち、null ではない一部の項目のみを更新する場合に使用するクラス。

商品のバリエーションの保持するオブジェクト

- **Variant** バリエーションの詳細情報すべてを含む
- **PatchVariant** PatchItem中で、同様に、一部の項目のみを更新する場合に使用するクラス
  

## サンプルコード

商品検索(python)

```python
sp = ServiceProvider # 初期設定省略
api = sp.GetItemAPI20()

result = api.SearchAll( {"manageNumber": ""} )
for item in result:
    print( f"[{item.item.manageNumber}] [{item.item.itemNumber}] {item.item.title}" )

```

