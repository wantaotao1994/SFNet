using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SFNet.Response
{
   public class OrderSearchResponse: ASFResponse
    {
        [XmlElement("Body")]
        public OrderSearchOrderBody OrderSearchOrderBody { get; set; }

        public OrderSearchResponse()
        {
            OrderSearchOrderBody = new OrderSearchOrderBody();
        }
    }



    public class OrderSearchOrderBody
    {
        [XmlElement("OrderSearchService")]
        public OrderSearchOrderResponse OrderSearchOrderResponse { get; set; }
        public OrderSearchOrderBody()
        {
            OrderSearchOrderResponse = new OrderSearchOrderResponse();
        }

    }

    public class OrderSearchOrderResponse
    {
        ///客户订单号  
        ///原字段:orderid  
        [XmlAttribute("orderid")]
        public string Orderid { get; set; }

        ///顺丰运单号，一个订单只能有一个母单号，如果是子母单的情况，以半角逗号分隔，主单号在第一个位置，如“755123456789,001123456789,002123456789”。  
        ///原字段:mailno  
        [XmlAttribute("mailno")]
        public string Mailno { get; set; }

        ///原寄地区域代码  
        ///原字段:origincode  
        [XmlAttribute("origincode")]
        public string Origincode { get; set; }

        ///目的地区域代码  
        ///原字段:destcode  
        [XmlAttribute("destcode")]
        public string Destcode { get; set; }

        ///筛单结果：							1：人工确认				2：可收派				3：不可以收派  
        ///原字段:filter_result  
        [XmlAttribute("filter_result")]
        public int FilterResult { get; set; }

        ///如果filter_result=3时为必填，不可以收派的原因代码：							1：收方超范围				2：派方超范围				3-：其它原因  
        ///原字段:remark  
        [XmlAttribute("remark")]
        public string Remark { get; set; }


    }
}
