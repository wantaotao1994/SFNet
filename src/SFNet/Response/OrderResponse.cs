using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SFNet.Response
{

    public class OrderResponse : ASFResponse
    {
        [XmlElement("Body")]
        public OrderBody Body { get; set; }


        public OrderResponse() {
            Body = new OrderBody();
        }
    }


    public class OrderBody
    {
        [XmlElement("OrderResponse")]
        public OrderResponseBody OrderResponse { get; set; }
        public OrderBody() {
            OrderResponse = new OrderResponseBody();
        }
        
    }

    public class OrderResponseBody
    {
        ///客户订单号  
        ///原字段:orderid  
        [XmlAttribute("orderid")]
        public string Orderid { get; set; }

        ///顺丰运单号，一个订单只能有一个母单号，如果是子母单的情况，以半角逗号分隔，主单号在第一个位置，如“755123456789,001123456789,002123456789” ，可用于顺丰电子运单标签打印。  
        ///原字段:mailno  
        [XmlAttribute("mailno")]
        public string Mailno { get; set; }

        ///顺丰签回单服务运单号  
        ///原字段:return_tracking_no  
        [XmlAttribute("return_tracking_no")]
        public string ReturnTrackingNo { get; set; }

        ///原寄地区域代码，可用于顺丰电子运单标签打印。  
        ///原字段:origincode  
        [XmlAttribute("origincode")]
        public string Origincode { get; set; }

        ///目的地区域代码，可用于顺丰电子运单标签打印。  
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

        ///代理单号  
        ///原字段:agentMailno  
        [XmlAttribute("agentMailno")]
        public string AgentMailno { get; set; }

        ///地址映射码  
        ///原字段:mapping_mark  
        [XmlAttribute("mapping_mark")]
        public string MappingMark { get; set; }

    }

    public class RlsInfo
    {
        ///返回调用结果，ERR：调用失败；OK调用成功  
        ///原字段:invoke_result  
        [XmlAttribute("invoke_result")]
        public string InvokeResult { get; set; }

        ///0000（接口参数异常）			0010（其它异常） 			0001（xml解析异常） 			0002（字段校验异常） 			0003（票数节点超出最大值，批量请求最大票数为100票）			0004（RLS获取路由标签的必要字段为空）			1000 成功  
        ///原字段:rls_code  
        [XmlAttribute("rls_code")]
        public string RlsCode { get; set; }

        ///错误信息  
        ///原字段:errorDesc  
        [XmlAttribute("errorDesc")]
        public string ErrorDesc { get; set; }


    }

    public class RlsDetail
    {
        ///返回调用结果，ERR：调用失败；OK调用成功  
        ///原字段:waybillNo  
        [XmlAttribute("waybillNo")]
        public string WaybillNo { get; set; }

        ///原寄地中转场  
        ///原字段:sourceTransferCode  
        [XmlAttribute("sourceTransferCode")]
        public string SourceTransferCode { get; set; }

        ///原寄地城市代码  
        ///原字段:sourceCityCode  
        [XmlAttribute("sourceCityCode")]
        public string SourceCityCode { get; set; }

        ///原寄地网点代码  
        ///原字段:sourceDeptCode  
        [XmlAttribute("sourceDeptCode")]
        public string SourceDeptCode { get; set; }

        ///原寄地单元区域  
        ///原字段:sourceTeamCode  
        [XmlAttribute("sourceTeamCode")]
        public string SourceTeamCode { get; set; }

        ///目的地城市代码,eg:755  
        ///原字段:destCityCode  
        [XmlAttribute("destCityCode")]
        public string DestCityCode { get; set; }

        ///目的地网点代码,eg:755AQ  
        ///原字段:destDeptCode  
        [XmlAttribute("destDeptCode")]
        public string DestDeptCode { get; set; }

        ///目的地网点代码映射码  
        ///原字段:destDeptCodeMapping  
        [XmlAttribute("destDeptCodeMapping")]
        public string DestDeptCodeMapping { get; set; }

        ///目的地单元区域,eg:001  
        ///原字段:destTeamCode  
        [XmlAttribute("destTeamCode")]
        public string DestTeamCode { get; set; }

        ///目的地单元区域映射码  
        ///原字段:destTeamCodeMapping  
        [XmlAttribute("destTeamCodeMapping")]
        public string DestTeamCodeMapping { get; set; }

        ///目的地中转场  
        ///原字段:destTransferCode  
        [XmlAttribute("destTransferCode")]
        public string DestTransferCode { get; set; }

        ///打单时的路由标签信息			如果是大网的路由标签，这里的值是目的地网点代码，如果是同城配的路由标签，这里的值是根据同城配的设置映射出来的值，不同的配置结果会不一样，不能根据-符号切分（如：上海同城配，可能是：集散点-目的地网点-接驳点，也有可能是目的地网点代码-集散点-接驳点）  
        ///原字段:destRouteLabel  
        [XmlAttribute("destRouteLabel")]
        public string DestRouteLabel { get; set; }

        ///产品名称			对应RLS:pro_name  
        ///原字段:proName  
        [XmlAttribute("proName")]
        public string ProName { get; set; }

        ///快件内容：			如：C816、SP601  
        ///原字段:cargoTypeCode  
        [XmlAttribute("cargoTypeCode")]
        public string CargoTypeCode { get; set; }

        ///时效代码, 如：T4  
        ///原字段:limitTypeCode  
        [XmlAttribute("limitTypeCode")]
        public string LimitTypeCode { get; set; }

        ///产品类型,如：B1  
        ///原字段:expressTypeCode  
        [XmlAttribute("expressTypeCode")]
        public string ExpressTypeCode { get; set; }

        ///入港映射码			eg:S10  
        ///原字段:codingMapping  
        [XmlAttribute("codingMapping")]
        public string CodingMapping { get; set; }

        ///出港映射码  
        ///原字段:codingMappingOut  
        [XmlAttribute("codingMappingOut")]
        public string CodingMappingOut { get; set; }

        ///XB标志			0:不需要打印XB			1:需要打印XB  
        ///原字段:xbFlag  
        [XmlAttribute("xbFlag")]
        public string XbFlag { get; set; }

        ///打印标志			返回值总共有9位，每一位只有0和1两种，0表示按丰密运单默认的规则，1表示显示，顺序如下，如111110000表示打印寄方姓名、寄方电话、寄方公司名、寄方地址和重量，收方姓名、收方电话、收方公司名和收方地址按丰密运单默认规则			1：寄方姓名			2：寄方电话			3：寄方公司名			4：寄方地址			5：重量			6：收方姓名			7：收方电话			8：收方公司名			9：收方地址  
        ///原字段:printFlag  
        [XmlAttribute("printFlag")]
        public string PrintFlag { get; set; }

        ///二维码			根据规则生成字符串信息,格式为			MMM={'k1':'（目的地中转场代码）','k2':'（目的地原始网点代码）','k3':'（目的地单元区域）','k4':'（附件通过三维码（express_type_code、 limit_type_code、 cargo_type_code）映射时效类型）','k5':'（运单号）'，'k6':'（AB标识）'}  
        ///原字段:twoDimensionCode  
        [XmlAttribute("twoDimensionCode")]
        public string TwoDimensionCode { get; set; }

        ///时效类型:			值为二维码中的K4  
        ///原字段:proCode  
        [XmlAttribute("proCode")]
        public string ProCode { get; set; }

        ///打印图标			根据托寄物判断需要打印的图标(重货,蟹类,生鲜,易碎,Z标)			返回值有8位，每一位只有0和1两种，0表示按运单默认的规则，1表示显示。后面两位默认0备用。			顺序如下：重货,蟹类,生鲜,易碎,医药类,Z标,0,0			如：00000000表示不需要打印重货,蟹类,生鲜,易碎,医药,Z标,备用,备用  
        ///原字段:printIcon  
        [XmlAttribute("printIcon")]
        public string PrintIcon { get; set; }

        ///AB标  
        ///原字段:abFlag  
        [XmlAttribute("abFlag")]
        public string AbFlag { get; set; }

        ///查询出现异常时返回信息。			返回代码：			0 系统异常			1 未找到运单  
        ///原字段:errMsg  
        [XmlAttribute("errMsg")]
        public string ErrMsg { get; set; }

        ///目的地口岸代码  
        ///原字段:destPortCode  
        [XmlAttribute("destPortCode")]
        public string DestPortCode { get; set; }

        ///目的国别(国别代码如：JP)  
        ///原字段:destCountry  
        [XmlAttribute("destCountry")]
        public string DestCountry { get; set; }

        ///目的地邮编  
        ///原字段:destPostCode  
        [XmlAttribute("destPostCode")]
        public string DestPostCode { get; set; }

        ///总价值(保留两位小数，数字类型，可补位)  
        ///原字段:goodsValueTotal  
        [XmlAttribute("goodsValueTotal")]
        public string GoodsValueTotal { get; set; }

        ///币种  
        ///原字段:currencySymbol  
        [XmlAttribute("currencySymbol")]
        public string CurrencySymbol { get; set; }

        ///件数  
        ///原字段:goodsNumber  
        [XmlAttribute("goodsNumber")]
        public string GoodsNumber { get; set; }


    }



}
