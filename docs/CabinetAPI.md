# CabinetAPI

- [クラスリファレンス](reference/rakuten.rms.api.cabinetapi.cabinetapi)
- サンプルコード(python)

## サンプル

### すべてのフォルダとファイルを列挙(python)
```python
sp = ServiceProvider # 初期設定は省略
api = sp.GetCabinetAPI()

for f in api.GetAllFolders():
    print("#", f.FolderName, f.FolderPath, '[' + str(f.FolderId) + '](', f.FileCount, ')')
    for file in api.GetAllFiles(f.FolderId):
        print("-- [", file.FileId, "] ", file.FileName, file.FilePath, file.FileUrl, file.FileSize )
```

### ファイルをアップロード(python)

```python
from System.IO import File

fs = File.OpenRead("test.jpg")
fileId = api.InsertFile( 0, "test", fs )

fs = File.OpenRead("test.jpg")
res = api.UpdateFile(fileId, filePath = "abcd.jpg")

res = api.DeleteFile(fileId)
```