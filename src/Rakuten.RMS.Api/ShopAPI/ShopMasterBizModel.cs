using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.ShopAPI
{
    [XmlType("shopMasterBizModel", Namespace = ShopAPI.ModelNamespace)]
    public class ShopMasterBizModel
    {
        public ShopMaster shopMaster { get; set; }
    }
    public class ShopMaster
    {
        public string shopName { get; set; } // 店舗名 String	382	Yes
        public string url { get; set; } // 店舗URL   rString	382	Yes
        public string companyName { get; set; } // 会社名 String	382	Yes
        public string presidentName { get; set; } // 代表者名    String	382	Yes
        public string addressZip { get; set; } // 郵便番号    String	255	Yes
        public string addressPrefecture { get; set; } // 都道府県    String	255	Yes
        public string addressCity { get; set; } // 郡市区 String	255	Yes
        public string addressStreet { get; set; } // それ以降の住所 String	255	Yes
        public string companyTel { get; set; } // 会社代表TEL String	255	Yes
        public string companyFax { get; set; } // 会社代表FAX String	255	Yes
        public string tantouName { get; set; } // 店舗運営責任者名    String	255	Yes
        public string tantouPost { get; set; } // 店舗運営責任者所属部署 String	255	No
        public string tantouTel { get; set; } // お客様問合わせ用TEL String	255	Yes
        public string tantouFax { get; set; } // お客様問合わせ用FAX String	255	Yes
        public string supportTel { get; set; } // 店舗運営責任者連絡先TEL   String	255	Yes
        public string supportFax { get; set; } // 店舗運営責任者連絡先FAX   String	255	Yes
        public string emergencyTel { get; set; } // 楽天からの緊急連絡先TEL   String	255	No
        public string secName { get; set; } // 店舗セキュリティ責任者名
    }
}
