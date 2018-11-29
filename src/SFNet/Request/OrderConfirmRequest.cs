using SFNet.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SFNet.Request
{
    [XmlRoot("Request")]
    public class OrderConfirmRequest : ASFRequest<OrderConfirmReponse>
    {
        public override string Url => "http://bsp-oisp.sf-express.com/bsp-oisp/sfexpressService";

        public override string ToXml()
        {
            return base.ToXml(typeof(OrderConfirmRequest), this);
        }

        [XmlElement("Body")]
        public OrderConfirmBody OrderConfirmBody { get; set; }

        public OrderConfirmRequest() {
            this.ServiceName = "OrderConfirmService";
            OrderConfirmBody = new OrderConfirmBody();
        }
    }

    public class OrderConfirmBody
    {
        [XmlElement("OrderConfirm")]
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

        ///客户订单操作标识：							1：确认				2：取消  
        ///原字段:dealtype  
        [XmlAttribute("dealtype")]
        public int Dealtype { get; set; }

        ///-- 报关批次  
        ///原字段:customs_batchs  
        [XmlAttribute("customs_batchs")]
        public string CustomsBatchs { get; set; }

        ///-- 代理单号  
        ///原字段:agent_no  
        [XmlAttribute("agent_no")]
        public string AgentNo { get; set; }

        ///收派员工号  
        ///原字段:consign_emp_code  
        [XmlAttribute("consign_emp_code")]
        public string ConsignEmpCode { get; set; }

        ///原寄地网点代码  
        ///原字段:source_zone_code  
        [XmlAttribute("source_zone_code")]
        public string SourceZoneCode { get; set; }

        ///头程运单号  
        ///原字段:in_process_waybill_no  
        [XmlAttribute("in_process_waybill_no")]
        public string InProcessWaybillNo { get; set; }

        [XmlElement("OrderConfirmOption")]
        public OrderConfirmOption OrderConfirmOption { get; set; }

        public OrderConfirm() {
            OrderConfirmOption = new OrderConfirmOption();
        }
    }

    public class OrderConfirmOption
    {
        ///订单货物总重量，包含子母件，单位千克，精确到小数点后2位，如果提供此值，必须>0。  
        ///原字段:weight  
        [XmlAttribute("weight")]
        public int Weight { get; set; }

        ///货物的总体积（值为长，宽，高），包含子母件，以半角逗号分隔，单位厘米，精确到小数点后2位，会用于计抛（是否计抛具体商务沟通中双方约定）。  
        ///原字段:volume  
        [XmlAttribute("volume")]
        public string Volume { get; set; }

        ///顺丰签回单服务运单号  
        ///原字段:return_tracking  
        [XmlAttribute("return_tracking")]
        public string ReturnTracking { get; set; }

        ///快件产品类别，详见附录《快件产品类别表》，只有在商务上与顺丰约定的类别方可使用。如果此字段为空，则以下单时的为准。  
        ///原字段:express_type  
        [XmlAttribute("express_type")]
        public string ExpressType { get; set; }

        ///子单号（以半角逗号分隔）如果此字段为空，则以下订单时为准。  
        ///原字段:children_nos  
        [XmlAttribute("children_nos")]
        public string ChildrenNos { get; set; }

        ///电子运单图片规格 1:A4 2:A5  
        ///原字段:waybill_size  
        [XmlAttribute("waybill_size")]
        public int WaybillSize { get; set; }

        ///是否生成电子运单图片  
        ///原字段:is_gen_eletric_pic  
        [XmlAttribute("is_gen_eletric_pic")]
        public int IsGenEletricPic { get; set; }


    }
}
