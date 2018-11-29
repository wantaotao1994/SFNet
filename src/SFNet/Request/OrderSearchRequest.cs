using SFNet.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SFNet.Request
{

    [XmlRoot("Request")]
    public class OrderSearchRequest : ASFRequest<OrderSearchResponse>
    {
        [XmlElement("Body")]
        public OrderSearchBody OrderSearchBody { get; set; }

        public override string Url => "http://bsp-oisp.sf-express.com/bsp-oisp/sfexpressService";

        public OrderSearchRequest()
        {
            this.ServiceName = "OrderSearchService";
            OrderSearchBody = new OrderSearchBody();
        }

        public override string ToXml()
        {
            return base.ToXml(typeof(OrderSearchRequest), this);
        }
    }

    public class OrderSearch {

        ///客户订单号  
        ///原字段:orderid  
        [XmlAttribute("orderid")]
        public string Orderid { get; set; }

        ///查询类型：1,正向单查询，传入的orderid为正向定单号，			2，退货单查询，传入的orderid为退货原始订单号  
        ///原字段:search_type  
        [XmlAttribute("search_type")]
        public string SearchType { get; set; }
    }

    public class OrderSearchBody
    {
        [XmlElement("OrderSearch")]
        public OrderSearch OrderSearch { get; set; }

        public OrderSearchBody() {

            OrderSearch = new OrderSearch();
        }
    }
}
