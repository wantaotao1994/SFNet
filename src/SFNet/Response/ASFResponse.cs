using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SFNet
{
    public class ASFResponse:ISFResponse
    {
        public string Head { get; set; }

        [XmlElement("ERROR")]
        public string Error { get; set; }
    }

}
