using System;
using System.Collections.Generic;
using System.Text;

namespace SFNet.Request
{
    class OrderZDRequest
    {
    }

    public class Class1dd
    {
        ///客户订单号  
        ///原字段:orderid  
        public string Orderid { get; set; }

        ///新增加的包裹数，最大20  
        ///原字段:parcel_quantity  
        public int ParcelQuantity { get; set; }
    }
}
