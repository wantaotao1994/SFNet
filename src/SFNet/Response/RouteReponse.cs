using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SFNet.Reponse
{

    /// <summary>
    /// 查询路由的实体
    /// </summary>
    [XmlRoot("Response")]
    public class RouteReponse : ASFResponse
    {
        [XmlElement("Body")]
        public RouteBody Body { get; set; }

    }

    public class RouteBody {

        [XmlElement("RouteResponse")]
        public List<RoutResponseBody> Body { get; set; }
        public RouteBody()
        {
            Body = new List<RoutResponseBody>();
        }
    }

    public class RoutResponseBody {

        [XmlAttribute("mailno")]
        public string MailNo { get; set; }

        [XmlAttribute("orderid")]
        public string OrderId { get; set; }

        [XmlElement("Route")]
        public List<Route> Route { get; set; }

        public RoutResponseBody()
        {
            Route = new List<Route>();

        }
    }


    public class Route
    {
        [XmlAttribute("accept_time")]
        public string AcceptTime { get; set; }

        [XmlAttribute("accept_address")]
        public string AcceptAddress { get; set; }

        [XmlAttribute("remark")]
        public string Remark { get; set; }

        [XmlAttribute("opcode")]
        public string Opcode { get; set; }

    }
}
