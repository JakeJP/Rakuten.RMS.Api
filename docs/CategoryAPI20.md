# Category API 2.0

- [クラスリファレンス](reference/rakuten.rms.api.categoryapi20.categoryapi20)
- サンプルコード(python)

## 概念

### CategorySet

カテゴリの階層構造の全体を保持するコンテナの属性を表すオブジェクト。CategorySetID = "0" でデフォルトのセットが既設されており、システム内では、複数の CategorySet を管理できる。※APIを通じて CategorySet を作成・削除する方法は提供されていない。

### CategoryTree

CategorySet に含まれる具体的な階層構造全体を保持するコンテナ。各ノードは CategoryWithChildren で表される。

### Category

CategoryTree を構成する一つ一つのカテゴリ（分類）の詳細を保持するオブジェクト。CategoryIDで代表され、詳細の説明、付随する画像などの情報が含まれる。APIによって、取得される情報に差異があるためいくつかの派生クラスがある。

- **NewCategory**
  カテゴリ新規作成のために使う基本クラス。詳細な設定、画像などの情報を含む。
- **Category**
  NewCategory に CategoryID と更新日時が加わった通常の登録済みのカテゴリを表すオブジェクト。
- **CategoryWithBreadcrumbs**
  １カテゴリを取得するAPI呼び出しで、Breadcrumb を含んだ Category が返された場合の Breadcrumb のリストを付加したオブジェクト。

### CategoryIdTree

CategoryID だけで構築されたすべての階層構造。ノードは CategoryIdWithChildren で表される。CategoryTree が Category のすべての情報を含んだ階層構造であるのに対して CategoryIdTree は CategoryID だけの構造となる。このモデルはカテゴリ階層構造の変更・更新のために必要となる。CategoryTree から CategoryIdTree への変換は CategoryTree.ToCategoryIdTree() メソッドで行うことができる。

### Breadcrumbs

## 再定義メソッド

生のAPI呼び出しは、メソッドの命名不明瞭、１つの呼び出しに複数の種類の情報が混在するなど使い勝手が悪いため、改めてメソッドを再構築して再定義した。※生のAPI呼び出しメソッドもそのまま使用可能。

### IList&lt;string&gt; GetCategorySetIdList()

すべての CategorySet を CategorySetId だけのリストで取得する。

### IList&lt;CategorySet&gt; GetAllCategorySet()

詳細情報付きの CategorySet のすべてをリストで取得する。

### CategorySet GetCategorySet( string categorySetId )

１つの CategorySet を詳細情報付きで取得する。

### CategoryTree GetCategoryTree( string categorySetId )

CategorySet に対応する階層構造全体を CategoryTree オブジェクトとして取得する。

### void UpdateCategoryTree(string categorySetId, IList&lt;CategoryIdWithChildren&gt; tree)

CategoryTree を更新する。
tree パラメーターは通常 CategoryIdTree オブジェクトで、CategoryTree.ToCategoryIdTree() で変換されたオブジェクトを使うことを想定。

### Category GetCategory( string categoryId, bool breadcrumb = false)

１カテゴリを詳細情報付き、breadcrumb = true の場合は breadcrumbs 情報が付加して取得する。

### string CreateCategory(NewCategory category)

１カテゴリを新規登録。成功すると新しく割り当てられた CategoryID が返される。

※このAPI呼び出し後、UpdateCategoryTree でツリー内に追加されないと、幽霊カテゴリとして見えないまま、指定時間後自動削除されることに注意。

### void UpdateCategory(string categoryId, NewCategory category)

１カテゴリの詳細情報を更新。

## サンプルコード

### カテゴリーツリーを列挙(python)

デフォルトの CategorySet である "0" のカテゴリツリーを取得

```python
sp = ServiceProvider # 初期化部分省略
api = sp.GetCategoryAPI20()

tree = api.GetCategoryTree("0")
```

### 新しいカテゴリを登録(python)

```python
from Rakuten.RMS.Api.CategoryAPI20 import NewCategory

category = NewCategory()
category.categorySetId = setId
category.title = "TEST Category"
categoryId = api.CreateCategory(category)
```

### `tree` から更新用の **CategoryIdTree** を作成、新しいカテゴリを追加して更新(python)

```python
id_tree = tree.ToCategoryIdTree()
id_tree[0].Add(categoryId) # 最初のカテゴリの子供として登録
api.UpdateCategoryTree("0", id_tree)
```
