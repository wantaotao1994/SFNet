using System;
using System.Collections.Generic;
using System.Text;

namespace SFNet.Service
{
    class WaybillRouteReuest
    {
    }

    public class Class1
    {
        ///路由节点信息编号，每一个id代表一条不同的路由节点信息。  
        ///原字段:id  
        public int Id { get; set; }

        ///顺丰运单号  
        ///原字段:mailno  
        public string Mailno { get; set; }

        ///客户订单号  
        ///原字段:orderid  
        public string Orderid { get; set; }

        ///路由节点产生的时间，格式：YYYY-MM-DD HH24:MM:SS，示例：2012-7-30 09:30:00。  
        ///原字段:acceptTime  
        public DateTime AcceptTime { get; set; }

        ///路由节点发生的城市  
        ///原字段:acceptAddress  
        public string AcceptAddress { get; set; }

        ///路由节点具体描述  
        ///原字段:remark  
        public string Remark { get; set; }

        ///路由节点操作码  
        ///原字段:opCode  
        public string OpCode { get; set; }


    }
}
