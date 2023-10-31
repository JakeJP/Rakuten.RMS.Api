using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.ShopAPI
{
    [XmlType(TypeName = "naviButtonBizModel", Namespace = ShopAPI.ModelNamespace)]
    public class NaviButtonBizModel
    {
        public NaviButton naviButton { get; set; }
    }
    public class NaviButton
    {
        public long intervalWidth { get; set; }
        public long intervalHeight { get; set; }
        public int buttonCols { get; set; }
        public int buttonColsPosition { get; set; }
    }
    [XmlType(TypeName = "naviButtonBizModel", Namespace = ShopAPI.ModelNamespace)]
    public class NaviButtonBizModelRequest
    {
        public List<NaviButton> insertList { get; set; }
        public List<NaviButton> updateList { get; set; }
        public List<NaviButton> deleteList { get; set; }
    }

}
