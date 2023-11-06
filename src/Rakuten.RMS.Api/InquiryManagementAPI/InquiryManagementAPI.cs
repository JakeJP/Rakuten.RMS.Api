
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Mail;

using System.Text;

using Rakuten.RMS.Api.JSON;
using System.Web;

namespace Rakuten.RMS.Api.InquiryManagementAPI
{
    /// <summary>
    /// 問い合わせを取得、返信、管理
    /// </summary>
    public class InquiryManagementAPI : RakutenApiJsonClientBase
    {
        /// <summary>
        /// 指定された日付の期間の問い合わせ数を取得
        /// </summary>
        /// <param name="provider"></param>
        internal InquiryManagementAPI(ServiceProvider provider) : base(provider)
        {
        }
        public int GetCount( DateTime fromDate, DateTime toDate, bool? noMerchantReply = null )
        {
            var q = new NameValueCollection {
                { "fromDate", fromDate.ToString("yyyy-MM-ddTHH:mm:ss") },
                { "toDate", toDate.ToString("yyyy-MM-ddTHH:mm:ss") }
            };
            if (noMerchantReply != null)
                q.Add("noMerchantReply", noMerchantReply.ToString().ToLower());
            return GetRequest<CountResponse, InquiryErrorResponse>("https://api.rms.rakuten.co.jp/es/1.0/inquirymng-api/inquiries/count", queryParameters: q)
                .result.count;
        }

        /// <summary>
        /// 指定された条件の問い合わせリストを取得
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <param name="noMerchantReply"></param>
        /// <returns></returns>
        public GetInquiriesResponse GetInquiries(DateTime fromDate, DateTime toDate, int? limit= null, int? page = null, bool? noMerchantReply = null)
        {
            var q = new NameValueCollection {
                { "fromDate", fromDate.ToString("yyyy-MM-ddTHH:mm:ss") },
                { "toDate", toDate.ToString("yyyy-MM-ddTHH:mm:ss") }
            };
            if (limit != null)
                q.Add("limit", limit.ToString());
            if (page != null)
                q.Add("page", page.ToString());
            if (noMerchantReply != null)
                q.Add("noMerchantReply", noMerchantReply.ToString().ToLower());
            return GetRequest<GetInquiriesResponse, InquiryErrorResponse>("https://api.rms.rakuten.co.jp/es/1.0/inquirymng-api/inquiries", queryParameters: q);
        }
        /// <summary>
        /// 問い合わせに対する返信を登録
        /// </summary>
        /// <param name="inquiryNumber"></param>
        /// <returns></returns>
        public Inquiry GetInquiry( string inquiryNumber )
            => GetRequest<GetInquiryResponse>($"https://api.rms.rakuten.co.jp/es/1.0/inquirymng-api/inquiry/{inquiryNumber}").result;
        /// <summary>
        /// 問い合わせに対する返信を登録
        /// </summary>
        /// <param name="inquiryNumber"></param>
        /// <param name="shopId"></param>
        /// <param name="message"></param>
        /// <param name="attachments"></param>
        /// <returns></returns>
        public ReplyResult Reply( string inquiryNumber, string shopId, string message, IList<Attachment> attachments = null)
        {
            return PostRequest<ReplyResponse>("https://api.rms.rakuten.co.jp/es/1.0/inquirymng-api/inquiry/reply",
                new
                {
                    inquiryNumber,
                    shopId,
                    message,
                    attachments
                }).result;
        }

        /// <summary>
        /// 問い合わせ返信に利用する添付ファイルを登録
        /// </summary>
        /// <param name="file"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        public PostAttachmentResponse.Result PostAttachment( Stream file, string contentType = null )
            => PostFile<PostAttachmentResponse,InquiryErrorResponse>("https://api.rms.rakuten.co.jp/es/1.0/inquirymng-api/attachment", file, "file", contentType, new NameValueCollection())
                .result;

        /// <summary>
        /// 問い合わせ返信の添付ファイルを取得
        /// </summary>
        /// <param name="path"></param>
        /// <param name="label"></param>
        /// <returns></returns>
        public Stream GetAttachment(string path, string label)
            => GetRequest<Stream,InquiryErrorResponse>($"https://api.rms.rakuten.co.jp/es/1.0/inquirymng-api/attachment?path={HttpUtility.UrlEncode(path)}&label={HttpUtility.UrlEncode(label)}");

        /// <summary>
        /// 指定された複数の問い合わせを既読状態に変更
        /// </summary>
        /// <param name="inquiryNumbers"></param>
        /// <returns></returns>
        public MarkInquiriesResponse MarkInquiriesAsRead(IList<string> inquiryNumbers)
            => PostRequest<MarkInquiriesResponse, InquiryErrorResponse>("https://api.rms.rakuten.co.jp/es/1.0/inquirymng-api/inquiries/read",
                new { inquiryNumbers }, method: "PATCH");
        /// <summary>
        /// 問い合わせを”完了”状態に変更
        /// </summary>
        /// <param name="inquiryNumbers"></param>
        /// <returns></returns>
        public MarkInquiriesResponse MarkInquiriesAsComplete(IList<string> inquiryNumbers)
            => PostRequest<MarkInquiriesResponse, InquiryErrorResponse>("https://api.rms.rakuten.co.jp/es/1.0/inquirymng-api/inquiries/complete",
                new { inquiryNumbers }, method: "PATCH");
        /// <summary>
        /// 問い合わせを”未完了”状態に変更
        /// </summary>
        /// <param name="inquiryNumbers"></param>
        /// <returns></returns>
        public MarkInquiriesResponse MarkInquiriesAsIncomplete(IList<string> inquiryNumbers)
            => PostRequest<MarkInquiriesResponse, InquiryErrorResponse>("https://api.rms.rakuten.co.jp/es/1.0/inquirymng-api/inquiries/incomplete",
                new { inquiryNumbers }, method: "PATCH");

    }
}
