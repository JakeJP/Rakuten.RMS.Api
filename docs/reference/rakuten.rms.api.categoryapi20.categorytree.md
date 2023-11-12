<img align="left" style="height: 2em;" src="https://webservice.rakuten.co.jp/favicon.ico"><em>Rakuten RMS WEB API client for .NET</em>

[**< クラス一覧**](./)
- - -

# CategoryTree

Namespace: Rakuten.RMS.Api.CategoryAPI20

カテゴリの情報をフルセットで含むカテゴリツリーの全体を保持する。
 カテゴリツリーの構造を更新する場合 ToCategoryIdTree() で CategoryIdTree に変換後、変更、UpdateCategoryTree()を呼ぶ。

```csharp
public class CategoryTree : System.Collections.Generic.List`1[[Rakuten.RMS.Api.CategoryAPI20.CategoryWithChildren, Rakuten.RMS.Api, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Collections.Generic.IList`1[[Rakuten.RMS.Api.CategoryAPI20.CategoryWithChildren, Rakuten.RMS.Api, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Collections.Generic.ICollection`1[[Rakuten.RMS.Api.CategoryAPI20.CategoryWithChildren, Rakuten.RMS.Api, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Collections.Generic.IEnumerable`1[[Rakuten.RMS.Api.CategoryAPI20.CategoryWithChildren, Rakuten.RMS.Api, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, System.Collections.Generic.IReadOnlyList`1[[Rakuten.RMS.Api.CategoryAPI20.CategoryWithChildren, Rakuten.RMS.Api, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Collections.Generic.IReadOnlyCollection`1[[Rakuten.RMS.Api.CategoryAPI20.CategoryWithChildren, Rakuten.RMS.Api, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [List&lt;CategoryWithChildren&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1) → [CategoryTree](./rakuten.rms.api.categoryapi20.categorytree)<br>
Implements [IList&lt;CategoryWithChildren&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1), [ICollection&lt;CategoryWithChildren&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1), [IEnumerable&lt;CategoryWithChildren&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1), [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable), [IList](https://docs.microsoft.com/en-us/dotnet/api/system.collections.ilist), [ICollection](https://docs.microsoft.com/en-us/dotnet/api/system.collections.icollection), [IReadOnlyList&lt;CategoryWithChildren&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1), [IReadOnlyCollection&lt;CategoryWithChildren&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlycollection-1)

## Properties

### <a id="properties-capacity"/>**Capacity**

```csharp
public int Capacity { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### <a id="properties-count"/>**Count**

```csharp
public int Count { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### <a id="properties-item"/>**Item**

```csharp
public CategoryWithChildren Item { get; set; }
```

#### Property Value

[CategoryWithChildren](./rakuten.rms.api.categoryapi20.categorywithchildren)<br>

## Constructors

### <a id="constructors-.ctor"/>**CategoryTree()**

```csharp
public CategoryTree()
```

## Methods

### <a id="methods-tocategoryidtree"/>**ToCategoryIdTree()**

更新用のオブジェクトモデルに変換します。

```csharp
public CategoryIdTree ToCategoryIdTree()
```

#### Returns

[CategoryIdTree](./rakuten.rms.api.categoryapi20.categoryidtree)


- - -
[**< クラス一覧**](./)
