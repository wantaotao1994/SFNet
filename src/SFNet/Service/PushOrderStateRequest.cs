using System;
using System.Collections.Generic;
using System.Text;

namespace SFNet.Service
{
    class PushOrderStateRequest
    {
    }

    public class Class1dd
    {
        ///客户订单号  
        ///原字段:orderNo  
        public string OrderNo { get; set; }

        ///顺丰运单号  
        ///原字段:waybillNo  
        public string WaybillNo { get; set; }

        ///订单状态  
        ///原字段:orderStateCode  
        public string OrderStateCode { get; set; }

        ///订单状态描述  
        ///原字段:orderStateDesc  
        public string OrderStateDesc { get; set; }

        ///收件员工工号  
        ///原字段:empCode  
        public string EmpCode { get; set; }

        ///收件员手机号  
        ///原字段:empPhone  
        public string EmpPhone { get; set; }

        ///网点  
        ///原字段:netCode  
        public string NetCode { get; set; }

        ///最晚上门时间  
        ///原字段:lastTime  
        public DateTime LastTime { get; set; }

        ///客户预约时间  
        ///原字段:bookTime  
        public DateTime BookTime { get; set; }

        ///承运商代码(SF)  
        ///原字段:carrierCode  
        public string CarrierCode { get; set; }


    }
}
