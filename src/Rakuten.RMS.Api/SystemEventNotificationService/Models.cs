using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.SystemEventNotification
{
    [XmlRoot("responseModel")]
    public class ResponseModel
    {
        public ResponseModel()
        {
            ResultCode = "N-000-000";
        }
        public ResponseModel(ResultCode code)
        {
            ResultCode = code == SystemEventNotification.ResultCode.Successful ? "N-000-000" :
                code == SystemEventNotification.ResultCode.AuthMismatch ? "E-400-101" :
                code == SystemEventNotification.ResultCode.IllegalValues ? "E-400-100" :
                code == SystemEventNotification.ResultCode.UnexpectedError ? "E-400-900" : null;
        }
        [XmlElement("resultCode")]
        public string ResultCode { get; set; }
    }
    public class AuthModel
    {
        [XmlElement("contractId")]
        public string ContractId { get; set; }
        [XmlElement("shopUrl")]
        public string ShopUrl { get; set; }
        [XmlElement("authKey")]
        public string AuthKey { get; set; }
    }
    public class BasketModel
    {
        [XmlElement("itemId")]
        public string ItemId { get; set; }
        [XmlElement("pageURL")]
        public string PageURL { get; set; }
        [XmlElement("inventoryType")]
        public int InventoryType { get; set; }
        [XmlElement("units")]
        public int Units { get; set; }
        [XmlElement("orgItemNumber")]
        public string OrgItemNumber { get; set; }
        [XmlElement("itemNumber")]
        public string ItemNumber { get; set; }
        [XmlElement("selectedChoice")]
        public string SelectedChoice { get; set; }
        [XmlElement("h_choice_c_name")]
        public string h_choice_c_name { get; set; }
        [XmlElement("v_choice_c_name")]
        public string v_choice_c_name { get; set; }
    }

    public class OrderInfoNotifyModel
    {
        [XmlElement("orderNumber")]
        public string OrderNumber { get; set; }
        [XmlElement("seqId")]
        public string SeqId { get; set; }
        [XmlElement("orderDate")]
        public string OrderDateString { get => OrderDate.ToString("yyyy/MM/dd hh:mm:ss"); set => OrderDate = DateTime.Parse(value); }
        [XmlIgnore]
        public DateTime OrderDate { get; set; }


        [XmlElement("orderType")]
        ///半角数字最大1桁
        /// 1：通常購入
        /// 4：定期購入
        /// 5：頒布会
        /// 6：予約商品
        public int OrderType { get; set; }

        [XmlElement("basketModel")]
        public BasketModel[] BasketModel { get; set; }

    }
    [XmlRoot("orderNotifyModel")]
    public class OrderNotifyModel
    {
        [XmlElement("authModel")]
        public AuthModel AuthModel { get; set; }
        [XmlElement("orderInfoNotifyModel")]
        public List<OrderInfoNotifyModel> OrderInfoNotifyModel { get; set; }
    }

    [XmlRoot("notifyModel")]
    public class SystemNotifyModel
    {
        [XmlElement("authModel")]
        public AuthModel AuthModel { get; set; }

        [XmlElement("notifyInfoModel")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public List<NotifyInfoModel> _NotifyInfoModel { get; set; }


        List<NotifyInfoModel> _list = null;
        [XmlIgnore]
        public List<NotifyInfoModel> NotifyInfoModel
        {
            get
            {
                if (_list == null)
                {
                    _list = _NotifyInfoModel.Select(m =>
                       m.ServiceId == 3000 && m.FunctionId == 1100 ? (NotifyInfoModel)new ProductEditCompleteNotifyModel(m) :
                       m.ServiceId == 3100 && m.FunctionId == 1100 ? (NotifyInfoModel)new ImageEditCompleteNotifyModel(m) :
                       m.ServiceId == 4000 && m.FunctionId == 1100 ? (NotifyInfoModel)new PurchaseHistoryChangeNotifyModel(m) :
                       m.ServiceId == 4100 && m.FunctionId == 1100 ? (NotifyInfoModel)new RestockRequestNotifyModel(m) :
                       m.ServiceId == 5000 && m.FunctionId == 1100 ? (NotifyInfoModel)new AuthorizationResultModel(m) :
                       m.ServiceId == 5100 && m.FunctionId == 1100 ? (NotifyInfoModel)new CautiousOrderNotifyModel(m)
                       : null
                    ).ToList();
                }
                return _list;
            }
        }
    }
    public class ValueElement
    {
        [XmlAttribute("name")]
        public string Name { get; set; }
        [XmlText]
        public string Value { get; set; }
    }
    public class NotifyInfoModel
    {
        [XmlElement("requestId")]
        public string RequestId { get; set; }
        [XmlElement("serviceId")]
        public int ServiceId { get; set; }
        [XmlElement("functionId")]
        public int FunctionId { get; set; }
        [XmlElement("value1")]
        public ValueElement Value1 { get; set; }
        [XmlElement("value2")]
        public ValueElement Value2 { get; set; }
        [XmlElement("value3")]
        public ValueElement Value3 { get; set; }
        [XmlElement("value4")]
        public ValueElement Value4 { get; set; }
        [XmlElement("value5")]
        public ValueElement Value5 { get; set; }
        [XmlElement("value6")]
        public ValueElement Value6 { get; set; }
        [XmlElement("value7")]
        public ValueElement Value7 { get; set; }
        [XmlElement("value8")]
        public ValueElement Value8 { get; set; }
        [XmlElement("value9")]
        public ValueElement Value9 { get; set; }
        [XmlElement("value10")]
        public ValueElement Value10 { get; set; }

        protected void Copy(NotifyInfoModel model)
        {
            RequestId = model.RequestId; ServiceId = model.ServiceId; FunctionId = model.FunctionId;
            Value1 = model.Value1;
            Value2 = model.Value2;
            Value3 = model.Value3;
            Value4 = model.Value4;
            Value5 = model.Value5;
            Value6 = model.Value6;
            Value7 = model.Value7;
            Value8 = model.Value8;
            Value9 = model.Value9;
            Value10 = model.Value10;
        }
    }

    /// <summary>
    /// 商品一括編集完了通知 3000:1100
    /// </summary>
    public class ProductEditCompleteNotifyModel : NotifyInfoModel
    {
        public ProductEditCompleteNotifyModel(NotifyInfoModel model)
        {
            Copy(model);
        }
        public string FileName => Value1.Value;
        public DateTime ProcessDate => DateTime.Parse(Value2.Value);
        public int InsertCount => int.Parse(Value3.Value);
        public int UpdateCount => int.Parse(Value4.Value);
        public int DeleteCount => int.Parse(Value5.Value);
        public int ErrorCount => int.Parse(Value6.Value);
        public string ErrorFilePath => Value7.Value;
    }

    /// <summary>
    /// 画像一括編集完了通知 3100:1100
    /// </summary>
    public class ImageEditCompleteNotifyModel : NotifyInfoModel
    {
        public ImageEditCompleteNotifyModel(NotifyInfoModel model) => Copy(model);
        public string FileName => Value1.Value;
        public DateTime ProcessDatetime => DateTime.Parse(Value2.Value);
        public int InsertCount => int.Parse(Value3.Value);
        public int ErrorCount => int.Parse(Value4.Value);
        public string ErrorFilePath => Value5.Value;
    }

    /// <summary>
    /// 購入履歴変更通知 4000:1100
    /// </summary>
    public class PurchaseHistoryChangeNotifyModel : NotifyInfoModel
    {
        public PurchaseHistoryChangeNotifyModel(NotifyInfoModel model) => Copy(model);
        public string Operation => Value1.Value;
        public string OrderNumber => Value2.Value;
        public string Subkey => Value3.Value;
        public string Class => Value4.Value;
        public string Field => Value5.Value;
        public string Before => Value6.Value;
        public string After => Value7.Value;
        /// <summary>
        /// 1 : 通常購入
        /// 4 : 定期購入
        /// 5 : 頒布会
        /// 6 : 予約
        /// </summary>
        public int OrderType => int.Parse(Value8.Value);
        public DateTime OrderDate => DateTime.Parse(Value9.Value);
        public DateTime Timestamp => DateTime.Parse(Value10.Value);
    }

    /// <summary>
    /// 再入荷リクエスト通知 4100:1100
    /// </summary>
    public class RestockRequestNotifyModel : NotifyInfoModel
    {
        public RestockRequestNotifyModel(NotifyInfoModel model) => Copy(model);
        public string PageURL => Value1.Value;
        public string orgItemNumber => Value2.Value;
        public int InventoryType => int.Parse(Value3.Value);
        public string HorizontalName => Value4.Value;
        public string VerticalName => Value5.Value;
        public string ChoiceNameHor => Value6.Value;
        public string ChoiceNameVer => Value7.Value;
        public string ChildNoHor => Value8.Value;
        public string ChildNoVer => Value9.Value;
        public DateTime EntryDate => DateTime.Parse(Value10.Value);
    }

    /// <summary>
    /// 審査結果通知 5000:1100
    /// </summary>
    public class AuthorizationResultModel : NotifyInfoModel
    {
        public AuthorizationResultModel(NotifyInfoModel model) { Copy(model); }
        public string OrderNumber => Value1.Value;
        /// <summary>
        /// 1：発送指示
        /// 2：楽天側キャンセル※1
        /// 3：発送指示取消※2
        /// ※1 楽天側で注文がキャンセルされた後、通知が配信されます。
        /// ※2 予約注文確定時の再オーソリ処理においてNGとなった場合などに、この通知が配信されます
        /// </summary>
        public int NotificationType => int.Parse(Value2.Value);
        public DateTime OccurrenceDatetime => DateTime.Parse(Value3.Value);

    }
    /// <summary>
    ///  警告表示注文通知 5100:1100
    /// </summary>
    public class CautiousOrderNotifyModel : NotifyInfoModel
    {
        public CautiousOrderNotifyModel(NotifyInfoModel model) => Copy(model);
        public string OrderNumber => Value1.Value;
        public int CautionDisplayType => int.Parse(Value2.Value);
        public DateTime OccurrenceDatetime => DateTime.Parse(Value3.Value);
    }
}
