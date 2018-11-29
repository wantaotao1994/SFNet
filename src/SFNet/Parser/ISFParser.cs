using System;
using System.Collections.Generic;
using System.Text;

namespace SFNet.Parser
{
   public interface ISFParser<T> where  T   : ASFResponse
    {
        T Parse(string content);
    }
}
