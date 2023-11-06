using System;

namespace Rakuten.RMS.Api
{
    /// <summary>
    /// APIが返すエラーを保持するベースクラス。APIがXML、JSONに応じ、また、エラーの形式によって派生クラスがその内容を保持する。
    /// このライブラリの設計方針としては、基本的に正常時以外は Exception が発生。HTTPレベルのエラーは WebException などが発生する場合もある。
    /// </summary>
    public class RakutenRMSApiException : Exception
    {
        public object Error { get; set; }
        public RakutenRMSApiException() { }
        public RakutenRMSApiException(string message) : base(message) { }
        public RakutenRMSApiException(string message, object error ) : base(message)
        {
            Error = error;
        }
    }
}
