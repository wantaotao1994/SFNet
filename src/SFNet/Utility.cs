using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace SFNet
{
  public static class Utility
    {

        public static string GetVerifyCode(string xml, string code) {
            string param = $"{xml}{code}";

             return Convert.ToBase64String(GetMd5_16byte(param));
        }

        public static byte[] GetMd5_16byte(string ConvertString)
        {
            string md5Pwd = string.Empty;

            //使用加密服务提供程序
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            //将指定的字节子数组的每个元素的数值转换为它的等效十六进制字符串表示形式。
           return  md5.ComputeHash(UTF8Encoding.Default.GetBytes(ConvertString));
        }


        public static string ToNormalTime(this DateTime dateTime)
        {

            return dateTime.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
