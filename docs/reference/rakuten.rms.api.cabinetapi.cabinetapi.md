<img align="left" style="height: 2em;" src="https://webservice.rakuten.co.jp/favicon.ico"><em>Rakuten RMS WEB API client for .NET</em>

[**< クラス一覧**](./)
- - -

# CabinetAPI

Namespace: Rakuten.RMS.Api.CabinetAPI

R-CabinetAPI（CabinetAPI）

```csharp
public class CabinetAPI : Rakuten.RMS.Api.XML.RakutenApiXmlClientBase
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [RakutenApiClientBaseCommon](./rakuten.rms.api.rest.rakutenapiclientbasecommon) → [RakutenApiXmlClientBase](./rakuten.rms.api.xml.rakutenapixmlclientbase) → [CabinetAPI](./rakuten.rms.api.cabinetapi.cabinetapi)

## Methods

### <a id="methods-createfolder"/>**CreateFolder(String, String, Nullable&lt;Int32&gt;)**

```csharp
public long CreateFolder(string folderName, string directoryName, Nullable<Int32> upperFolderId)
```

#### Parameters

`folderName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`directoryName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`upperFolderId` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

#### Returns

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)

### <a id="methods-deletefile"/>**DeleteFile(Int64)**

ファイル削除
 成功時はステータスコードを返し、エラー　は例外が発生。

```csharp
public int DeleteFile(long fileId)
```

#### Parameters

`fileId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>

#### Returns

ステータスコード

#### Exceptions

[XmlStatusException](./rakuten.rms.api.xml.xmlstatusexception)<br>

### <a id="methods-getallfiles"/>**GetAllFiles(Int64, Int32)**

ページング処理を内蔵したバージョン。通常はこちらのメソッド利用を推奨。

```csharp
public IEnumerable<FileModel> GetAllFiles(long folderId, int pageSize)
```

#### Parameters

`folderId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>

`pageSize` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
※値は100まで指定可能

#### Returns

[IEnumerable&lt;FileModel&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)

### <a id="methods-getallfilesintrashbox"/>**GetAllFilesInTrashbox(Int32)**

ページングを内蔵したバージョン。

```csharp
public IEnumerable<FileModel> GetAllFilesInTrashbox(int pageSize)
```

#### Parameters

`pageSize` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

#### Returns

[IEnumerable&lt;FileModel&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)

### <a id="methods-getallfolders"/>**GetAllFolders(Int32)**

ページング処理をラップしたバージョン。通常はこちらのメソッド利用を推奨。

```csharp
public IEnumerable<FolderModel> GetAllFolders(int pageSize)
```

#### Parameters

`pageSize` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
※値は100まで指定可能

#### Returns

[IEnumerable&lt;FolderModel&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)

### <a id="methods-getfiles"/>**GetFiles(Int64, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;)**

指定したフォルダ内の画像一覧を取得.ページングを内蔵した GetAllFiles を推奨.

```csharp
public GetFilesResponseModel GetFiles(long folderId, Nullable<Int32> offset, Nullable<Int32> limit)
```

#### Parameters

`folderId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>

`offset` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`limit` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

#### Returns

[GetFilesResponseModel](./rakuten.rms.api.cabinetapi.getfilesresponse.getfilesresponsemodel)

#### Exceptions

[XmlStatusException](./rakuten.rms.api.xml.xmlstatusexception)<br>

### <a id="methods-getfilesintrashbox"/>**GetFilesInTrashbox(Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;)**

削除フォルダ内にある画像の一覧を取得

```csharp
public GetFilesIntrashboxResponse GetFilesInTrashbox(Nullable<Int32> offset, Nullable<Int32> limit)
```

#### Parameters

`offset` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`limit` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

#### Returns

[GetFilesIntrashboxResponse](./rakuten.rms.api.cabinetapi.getfilesintrashboxresponse)

### <a id="methods-getfolders"/>**GetFolders(Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;)**

フォルダの一覧を取得.ページングを内蔵した GetAllFolders を推奨。

```csharp
public ResultModel GetFolders(Nullable<Int32> offset, Nullable<Int32> limit)
```

#### Parameters

`offset` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`limit` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

#### Returns

[ResultModel](./rakuten.rms.api.cabinetapi.getfoldersresponse.resultmodel)

#### Exceptions

[XmlStatusException](./rakuten.rms.api.xml.xmlstatusexception)<br>

### <a id="methods-getusage"/>**GetUsage()**

R-Cabinetの利用状況を取得

```csharp
public CabinetUsageGetResultModel GetUsage()
```

#### Returns

CabinetUsageGetResultModel

#### Exceptions

[InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/system.invalidoperationexception)<br>

### <a id="methods-insertfile"/>**InsertFile(Int32, String, Stream, String, Nullable&lt;Boolean&gt;)**

画像ファイルを指定して画像を登録

```csharp
public long InsertFile(int folderId, string fileName, Stream file, string filePath, Nullable<Boolean> overWrite)
```

#### Parameters

`folderId` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
登録先フォルダID

`fileName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
登録画像名
 50バイト以内（全角25文字以内/半角50文字以内）
 使用禁止文字 ： 機種依存文字（コントロールコード除く）、半角カタカナ
 全角スペース → 半角スペースに変換
 スペースのみは不可
 前後にスペースがある場合は、スペースを自動削除
 タグは無効（入力した場合は、タグと判断されたものを削除して表示）

`file` [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)<br>

`filePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
登録file名<br>
 20バイト以内（半角20文字以内）<br>
 デフォルト値 ： img[数字8桁].gif / jpg or imgrc[数字10桁].gif / jpg<br>
 入力可能文字 ： 半角英数字（小文字）/記号は「-」「_」のみ<br>
 使用禁止文字 ： 機種依存文字（コントロールコード含む）、img+8桁の数字、imgrc+10桁の数字<br>
 スペースのみ/字間にスペースは不可<br>
 前後にスペースがある場合は、スペースは自動削除<br>
 タグは無効（入力した場合はタグと判断されたものを削除して表示）<br>

`overWrite` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
上書きフラグ デフォルト値 ： false

#### Returns

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)

### <a id="methods-revertfileintrashbox"/>**RevertFileInTrashbox(Int64, Int32)**

削除フォルダ内にある画像を指定したフォルダに戻す

```csharp
public int RevertFileInTrashbox(long fileId, int folderId)
```

#### Parameters

`fileId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>

`folderId` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

#### Returns

ResultCode

#### Exceptions

[XmlStatusException](./rakuten.rms.api.xml.xmlstatusexception)<br>

### <a id="methods-searchallfiles"/>**SearchAllFiles(Nullable&lt;Int32&gt;, String, String, Nullable&lt;Int32&gt;, String)**

ページング処理を内蔵してすべての FileModel を列挙します。

```csharp
public IEnumerable<FileModel> SearchAllFiles(Nullable<Int32> fileId, string filePath, string fileName, Nullable<Int32> folderId, string folderPath)
```

#### Parameters

`fileId` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`filePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`fileName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`folderId` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`folderPath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[IEnumerable&lt;FileModel&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)

### <a id="methods-searchfile"/>**SearchFile(Nullable&lt;Int32&gt;, String, String, Nullable&lt;Int32&gt;, String, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;)**

```csharp
public CabinetFilesSearchResultModel SearchFile(Nullable<Int32> fileId, string filePath, string fileName, Nullable<Int32> folderId, string folderPath, Nullable<Int32> offset, Nullable<Int32> limit)
```

#### Parameters

`fileId` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`filePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`fileName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`folderId` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`folderPath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`offset` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`limit` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

#### Returns

[CabinetFilesSearchResultModel](./rakuten.rms.api.cabinetapi.searchfileresponse.cabinetfilessearchresultmodel)

### <a id="methods-updatefile"/>**UpdateFile(Int32, String, Stream, String)**

画像IDを指定して画像情報を更新

```csharp
public int UpdateFile(int fileId, string fileName, Stream file, string filePath)
```

#### Parameters

`fileId` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
画像ID

`fileName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
更新画像名
 50バイト以内（全角25文字以内/半角50文字以内）
 使用禁止文字：機種依存文字（コントロールコード除く）、半角カタカナ
 全角スペース → 半角スペースに変換
 スペースのみは不可
 前後にスペースがある場合は、スペースを自動削除
 タグは無効（入力した場合は、タグと判断されたものを削除して更新）

`file` [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)<br>

`filePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
更新ファイル名
 20バイト以内（半角20文字以内）
 renameのみmoveはしない
 登録時にdefaultで設定した場合、img + 別数字,imgrc + 別数字の形式へは変更不可
 登録時と同じ値は指定不可
 入力可能な文字は、半角英数字（小文字）/記号は「-」「_」のみ
 使用禁止文字：機種依存文字（コントロールコード含む）、img+8桁の数字、imgrc+10桁の数字
 スペースのみ/字間にスペースは不可(スペースのみの場合は更新しない)
 前後にスペースがある場合は、スペースは自動削除
 タグは無効（入力した場合はタグと判断されたものを削除して更新）

#### Returns

ResultCode


- - -
[**< クラス一覧**](./)
