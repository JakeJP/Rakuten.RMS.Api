using System;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.SystemEventNotification
{
    /*
    正常終了
    N-000-000   正常終了しました

        異常終了
    E-400-100   配信情報に不正な値が含まれています
    E-400-101   認証キーが一致しません
    E-400-900   配信情報の受信処理で予期せぬエラーが発生しました
    */
    public enum ResultCode
    {
        Successful,
        IllegalValues,
        AuthMismatch,
        UnexpectedError
    }

    public class Notification
    {
        public static void HandleOrderNoify(HttpRequest request, HttpResponse response, Func<OrderNotifyModel, ResultCode> handler)
        {
            Handle(request, response, handler);
        }
        public static void HandleSystemInfoNotify(HttpRequest request, HttpResponse response, Func<SystemNotifyModel, ResultCode> handler)
        {
            Handle(request, response, handler);
        }
        protected static void Handle<TModel>(HttpRequest request, HttpResponse response, Func<TModel, ResultCode> handler)
        {
            ResultCode resultCode = ResultCode.UnexpectedError;
            XmlSerializer sz = null;
            try
            {
                if (request.HttpMethod != "POST")
                    throw new InvalidOperationException("HTTP method is not POST.");

                sz = new XmlSerializer(typeof(TModel));
                var model = (TModel)sz.Deserialize(request.InputStream);

                resultCode = handler(model);
            }
            catch (Exception ex)
            {
                resultCode = ResultCode.UnexpectedError;
                throw ex;
            }
            finally
            {
                var res = new ResponseModel(resultCode);
                sz = new XmlSerializer(typeof(ResponseModel));
                response.ContentType = "text/xml";
                var ns = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
                sz.Serialize(response.OutputStream, res, ns);
            }
        }
    }
}
