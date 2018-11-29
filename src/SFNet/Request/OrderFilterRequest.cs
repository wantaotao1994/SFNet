using SFNet.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SFNet.Request
{
    [XmlRoot("Request")]
    public class OrderFilterRequest : ASFRequest<OrderFilterResponse>
    {
        [XmlElement("Body")]
        public OrderFilterBody OrderFilterBody { get; set; }

        public override string Url => "http://bsp-oisp.sf-express.com/bsp-oisp/sfexpressService";

        public override string ToXml()
        {
            return base.ToXml(typeof(OrderFilterRequest), this);
        }

        public OrderFilterRequest() {
            this.ServiceName = "OrderFilterService";
            OrderFilterBody = new OrderFilterBody();

        }
    }

    public class OrderFilterBody {

        [XmlElement("OrderFilter")]
        public OrderFilter OrderFilter { get; set; }

        public OrderFilterBody() {
            OrderFilter = new OrderFilter();

        }
    }

    public class OrderFilter
    {
        ///筛单类别 1：自动筛单（系统根据地址库进行判断，并返回结果，系统无法检索到可派送的将返回不可派送）				2：可人工筛单（系统首先根据地址库判断，如果无法自动判断是否收派，系统将生成需要人工判断的任务，后续由人工处理，处理结束后，顺丰可主动推送给客户系统）  
        ///原字段:filter_type  
        [XmlAttribute("filter_type")]
        public int FilterType { get; set; }

        ///客户订单号，filter_type=2则必须提供。  
        ///原字段:orderid  
        [XmlAttribute("orderid")]
        public string Orderid { get; set; }

        ///到件方详细地址，需要包括省市区，如：广东省深圳市福田区新洲十一街万基商务大厦。  
        ///原字段:d_address  
        [XmlAttribute("d_address")]
        public string DAddress { get; set; }

        [XmlElement("OrderFilterOption")]
        public OrderFilterOption OrderFilterOption { get; set; }

        public OrderFilter() {
            OrderFilterOption = new OrderFilterOption();
        }
    }

    public class OrderFilterOption
    {
        ///寄件方电话  
        ///原字段:j_tel  
        [XmlAttribute("j_tel")]
        public string JTel { get; set; }

        ///寄件人所在国家代码  
        ///原字段:country  
        [XmlAttribute("country")]
        public string Country { get; set; }

        ///寄件方所在省份，必须是标准的省名称称谓 如：广东省，如果是直辖市，请直接传北京、上海等。  
        ///原字段:province  
        [XmlAttribute("province")]
        public string Province { get; set; }

        ///寄件方所属城市名称，必须是标准的城市称谓 如：深圳市。  
        ///原字段:city  
        [XmlAttribute("city")]
        public string City { get; set; }

        ///寄件人所在县/区，必须是标准的县/区称谓，示例：“福田区”。  
        ///原字段:county  
        [XmlAttribute("county")]
        public string County { get; set; }

        ///到件方国家  
        ///原字段:d_country  
        [XmlAttribute("d_country")]
        public string DCountry { get; set; }

        ///到件方所在省份，必须是标准的省名称称谓 如：广东省，如果是直辖市，请直接传北京、上海等。  
        ///原字段:d_province  
        [XmlAttribute("d_province")]
        public string DProvince { get; set; }

        ///到件方所属城市名称，必须是标准的城市称谓 如：深圳市，如果是直辖市，请直接传北京（或北京市）、上海（或上海市）等。  
        ///原字段:d_city  
        [XmlAttribute("d_city")]
        public string DCity { get; set; }

        ///到件方所在县/区，必须是标准的县/区称谓，示例：“福田区”。  
        ///原字段:d_county  
        [XmlAttribute("d_county")]
        public string DCounty { get; set; }

        ///寄件方详细地址，包括省市区，示例：“广东省深圳市福田区新洲十一街万基商务大厦10楼”。  
        ///原字段:j_address  
        [XmlAttribute("j_address")]
        public string JAddress { get; set; }

        ///到件方电话  
        ///原字段:d_tel  
        [XmlAttribute("d_tel")]
        public string DTel { get; set; }

        ///结账号，用于在人工筛单时，筛单人员识别客户使用。  
        ///原字段:j_custid  
        [XmlAttribute("j_custid")]
        public string JCustid { get; set; }


    }
}
