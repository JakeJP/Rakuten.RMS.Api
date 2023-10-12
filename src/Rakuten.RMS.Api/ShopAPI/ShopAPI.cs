using System;
using Rakuten.RMS.Api.XML;

namespace Rakuten.RMS.Api.ShopAPI
{
    public class ShopAPI : RakutenApiXmlClientBase
    {
        public ShopAPI(ServiceProvider provider) : base(provider)
        {
        }

        public ShopBizApiResponse<TopDisplayBizModel> GetTopDisplay()
        {
            return Get<ShopBizApiResponse<TopDisplayBizModel>>("https://api.rms.rakuten.co.jp/es/1.0/shop/topDisplay");
        }
        public void EditTopDisplay()
        {
            throw new NotImplementedException();
        }
        public void GetShopLayoutImage()
        {
            throw new NotImplementedException();
        }
        public void EditShopLayoutImage()
        {
            throw new NotImplementedException();
        }
        public void GetShopLayoutCommon()
        {
            throw new NotImplementedException();
        }
        public void EditShopLayoutCommon()
        {
            throw new NotImplementedException();
        }
        public void GetNaviButtonInfo()
        {
            throw new NotImplementedException();
        }
        public void EditNaviButtonInfo()
        {
            throw new NotImplementedException();
        }
        public void GetNaviButton()
        {
            throw new NotImplementedException();
        }
        public void EditNaviButton()
        {  throw new NotImplementedException();}
        public void GetLayoutTextSmall()
        {
            new NotImplementedException();
        }
        public void GetLayoutLossLeader()
        {
            throw new NotImplementedException();
        }
        public void GetLayoutItemMap()
        {
            throw new NotImplementedException();
        }
        public void GetLayoutCategoryMap()
        {
            throw new NotImplementedException();
        }

        public void GetShopCalendar()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// RMS WEB SERVICE : shop.delvdateMaster.get
        /// </summary>
        public ShopBizApiResponse<DelvdateMasterBizModel> GetDelvdateMaster(string delvdateNumber = null)
        {
            var url = @"https://api.rms.rakuten.co.jp/es/1.0/shop/delvdateMaster";
            if (!string.IsNullOrEmpty(delvdateNumber))
                url += "?delvdateNumber=" + delvdateNumber;
            return Get<ShopBizApiResponse<DelvdateMasterBizModel>>(url);
        }
        public void GetDeliverySetInfo()
        {
            throw new NotImplementedException();
        }
        public void GetSoryoKbn()
        {
            throw new NotImplementedException();
        }
        public void GetShopAreaSoryo()
        {
            throw new NotImplementedException();
        }
        public void EditShopAreaSoryo()
        {
            throw new NotImplementedException();
        }

        public void GetDelvAreaMaster()
        {
            throw new NotImplementedException();
        }

        public void GetLayoutTextLarge()
        {
            throw new NotImplementedException();
        }

        public void EditLayoutTextLarge()
        {
            throw new NotImplementedException();
        }

        public void GetGoldTop()
        {
            throw new NotImplementedException();
        }

        public void EditGoldTop()
        {
            throw new NotImplementedException();
        }

        public void GetShopMaster()
        {
            throw new NotImplementedException();
        }

        public void GetShopCalendarAndDesign()
        {
            throw new NotImplementedException();
        }

        public void EditShopCalendarAndDesign()
        {
            throw new NotImplementedException();
        }

        public void GetShopHoliday()
        {
            throw new NotImplementedException();
        }

        public void EditShopHoliday()
        {
            throw new NotImplementedException();
        }

        public void GetSpBigBanner()
        {
            throw new NotImplementedException();
        }

        public void EditSpBigBanner()
        {
            throw new NotImplementedException();
        }

        public void GetSpCategoryPage()
        {
            throw new NotImplementedException();
        }

        public void EditSpCategoryPage()
        {
            throw new NotImplementedException();
        }

        public void GetSpItemPage()
        {
            throw new NotImplementedException();
        }

        public void EditSpItemPage()
        {
            throw new NotImplementedException();
        }

        public void GetSpMedamaCategory()
        {
            throw new NotImplementedException();
        }

        public void EditSpMedamaCategory()
        {
            throw new NotImplementedException();
        }

        public void GetSpMedamaItem()
        {
            throw new NotImplementedException();
        }

        public void EditSpMedamaItem()
        {
            throw new NotImplementedException();
        }

        public void GetSpSmallBanner()
        {
            throw new NotImplementedException();
        }

        public void EditSpSmallBanner()
        {
            throw new NotImplementedException();
        }

        public void GetSpTopPage()
        {
            throw new NotImplementedException();
        }

        public void EditSpTopPage()
        {
            throw new NotImplementedException();
        }

        public void GetSpTopPageDisplay()
        {
            throw new NotImplementedException();
        }

        public void GetShopStatus()
        {
            throw new NotImplementedException();
        }

        public void EditShopStatus()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// この機能を利用すると、出荷リードタイムを取得することができます。※SKU移行後の店舗様向けの機能です。
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ShopBizApiResponse<OperationLeadTimeBizModel> GetOperationLeadTime(int? id = null)
        {
            var url = "https://api.rms.rakuten.co.jp/es/1.0/shop/operationLeadTime";
            if (id.HasValue)
                url += "?operationLeadTimeId=" + id.ToString();
            return Get<ShopBizApiResponse<OperationLeadTimeBizModel>>(url);
        }

        public void GetShipFrom()
        {
            throw new NotImplementedException();
        }

        public void GetSignboard()
        {
            throw new NotImplementedException();
        }

        public void EditSignboard()
        {
            throw new NotImplementedException();
        }





    }
}
