using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SFNet
{
  public  interface ISFClient
    {

        Task<T> ExcuteAsync<T>(ASFRequest<T> request) where T : ASFResponse;


        T Excute<T>(ASFRequest<T> request) where T : ASFResponse;


    }
}
