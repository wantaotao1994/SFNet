using SFNet.Request;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace SFNet
{
   public abstract class ASFRequest<ASFResponse> :ISFRequest
    {
        
        public string Head { get; set; } = "";

        public abstract string ToXml();


        [XmlAttribute("lang")]
        public virtual string Lang { get; set; } = "zh-CN";


        [XmlAttribute("service")]
        public string ServiceName { get;  set; }

        public abstract string Url { get; }
        protected virtual string ToXml(Type tyle, ASFRequest<ASFResponse> request) {

            MemoryStream Stream = new MemoryStream();
            XmlSerializer xml = new XmlSerializer(tyle);
            try
            {
                //序列化对象
                xml.Serialize(Stream, this);
            }
            catch (InvalidOperationException)
            {
                throw;
            }
            Stream.Position = 0;
            StreamReader sr = new StreamReader(Stream);
            string str = sr.ReadToEnd();

            sr.Dispose();
            Stream.Dispose();
            return str;

        }
    }
}
