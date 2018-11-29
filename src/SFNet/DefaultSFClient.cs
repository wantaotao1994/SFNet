using SFNet.Parser;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SFNet
{
    public class DefaultSFClient : ISFClient
    {
        private SFNetConfig _sFNetConfig ;
          
        public DefaultSFClient(SFNetConfig sFNetConfig) {
            _sFNetConfig = sFNetConfig;
        }

        public T Excute<T>(ASFRequest<T> request) where T : ASFResponse
        {
            string result = "";
            try
            {
                request.Head = _sFNetConfig.UserCode;
                result =  WebUtility.DoPost(request.Url, request.ToXml(), Utility.GetVerifyCode(request.ToXml(), _sFNetConfig.CheckCode));
            }
            catch (Exception e)
            {
                throw e;
            }
            return new XmlSFResponseParser<T>().Parse(result);
        }

        public async Task<T> ExcuteAsync<T>(ASFRequest<T> request) where  T  :ASFResponse
        {
            string result = "";
            try
            {
                request.Head = _sFNetConfig.UserCode;
                result =  await WebUtility.DoPostAsync(request.Url, request.ToXml(), Utility.GetVerifyCode(request.ToXml(), _sFNetConfig.CheckCode));
            }
            catch (Exception e)
            {
                  throw e;
            }
            return new XmlSFResponseParser<T>().Parse(result);
        }
    }
}
