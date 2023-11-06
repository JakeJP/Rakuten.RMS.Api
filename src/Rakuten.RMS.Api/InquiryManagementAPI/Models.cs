using System;
using System.Collections.Generic;
using System.Linq;

namespace Rakuten.RMS.Api.InquiryManagementAPI
{
    public class CountResponse
    {
        public class Result
        {
            public int count { get; set; }
        }
        public Result result { get; set; }
    }
    public class GetInquiriesResponse
    {
        public int totalCount { get; set; }
        public int totalPageCount { get; set; }
        public int page { get; set; }
        public List<Inquiry> list { get; set; }
    }
    public class GetInquiryResponse
    {
        public Inquiry result { get; set; }
    }
    public class ReplyResponse
    {
        public ReplyResult result { get; set; }
    }
    public class Inquiry
    {
        /// <summary>
        /// 問い合わせ番号
        /// </summary>
        public string inquiryNumber { get; set; }
        /// <summary>
        /// 店舗ID
        /// </summary>
        public int shopId { get; set; }
        /// <summary>
        /// ユーザ氏名
        /// </summary>
        public string userName { get; set; }
        /// <summary>
        /// ユーザーマスクメールアドレス
        /// </summary>
        public string userMaskEmail { get; set; }
        /// <summary>
        /// メッセージ
        /// </summary>
        public string message { get; set; }
        /// <summary>
        /// 問い合わせ日時
        /// </summary>
        public DateTime regDate { get; set; }
        /// <summary>
        /// 商品URL
        /// </summary>
        public string itemUrl { get; set; }
        /// <summary>
        /// 商品名
        /// </summary>
        public string itemName { get; set; }
        /// <summary>
        /// 商品番号
        /// </summary>
        public string itemNumber { get; set; }
        /// <summary>
        /// 処理完了フラグ
        /// </summary>
        public bool isCompleted { get; set; }
        /// <summary>
        /// 処理完了日時
        /// </summary>
        public DateTime? completedDate { get; set; }
        /// <summary>
        /// 受注番号
        /// </summary>
        public string orderNumber { get; set; }
        /// <summary>
        /// 店舗既読フラグ
        /// </summary>
        public bool readByMerchant { get; set; }
        /// <summary>
        /// attachments 添付ファイル  
        /// </summary>
        public List<Attachment> attachments { get;set;}
        /// <summary>
        /// 返信
        /// </summary>
        public List<Reply> replies { get; set; }
        /// <summary>
        /// 問い合わせカテゴリ
        /// </summary>
        public string category { get; set; }
        /// <summary>
        /// 問い合わせタイプ
        /// </summary>
        public string type { get; set; }
        /// <summary>
        ///  メッセージ削除 boolean メッセージが楽天によって削除されたか否かを表します。
        /// </summary>
        public bool isMessageDeleted { get; set; }
        /// <summary>
        /// 最終更新日
        /// </summary>
        public DateTime lastUpdateDate { get; set; }
        public class Attachment
        {
            public string label { get; set; }
            public string path { get; set; }
        }
        public class Reply
        {
            public long id { get; set; }
            public string message { get; set; }
            public DateTime regDate { get; set; }
            public bool isRead { get; set; }
            public bool isMessageDeleted { get; set; }
            public List<Attachment> attachments { get; set; }
        }

    }
    public class ReplyResult
    {
        public string inquiryNumber { get; set; }
        public string message { get; set; }
        public DateTime regDate { get; set; }
        public string replyFrom { get; set; }
        public bool isRead { get; set; }
        public List<Inquiry.Attachment> attachments { get; set; }
    }

    public class PostAttachmentResponse
    {
        public Result result { get; set; }
        public class Result
        {
            public string label { get; set; }
            public string path { get; set; }
        }
    }

    public class MarkInquiriesResponse
    {
        public Result result { get; set; }
        public class Result
        {
            public List<string> ok { get; set; }
            public List<Error> error { get; set; }
            public class Error
            {
                public string inquiryNumber { get; set; }
                public string errorMessage { get; set; }

            }
        }
    }
    public class InquiryErrorResponse
    {
        public override string ToString()
        {
            if( error == null ) base.ToString();
            return string.Format("[{0}] : {1}\n{2}", error.code, error.message, string.Join( ", ", error.targets.Select(m=> string.Format("{0}: {1}",m.Key, m.Value))));
        }
        public ResultError error { get; set; }
        public class ResultError
        {
            public string code { get; set; }
            public string message { get; set; }
            public Dictionary<string,string> targets { get; set; }
        }
    }
}
