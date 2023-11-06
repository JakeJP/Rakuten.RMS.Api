# LicenseManagementAPI

## サンプルコード

```python
sp = ServiceProvider  # 初期設定省略
api = sp.GetLicenseManagementAPI()
d = api.GetExpiryDate()
print("licenceKeyの有効期限:", d)
```