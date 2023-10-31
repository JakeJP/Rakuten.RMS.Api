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