using System;
using System.Collections.Generic;
using System.Text;

namespace SFNet.Response
{
    class OrderZDResponse
    {
    }

    public class asdfe
    {
        ///客户订单号  
        ///原字段:orderid  
        public string Orderid { get; set; }

        ///顺丰母运单号  
        ///原字段:main_mailno  
        public string MainMailno { get; set; }

        ///新增的子运单号，可多个单号，以逗号分隔。  
        ///原字段:mailno_zd  
        public string MailnoZd { get; set; }


    }
}
