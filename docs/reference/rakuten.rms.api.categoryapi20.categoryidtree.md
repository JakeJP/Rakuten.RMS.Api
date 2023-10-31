[`< Back`](./)

---

# CategoryIdTree

Namespace: Rakuten.RMS.Api.CategoryAPI20

CategorySet の Tree 全体を保持するオブジェクト。
 Categoryの詳細情報を含まない ID だけの階層構造を保持。
 UpdateCategoryTree メソッドのパラメーターとして使用。
 GetCategoryTree()で取得した CategoryTree はカテゴリとその詳細情報を含む階層構造で、
 CategoryTree.ToCategoryIdTree() で CategoryIdTree オブジェクトを取得し、
 Tree内に存在するCateogryの操作（追加、削除、別ノードへの移動など）を行ったのち
 UpdateCategoryTree() で更新することが可能。

```csharp
public class CategoryIdTree : System.Collections.Generic.List`1[[Rakuten.RMS.Api.CategoryAPI20.CategoryIdWithChildren, Rakuten.RMS.Api, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Collections.Generic.IList`1[[Rakuten.RMS.Api.CategoryAPI20.CategoryIdWithChildren, Rakuten.RMS.Api, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Collections.Generic.ICollection`1[[Rakuten.RMS.Api.CategoryAPI20.CategoryIdWithChildren, Rakuten.RMS.Api, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Collections.Generic.IEnumerable`1[[Rakuten.RMS.Api.CategoryAPI20.CategoryIdWithChildren, Rakuten.RMS.Api, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, System.Collections.Generic.IReadOnlyList`1[[Rakuten.RMS.Api.CategoryAPI20.CategoryIdWithChildren, Rakuten.RMS.Api, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Collections.Generic.IReadOnlyCollection`1[[Rakuten.RMS.Api.CategoryAPI20.CategoryIdWithChildren, Rakuten.RMS.Api, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [List&lt;CategoryIdWithChildren&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1) → [CategoryIdTree](./rakuten.rms.api.categoryapi20.categoryidtree)<br>
Implements [IList&lt;CategoryIdWithChildren&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1), [ICollection&lt;CategoryIdWithChildren&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1), [IEnumerable&lt;CategoryIdWithChildren&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1), [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable), [IList](https://docs.microsoft.com/en-us/dotnet/api/system.collections.ilist), [ICollection](https://docs.microsoft.com/en-us/dotnet/api/system.collections.icollection), [IReadOnlyList&lt;CategoryIdWithChildren&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1), [IReadOnlyCollection&lt;CategoryIdWithChildren&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlycollection-1)

## Properties

### **Capacity**

```csharp
public int Capacity { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **Count**

```csharp
public int Count { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **Item**

```csharp
public CategoryIdWithChildren Item { get; set; }
```

#### Property Value

[CategoryIdWithChildren](./rakuten.rms.api.categoryapi20.categoryidwithchildren)<br>

## Constructors

### **CategoryIdTree()**

```csharp
public CategoryIdTree()
```

## Methods

### **Add(String)**

```csharp
public void Add(string categoryId)
```

#### Parameters

`categoryId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Find(String)**

カテゴリーツリーから再帰的に目的のカテゴリーIDを検索見つけます。

```csharp
public CategoryIdWithChildren Find(string categoryId)
```

#### Parameters

`categoryId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[CategoryIdWithChildren](./rakuten.rms.api.categoryapi20.categoryidwithchildren)<br>

### **Remove(String)**

カテゴリツリーから指定したカテゴリIDを削除。
 該当のカテゴリは階層構造を再帰的に検索される。

```csharp
public CategoryIdWithChildren Remove(string categoryId)
```

#### Parameters

`categoryId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
削除対象のカテゴリID

#### Returns

[CategoryIdWithChildren](./rakuten.rms.api.categoryapi20.categoryidwithchildren)<br>
削除されたカテゴリ（ツリー上のノード）このオブジェクトを同じツリーの別ノードに Add することが可能。

#### Exceptions

[IndexOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.indexoutofrangeexception)<br>

### **Remove(IList&lt;String&gt;)**

カテゴリツリーから指定したカテゴリIDを複数一度に削除。
 該当のカテゴリは階層構造を再帰的に検索される。

```csharp
public IList<CategoryIdWithChildren> Remove(IList<string> categoryIds)
```

#### Parameters

`categoryIds` [IList&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

#### Returns

[IList&lt;CategoryIdWithChildren&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

---

[`< Back`](./)
