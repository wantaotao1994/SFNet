using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SFNet.Response
{
    public class OrderConfirmReponse: ASFResponse
    {
        [XmlElement("Body")]

        public OrderConfirmBody OrderConfirmBody { get; set; }


        public OrderConfirmReponse()
        {
            OrderConfirmBody = new OrderConfirmBody();
        }
    }


    public class OrderConfirmBody
    {
        [XmlElement("OrderConfirmResponse")]
        public OrderConfirm OrderConfirm { get; set; }
        public OrderConfirmBody()
        {
            OrderConfirm = new OrderConfirm();
        }
    }

    public class OrderConfirm
    {
        ///客户订单号  
        ///原字段:orderid 
        [XmlAttribute("orderid")]
        public string Orderid { get; set; }

        ///顺丰母运单号(如果dealtype=1，必填)  
        ///原字段:mailno  
        [XmlAttribute("mailno")]
        public string Mailno { get; set; }

        ///备注							1：客户订单号与顺丰运单不匹配				2 ：操作成功  
        ///原字段:res_status  
        [XmlAttribute("res_status")]
        public int ResStatus { get; set; }

    }
}
