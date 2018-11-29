using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace SFNet.Parser
{
    public class XmlSFResponseParser<T>: ISFParser<T> where T  : ASFResponse
    {
        public T Parse(string content)
        {
            if (string.IsNullOrEmpty(content))
            {
                throw new ArgumentNullException(nameof(content));
            }
            T rsp =default(T);
            try
            {
                var bodyDoc = XDocument.Parse(content);

                using (var sr = new StringReader(content))
                {
                    var rootAttribute = new XmlRootAttribute();
                    rootAttribute.ElementName = "Response";
                    rootAttribute.IsNullable = true;
                    var xmldes = new XmlSerializer(typeof(T), rootAttribute);
                    rsp = (T)xmldes.Deserialize(sr);
                }
                if (rsp.Head!="OK" &&  string.IsNullOrEmpty(rsp.Error))
                {
                    rsp.Error = content;
                }
            }
            catch (Exception) {
            }
         
            return rsp;
        }

        public string ToRequestBody(T t)
        {
            return "";

        }
    }
}
