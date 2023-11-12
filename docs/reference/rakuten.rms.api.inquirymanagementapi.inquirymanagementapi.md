<img align="left" style="height: 2em;" src="https://webservice.rakuten.co.jp/favicon.ico"><em>Rakuten RMS WEB API client for .NET</em>

[**< クラス一覧**](./)
- - -

# InquiryManagementAPI

Namespace: Rakuten.RMS.Api.InquiryManagementAPI

問い合わせを取得、返信、管理

```csharp
public class InquiryManagementAPI : Rakuten.RMS.Api.JSON.RakutenApiJsonClientBase
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [RakutenApiClientBaseCommon](./rakuten.rms.api.rest.rakutenapiclientbasecommon) → [RakutenApiJsonClientBase](./rakuten.rms.api.json.rakutenapijsonclientbase) → [InquiryManagementAPI](./rakuten.rms.api.inquirymanagementapi.inquirymanagementapi)

## Methods

### <a id="methods-getattachment"/>**GetAttachment(String, String)**

問い合わせ返信の添付ファイルを取得

```csharp
public Stream GetAttachment(string path, string label)
```

#### Parameters

`path` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`label` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)

### <a id="methods-getcount"/>**GetCount(DateTime, DateTime, Nullable&lt;Boolean&gt;)**

```csharp
public int GetCount(DateTime fromDate, DateTime toDate, Nullable<Boolean> noMerchantReply)
```

#### Parameters

`fromDate` [DateTime](https://docs.microsoft.com/en-us/dotnet/api/system.datetime)<br>

`toDate` [DateTime](https://docs.microsoft.com/en-us/dotnet/api/system.datetime)<br>

`noMerchantReply` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

### <a id="methods-getinquiries"/>**GetInquiries(DateTime, DateTime, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Boolean&gt;)**

指定された条件の問い合わせリストを取得

```csharp
public GetInquiriesResponse GetInquiries(DateTime fromDate, DateTime toDate, Nullable<Int32> limit, Nullable<Int32> page, Nullable<Boolean> noMerchantReply)
```

#### Parameters

`fromDate` [DateTime](https://docs.microsoft.com/en-us/dotnet/api/system.datetime)<br>

`toDate` [DateTime](https://docs.microsoft.com/en-us/dotnet/api/system.datetime)<br>

`limit` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`page` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`noMerchantReply` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

#### Returns

[GetInquiriesResponse](./rakuten.rms.api.inquirymanagementapi.getinquiriesresponse)

### <a id="methods-getinquiry"/>**GetInquiry(String)**

問い合わせに対する返信を登録

```csharp
public Inquiry GetInquiry(string inquiryNumber)
```

#### Parameters

`inquiryNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[Inquiry](./rakuten.rms.api.inquirymanagementapi.inquiry)

### <a id="methods-markinquiriesascomplete"/>**MarkInquiriesAsComplete(IList&lt;String&gt;)**

問い合わせを”完了”状態に変更

```csharp
public MarkInquiriesResponse MarkInquiriesAsComplete(IList<String> inquiryNumbers)
```

#### Parameters

`inquiryNumbers` [IList&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

#### Returns

[MarkInquiriesResponse](./rakuten.rms.api.inquirymanagementapi.markinquiriesresponse)

### <a id="methods-markinquiriesasincomplete"/>**MarkInquiriesAsIncomplete(IList&lt;String&gt;)**

問い合わせを”未完了”状態に変更

```csharp
public MarkInquiriesResponse MarkInquiriesAsIncomplete(IList<String> inquiryNumbers)
```

#### Parameters

`inquiryNumbers` [IList&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

#### Returns

[MarkInquiriesResponse](./rakuten.rms.api.inquirymanagementapi.markinquiriesresponse)

### <a id="methods-markinquiriesasread"/>**MarkInquiriesAsRead(IList&lt;String&gt;)**

指定された複数の問い合わせを既読状態に変更

```csharp
public MarkInquiriesResponse MarkInquiriesAsRead(IList<String> inquiryNumbers)
```

#### Parameters

`inquiryNumbers` [IList&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

#### Returns

[MarkInquiriesResponse](./rakuten.rms.api.inquirymanagementapi.markinquiriesresponse)

### <a id="methods-postattachment"/>**PostAttachment(Stream, String)**

問い合わせ返信に利用する添付ファイルを登録

```csharp
public Result PostAttachment(Stream file, string contentType)
```

#### Parameters

`file` [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)<br>

`contentType` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[Result](./rakuten.rms.api.inquirymanagementapi.postattachmentresponse.result)

### <a id="methods-reply"/>**Reply(String, String, String, IList&lt;Attachment&gt;)**

問い合わせに対する返信を登録

```csharp
public ReplyResult Reply(string inquiryNumber, string shopId, string message, IList<Attachment> attachments)
```

#### Parameters

`inquiryNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`shopId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`message` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`attachments` [IList&lt;Attachment&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>

#### Returns

[ReplyResult](./rakuten.rms.api.inquirymanagementapi.replyresult)


- - -
[**< クラス一覧**](./)
