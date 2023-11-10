# Shop API

## サンプルコード

```python
sp = ServiceProvider # 初期化部分省略
api = sp.GetShopAPI()

getMethodList = [
    ("GetTopDisplay","EditTopDisplay"),
    ("GetShopLayoutImage","EditShopLayoutImage"),
    "GetShopLayoutCommon", # asymmetric parameter
    "GetNaviButtonInfo",# asymmetric parameter
    "GetNaviButton",
    "GetLayoutTextSmall",
    "GetLayoutLossLeader",
    "GetLayoutItemMap",
    "GetLayoutCategoryMap",
    "GetShopCalendar",
    "GetDelvdateMaster",
    "GetDeliverySetInfo",
    "GetSoryoKbn",
    "GetShopAreaSoryo",
    "GetDelvAreaMaster",
    "GetLayoutTextLarge", #,"EditLayoutTextLarge"),
    #("GetGoldTop","EditGoldTop"),
    "GetShopMaster",
    "GetShopCalendarAndDesign",
    "GetShopHoliday",
    #"GetSpBigBanner",
    "GetSpCategoryPage",
    "GetSpMedamaCategory",
    #"GetSpMedamaItem",
    #"GetSpSmallBanner",
    "GetSpTopPage",
    #"GetSpTopPageDisplay",
    "GetOperationLeadTime"
    ]
for m in getMethodList:
    if type(m) is tuple:
        methodName = m[0]
        editMethod = m[1]
    else:
        methodName = m
        editMethod = None
    method = getattr(api, methodName)
    result = method()
```