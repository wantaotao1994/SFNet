using SFNet.Reponse;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace SFNet.Request
{

    [XmlRoot("Request")]
    public class RouteRequest: ASFRequest<RouteReponse>
    {
        [XmlElement("Body")]
        public RequestBody RequestBody { get; set; }

        public override string Url => "http://bsp-oisp.sf-express.com/bsp-oisp/sfexpressService";


        public override string ToXml()
        {
            return base.ToXml(typeof(RouteRequest),this);
        }

        public RouteRequest() {
            this.ServiceName = "RouteService";
            RequestBody = new RequestBody();
        }
    }


    public class RequestBody{

        [XmlElement("RouteRequest")]
        public RouteRequestBody RouteRequestBody { get; set; }

        public RequestBody() {

            RouteRequestBody = new RouteRequestBody();
        }
    }

    public class RouteRequestBody {

        [XmlAttribute("tracking_type")]
        public int TrackingType { get; set; }

        [XmlAttribute("tracking_number")]
        public string TrackingNumber { get; set; }

        [XmlAttribute("method_type")]
        public int MethodType { get; set; }

        [XmlAttribute("reference_number")]
        public string ReferenceNumber { get; set; }

        [XmlAttribute("check_phoneNo")]
        public string CheckPhoneNo { get; set; }
    }
}
