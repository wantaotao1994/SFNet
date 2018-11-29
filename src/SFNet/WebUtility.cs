using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;

namespace SFNet
{
  public static  class WebUtility
    {
        private static HttpClient httpClient;

        static WebUtility() {
            httpClient = new HttpClient();
        }

        public static async  System.Threading.Tasks.Task<string> DoPostAsync(string url,string content ,string verifyCode) {
 
            string str = "";
            try
            {
                Encoding myEncoding = Encoding.GetEncoding("UTF-8");  //确定中文编码方式。此处用gb2312
                string param = HttpUtility.UrlEncode("xml", myEncoding) + "=" + HttpUtility.UrlEncode(content, myEncoding) + "&" + HttpUtility.UrlEncode("verifyCode", myEncoding) + "=" + HttpUtility.UrlEncode(verifyCode, myEncoding);
                byte[] postBytes = Encoding.UTF8.GetBytes(param);     //将参数转化为assic码
                HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(url);
                req.Method = "POST";
                req.ContentType = "application/x-www-form-urlencoded;charset=utf-8";
                req.ContentLength = postBytes.Length;
                using (Stream reqStream =await req.GetRequestStreamAsync())
                {
                    reqStream.Write(postBytes, 0, postBytes.Length);
                }
                var response = await req.GetResponseAsync();
                using (Stream wr = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(wr, Encoding.UTF8))
                    {
                        str =(await reader.ReadToEndAsync()).ToString();
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return str;
        }


        public static string DoPost(string url, string content, string verifyCode)
        {

            string str = "";
            try
            {
                Encoding myEncoding = Encoding.GetEncoding("UTF-8");  //确定中文编码方式。此处用gb2312
                string param = HttpUtility.UrlEncode("xml", myEncoding) + "=" + HttpUtility.UrlEncode(content, myEncoding) + "&" + HttpUtility.UrlEncode("verifyCode", myEncoding) + "=" + HttpUtility.UrlEncode(verifyCode, myEncoding);
                byte[] postBytes = Encoding.UTF8.GetBytes(param);     //将参数转化为assic码
                HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(url);
                req.Method = "POST";
                req.ContentType = "application/x-www-form-urlencoded;charset=utf-8";
                req.ContentLength = postBytes.Length;
                using (Stream reqStream =  req.GetRequestStream())
                {
                    reqStream.Write(postBytes, 0, postBytes.Length);
                }
                var response =  req.GetResponse();
                using (Stream wr = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(wr, Encoding.UTF8))
                    {
                        str = reader.ReadToEnd().ToString();
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return str;
        }
    }
}
