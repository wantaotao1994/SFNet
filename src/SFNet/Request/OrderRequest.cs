using SFNet.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SFNet.Request
{
    [XmlRoot("Request")]
    public class OrderRequest : ASFRequest<OrderResponse>
    {
        [XmlElement("Body")]
        public OrderBody OrderBody { get; set; }

        public override string Url => "http://bsp-oisp.sf-express.com/bsp-oisp/sfexpressService";

        public OrderRequest() {
            this.ServiceName = "OrderService";
            OrderBody = new OrderBody();
        }

        public override string ToXml()
        {
            return base.ToXml(typeof(OrderRequest), this);
        }
    }

    public class OrderBody
    {
        [XmlElement("Order")]
        public Order Order { get; set; }

        public OrderBody() {
            Order = new Order();
        }
    }

    public class Order
    {
        ///客户订单号  
        ///原字段:orderid  
        ///
        [XmlAttribute("orderid")]
        public string Orderid { get; set; }

        ///顺丰运单号，一个订单只能有一个母单号，如果是子母单的情况，以半角逗号分隔，主单号在第一个位置，如“755123456789,001123456789,002123456789”，对于路由推送注册，此字段为必填。  
        ///原字段:mailno  
        [XmlAttribute("mailno")]
        public string Mailno { get; set; }

        ///是否要求返回顺丰运单号：							1：要求				其它为不要求  
        ///原字段:is_gen_bill_no 
        [XmlAttribute("is_gen_bill_no")]
        public int IsGenBillNo { get; set; }

        ///寄件方公司名称，如果需要生成电子运单，则为必填。  
        ///原字段:j_company 
        [XmlAttribute("j_company")]
        public string JCompany { get; set; }

        ///寄件方联系人，如果需要生成电子运单，则为必填。  
        ///原字段:j_contact  
        [XmlAttribute("j_contact")]
        public string JContact { get; set; }

        ///寄件方联系电话，如果需要生成电子运单，则为必填。  
        ///原字段:j_tel  
        [XmlAttribute("j_tel")]
        public string JTel { get; set; }

        ///寄件方手机  
        ///原字段:j_mobile  
        [XmlAttribute("j_mobile")]
        public string JMobile { get; set; }

        ///寄件方国家/城市代码，如果是跨境件，则此字段为必填。  
        ///原字段:j_shippercode  
        [XmlAttribute("j_shippercode")]
        public string JShippercode { get; set; }

        ///寄方国家  
        ///原字段:j_country  
        [XmlAttribute("j_country")]
        public string JCountry { get; set; }

        ///寄件方所在省份			字段填写要求：必须是标准的省名称称谓 如：广东省，如果是直辖市，请直接传北京、上海等。  
        ///原字段:j_province  
        [XmlAttribute("j_province")]
        public string JProvince { get; set; }

        ///寄件方所在城市名称，字段填写要求：必须是标准的城市称谓 如：深圳市。  
        ///原字段:j_city  
        [XmlAttribute("j_city")]
        public string JCity { get; set; }

        ///寄件人所在县/区，必须是标准的县/区称谓，示例：“福田区”。  
        ///原字段:j_county  
        [XmlAttribute("j_county")]
        public string JCounty { get; set; }

        ///寄件方详细地址，包括省市区，示例：“广东省深圳市福田区新洲十一街万基商务大厦10楼” ，如果需要生成电子运单，则为必填。  
        ///原字段:j_address  
        [XmlAttribute("j_address")]
        public string JAddress { get; set; }

        ///寄方邮编，跨境件必填（中国大陆，港澳台互寄除外）。  
        ///原字段:j_post_code  
        [XmlAttribute("j_post_code")]
        public string JPostCode { get; set; }

        ///到件方公司名称  
        ///原字段:d_company  
        [XmlAttribute("d_company")]
        public string DCompany { get; set; }

        ///到件方联系人  
        ///原字段:d_contact  
        [XmlAttribute("d_contact")]
        public string DContact { get; set; }

        ///到件方联系电话  
        ///原字段:d_tel  
        [XmlAttribute("d_tel")]
        public string DTel { get; set; }

        ///到件方手机  
        ///原字段:d_mobile  
        [XmlAttribute("d_mobile")]
        public string DMobile { get; set; }

        ///到件方代码，如果是跨境件，则要传这个字段，用于表示到方国家的城市。如果此国家整体是以代理商来提供服务的，则此字段可能需要传国家编码。具体商务沟通中双方约定。  
        ///原字段:d_deliverycode  
        [XmlAttribute("d_deliverycode")]
        public string DDeliverycode { get; set; }

        ///到方国家  
        ///原字段:d_country  
        [XmlAttribute("d_country")]
        public string DCountry { get; set; }

        ///到件方所在省份，必须是标准的省名称称谓 如：广东省，如果是直辖市，请直接传北京、上海等。如果此字段与d_city字段都有值，系统则直接使用这两个值而不是通过对d_address进行地址识别获取。为避免地址识别不成功的风险，建议传输此字段。  
        ///原字段:d_province  
        [XmlAttribute("d_province")]
        public string DProvince { get; set; }

        ///到件方所在城市名称，必须是标准的城市称谓 如：深圳市，如果是直辖市，请直接传北京（或北京市）、上海（或上海市）等。如果此字段与d_province字段都有值，顺丰系统则直接使用这两个值而不是对d_address进行地址识别获取。为避免地址识别不成功的风险，建议传输此字段。  
        ///原字段:d_city  
        [XmlAttribute("d_city")]
        public string DCity { get; set; }

        ///到件方所在县/区，必须是标准的县/区称谓，示例：“福田区”。  
        ///原字段:d_county  
        [XmlAttribute("d_county")]
        public string DCounty { get; set; }

        ///到件方详细地址，如果不传输d_province/d_city字段，此详细地址需包含省市信息，以提高地址识别的成功率，示例：“广东省深圳市福田区新洲十一街万基商务大厦10楼”。  
        ///原字段:d_address  
        [XmlAttribute("d_address")]
        public string DAddress { get; set; }

        ///到方邮编，跨境件必填（中国大陆，港澳台互寄除外）。  
        ///原字段:d_post_code  
        [XmlAttribute("d_post_code")]
        public string DPostCode { get; set; }

        ///顺丰月结卡号  
        ///原字段:custid  
        [XmlAttribute("custid")]
        public string Custid { get; set; }

        ///付款方式：1:寄方付 2:收方付 3:第三方付  
        ///原字段:pay_method  
        [XmlAttribute("pay_method")]
        public int PayMethod { get; set; }

        ///快件产品编码，详见附录《快件产品类别表》，只有在商务上与顺丰约定的类别方可使用。  
        ///原字段:express_type  
        [XmlAttribute("express_type")]
        public string ExpressType { get; set; }

        ///包裹数，一个包裹对应一个运单号，如果是大于1个包裹，则返回则按照子母件的方式返回母运单号和子运单号。  
        ///原字段:parcel_quantity  
        [XmlAttribute("parcel_quantity")]
        public int ParcelQuantity { get; set; }

        ///客户订单货物总长，单位厘米，精确到小数点后3位，包含子母件。  
        ///原字段:cargo_length  
        [XmlAttribute("cargo_length")]
        public int CargoLength { get; set; }

        ///客户订单货物总宽，单位厘米，精确到小数点后3位，包含子母件。  
        ///原字段:cargo_width  
        [XmlAttribute("cargo_width")]
        public int CargoWidth { get; set; }

        ///客户订单货物总高，单位厘米，精确到小数点后3位，包含子母件。  
        ///原字段:cargo_height  
        [XmlAttribute("cargo_height")]
        public int CargoHeight { get; set; }

        ///订单货物总体积，单位立方厘米，精确到小数点后3位，会用于计抛（是否计抛具体商务沟通中双方约定）。  
        ///原字段:volume  
        [XmlAttribute("volume")]
        public int Volume { get; set; }

        ///订单货物总重量，包含子母件，单位千克，精确到小数点后3位，如果提供此值，必须>0 。  
        ///原字段:cargo_total_weight  
        [XmlAttribute("cargo_total_weight")]
        public int CargoTotalWeight { get; set; }

        ///客户订单货物总声明价值，包含子母件，精确到小数点后3位。如果是跨境件，则必填。  
        ///原字段:declared_value  
        [XmlAttribute("declared_value")]
        public int DeclaredValue { get; set; }

        ///货物声明价值币别，支持以下值：CNY: 人民币 HKD: 港币 USD: 美元 NTD: 新台币 RUB: 卢布 EUR: 欧元 MOP: 澳门元 SGD: 新元 JPY: 日元 KRW: 韩元 MYR: 马币 VND: 越南盾				THB: 泰铢				AUD: 澳大利亚元				MNT: 图格里克						跨境件报关需要填写  
        ///原字段:declared_value_currency  
        [XmlAttribute("declared_value_currency")]
        public string DeclaredValueCurrency { get; set; }

        ///报关批次  
        ///原字段:customs_batchs  
        [XmlAttribute("customs_batchs")]
        public string CustomsBatchs { get; set; }

        ///要求上门取件开始时间，格式：YYYY-MM-DD HH24:MM:SS，示例：2012-7-30 09:30:00。  
        ///原字段:sendstarttime  
        [XmlAttribute("sendstarttime")]
        public string Sendstarttime { get; set; }

        ///是否要求通过手持终端通知顺丰收派员收件：							1：要求				其它为不要求  
        ///原字段:is_docall  
        [XmlAttribute("is_docall")]
        public int IsDocall { get; set; }

        ///是否要求签回单号：							1：要求（丰密签回单必传routelabelForReturn、routelabelService）				其它为不要求  
        ///原字段:need_return_tracking_no  
        [XmlAttribute("need_return_tracking_no")]
        public string NeedReturnTrackingNo { get; set; }

        ///顺丰签回单服务运单号  
        ///原字段:return_tracking  
        [XmlAttribute("return_tracking")]
        public string ReturnTracking { get; set; }

        ///收件人税号  
        ///原字段:d_tax_no  
        [XmlAttribute("d_tax_no")]
        public string DTaxNo { get; set; }

        ///税金付款方式：							1：寄付				2：到付  
        ///原字段:tax_pay_type  
        [XmlAttribute("tax_pay_type")]
        public string TaxPayType { get; set; }

        ///税金结算账号  
        ///原字段:tax_set_accounts  
        [XmlAttribute("tax_set_accounts")]
        public string TaxSetAccounts { get; set; }

        ///电商原始订单号  
        ///原字段:original_number  
        [XmlAttribute("original_number")]
        public string OriginalNumber { get; set; }

        ///支付工具  
        ///原字段:payment_tool  
        [XmlAttribute("payment_tool")]
        public string PaymentTool { get; set; }

        ///支付号码  
        ///原字段:payment_number  
        [XmlAttribute("payment_number")]
        public string PaymentNumber { get; set; }

        ///商品编号  
        ///原字段:goods_code  
        [XmlAttribute("goods_code")]
        public string GoodsCode { get; set; }

        ///头程运单号  
        ///原字段:in_process_waybill_no  
        [XmlAttribute("in_process_waybill_no")]
        public string InProcessWaybillNo { get; set; }

        ///货物品牌  
        ///原字段:brand  
        [XmlAttribute("brand")]
        public string Brand { get; set; }

        ///货物规格型号  
        ///原字段:specifications  
        [XmlAttribute("specifications")]
        public string Specifications { get; set; }

        ///温度范围类型，当express_type为12医药温控件时必填：							1为冷藏				3为冷冻  
        ///原字段:temp_range  
        [XmlAttribute("temp_range")]
        public int TempRange { get; set; }

        ///客户订单下单人姓名  
        ///原字段:order_name  
        [XmlAttribute("order_name")]
        public string OrderName { get; set; }

        ///客户订单下单人证件类型  
        ///原字段:order_cert_type  
        [XmlAttribute("order_cert_type")]
        public string OrderCertType { get; set; }

        ///客户订单下单人证件号  
        ///原字段:order_cert_no  
        [XmlAttribute("order_cert_no")]
        public string OrderCertNo { get; set; }

        ///客户订单来源（对于平台类客户，如果需要在订单中区分订单来源，则可使用此字段）  
        ///原字段:order_source  
        [XmlAttribute("order_source")]
        public string OrderSource { get; set; }

        ///业务模板编码，业务模板指顺丰系统针对客户业务需求配置的一套接口处理逻辑，一个接入编码可对应多个业务模板。  
        ///原字段:template 
        [XmlAttribute("template")]
        public string Template { get; set; }

        ///备注  
        ///原字段:remark  
        [XmlAttribute("remark")]
        public string Remark { get; set; }

        ///快件自取；1表示客户同意快件自取；非1表示客户不同意快件自取  
        ///原字段:oneself_pickup_flg  
        [XmlAttribute("oneself_pickup_flg")]
        public int OneselfPickupFlg { get; set; }

        ///订单数据分发的系统编码  
        ///原字段:dispatch_sys  
        [XmlAttribute("dispatch_sys")]
        public string DispatchSys { get; set; }

        ///筛单特殊字段(此字段数据库中查询不到)  
        ///原字段:filter_field  
        [XmlAttribute("filter_field")]
        public string FilterField { get; set; }

        ///商品总净重  
        ///原字段:total_net_weight  
        [XmlAttribute("total_net_weight")]
        public int TotalNetWeight { get; set; }

        ///签回单路由标签返回：默认0，1：查询，其他：不查询  
        ///原字段:routelabelForReturn  
        [XmlAttribute("routelabelForReturn")]
        public int RoutelabelForReturn { get; set; }

        ///路由标签查询服务默认0不查询1查询其他不查询  
        ///原字段:routelabelService  
        [XmlAttribute("routelabelService")]
        public int RoutelabelService { get; set; }

        [XmlElement("Cargo")]
        public CarGoBody CarGo { get; set; }

        [XmlElement("AddedService")]
        public List<AddedService> AddedServiceList { get; set; }


        public Order() {
            CarGo = new CarGoBody();
            AddedServiceList = new List<AddedService>();

        }

    }

    public class AddedService
    {
        ///增值服务名，如COD等。  
        ///原字段:name  
        [XmlAttribute("name")]
        public string Name { get; set; }

        ///增值服务扩展属性，参考增值服务传值说明。  
        ///原字段:value  
        [XmlAttribute("value")]
        public string Value { get; set; }

        ///增值服务扩展属性  
        ///原字段:value1  
        [XmlAttribute("value1")]
        public string Value1 { get; set; }

        ///增值服务扩展属性2  
        ///原字段:value2  
        [XmlAttribute("value2")]
        public string Value2 { get; set; }

        ///增值服务扩展属性3  
        ///原字段:value3  
        [XmlAttribute("value3")]
        public string Value3 { get; set; }

        ///增值服务扩展属性4  
        ///原字段:Value4  
        [XmlAttribute("Value4")]
        public string Value4 { get; set; }


    }
    public class CarGoBody
    {
        ///货物名称，如果需要生成电子运单，则为必填。  
        ///原字段:name  
        [XmlAttribute("name")]
        public string Name { get; set; }

        ///货物数量			跨境件报关需要填写  
        ///原字段:count  
        [XmlAttribute("count")]
        public int Count { get; set; }

        ///货物单位，如：个、台、本，跨境件报关需要填写。  
        ///原字段:unit  
        [XmlAttribute("unit")]
        public string Unit { get; set; }

        ///订单货物单位重量，包含子母件，单位千克，精确到小数点后3位跨境件报关需要填写。  
        ///原字段:weight  
        [XmlAttribute("weight")]
        public int Weight { get; set; }

        ///货物单价，精确到小数点后3位，跨境件报关需要填写。  
        ///原字段:amount  
        [XmlAttribute("amount")]
        public int Amount { get; set; }

        ///货物单价的币别：							CNY: 人民币				HKD: 港币				USD: 美元				NTD: 新台币				RUB: 卢布				EUR: 欧元				MOP: 澳门元				SGD: 新元				JPY: 日元				KRW: 韩元				MYR: 马币				VND: 越南盾				THB: 泰铢				AUD: 澳大利亚元				MNT: 图格里克						跨境件报关需要填写。  
        ///原字段:currency  
        [XmlAttribute("currency")]
        public string Currency { get; set; }

        ///原产地国别，跨境件报关需要填写。  
        ///原字段:source_area  
        [XmlAttribute("source_area")]
        public string SourceArea { get; set; }

        ///货物产品国检备案编号  
        ///原字段:product_record_no  
        [XmlAttribute("product_record_no")]
        public string ProductRecordNo { get; set; }

        ///商品海关备案号  
        ///原字段:good_prepard_no  
        [XmlAttribute("good_prepard_no")]
        public string GoodPrepardNo { get; set; }

        ///商品行邮税号  
        ///原字段:tax_no  
        [XmlAttribute("tax_no")]
        public string TaxNo { get; set; }

        ///海关编码  
        ///原字段:hs_code  
        [XmlAttribute("hs_code")]
        public string HsCode { get; set; }


    }

}
