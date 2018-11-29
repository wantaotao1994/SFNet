using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SFNet.Response
{
    public class OrderFilterResponse: ASFResponse
    {
        [XmlElement("Body")]

        public OrderFilterBody OrderFilterBody { get; set; }

        public OrderFilterResponse()
        {
            OrderFilterBody = new OrderFilterBody();
        }
    }

    public class OrderFilterBody
    {
        [XmlElement("OrderFilterResponse")]
        public OrderFilter OrderFilter { get; set; }

        public  OrderFilterBody()
        {
            OrderFilter = new OrderFilter();
        }
    }

    public class OrderFilter
    {
        ///客户订单号  
        ///原字段:orderid  
        [XmlAttribute("orderid")]
        public string Orderid { get; set; }

        ///筛单结果：1：人工确认 2：可收派 3：不可以收派 当filter_type=1时，不存在1值。  
        ///原字段:filter_result  
        [XmlAttribute("filter_result")]
        public int FilterResult { get; set; }

        ///原寄地区域代码，如果可收派，此项不能为空。  
        ///原字段:origincode  
        [XmlAttribute("origincode")]
        public string Origincode { get; set; }

        ///目的地区域代码，如果可收派，此项不能为空。
        ///原字段:destcode  
        [XmlAttribute("destcode")]
        public string Destcode { get; set; }

        ///如果filter_result=3时为必填，不可以收派的原因代码： 1：收方超范围 2：派方超范围 3-：其它原因  
        ///原字段:remark  
        [XmlAttribute("remark")]
        public string Remark { get; set; }
    }
}
