using Newtonsoft.Json;
using SFNet.Parser;
using SFNet.Reponse;
using SFNet.Request;
using System;
using System.Xml.Serialization;
using Xunit;

namespace SFNet.Test
{
    public class UnitTest1
    {
        SFNet.SFNetConfig _sFNetConfig = new SFNetConfig() {
            CheckCode = "",//���У����
            UserCode = ""//��Ĺ˿ͱ���


        };
        [Fact]
        public void TestParse()
        {
            DateTime today = DateTime.Now;

            TimeSpan sp = today.Subtract(DateTime.Parse("2017-08-03 12:03:00"));


            XmlSFResponseParser<RouteReponse> xmlSFParser = new XmlSFResponseParser<RouteReponse>();
            var  result =    xmlSFParser.Parse("<Response  service=\"RouteService\"><Head>OK</Head><Body><RouteResponse mailno=\"444003077898\"><Route accept_time=\"2015-01-04 10:11:26\" accept_address=\"����\" remark=\"���ռ�\" opcode=\"50\"/><Route accept_time=\"2015-01-05 17:41:50\" remark=\"�˼�ǩ�������ĵ���Ϊ 123638813180\" opcode=\"922\"/></RouteResponse><RouteResponse mailno=\"444003077899\"><Route accept_time=\"2015-01-04 10:11:26\" accept_address=\"����\" remark=\"���ռ�\" opcode=\"50\"/><Route accept_time=\"2015-01-05 17:41:50\" remark=\"�˼�ǩ�������ĵ���Ϊ 123638813181\" opcode=\"922\"/></RouteResponse></Body></Response>");

            int i = 0;
        }
        [Fact]
        public async System.Threading.Tasks.Task TestRoute()
        {
            RouteRequest routeRequest = new RouteRequest();
            routeRequest.RequestBody = new  RequestBody() {

                RouteRequestBody = new RouteRequestBody()
                {
                    MethodType = 1,
                    TrackingNumber = "444008762187",
                    TrackingType = 1,
                }
            };
            ISFClient sFClient = new DefaultSFClient(_sFNetConfig);
            var response = await sFClient.ExcuteAsync(routeRequest);
            Assert.True(response.Head == "OK");
        }

        [Fact]
        public async System.Threading.Tasks.Task TestOrder()
        {
            OrderRequest routeRequest = new OrderRequest();
            routeRequest.OrderBody = new OrderBody()
            {

                Order = new Order()
                {
                   Orderid ="ywbj-110",
                   ExpressType = "2",
                  JProvince = "�㶫ʡ",
                  JCity = "����",
                  JCompany = "˳���ھ�",
                  JContact = "xxxx",
                  JTel = "xxxxx",
                  JAddress = "����������ʮһ������������26¥",
                 DCity = "������",
                 DCountry = "",
                 DCompany = "���޿Ƽ�",
                 DContact = "��һ�������",
                 DTel = "33992159",
                 DAddress = "��������֥�ִ���701��",
                 ParcelQuantity = 1,
                 PayMethod =3,
                 IsGenBillNo =1,
                 Custid = "",  //����½��˺�
                 CustomsBatchs = "",
                 Sendstarttime ="",
                 CarGo= new CarGoBody() {
                     Name = "LV2",
                     Count = 3,
                     Unit = "a",
                 },
                }
            };
            routeRequest.OrderBody.Order.AddedServiceList.Add(new AddedService() {
                Name= "COD",
                Value= "1.01",
                Value1 = "7551234567"
            });

            ISFClient sFClient = new DefaultSFClient(_sFNetConfig);
            var response = await sFClient.ExcuteAsync(routeRequest);

            Assert.True(response.Head=="OK");

        }

        [Fact]
        public async System.Threading.Tasks.Task TestOrderSearchServiceAsync()
        {
            OrderSearchRequest orderSearchRequest = new OrderSearchRequest() {
                OrderSearchBody = new OrderSearchBody() {
                OrderSearch = new OrderSearch() {
                    Orderid = "ywbj-110",
                    SearchType = "1"
                }
                }
        };
           
            ISFClient sFClient = new DefaultSFClient(_sFNetConfig);
            var response = await sFClient.ExcuteAsync(orderSearchRequest);

            Assert.True(response.Head == "OK");
        }

        [Fact]
        public async System.Threading.Tasks.Task TestConfirmOrderServiceAsync()
        {
            OrderConfirmRequest orderSearchRequest = new OrderConfirmRequest()
            {
                OrderConfirmBody = new OrderConfirmBody()
                {
                    OrderConfirm = new OrderConfirm()
                    {
                        Orderid = "ywbj-110",
                        Dealtype =2
                    }
                }
            };

            ISFClient sFClient = new DefaultSFClient(_sFNetConfig);
            var response = await sFClient.ExcuteAsync(orderSearchRequest);

            Assert.True(response.Head == "OK");
        }

        [Fact]
        public async System.Threading.Tasks.Task TestFilterOrderServiceAsync()
        {
            OrderFilterRequest orderFilterRequest = new OrderFilterRequest()
            {
                 OrderFilterBody = new OrderFilterBody()
                {
                     OrderFilter = new  OrderFilter()
                    {
                     // DAddress= "�½�ά�����������ʲ������ʲ����ľ����Э����·11��", //����
                         DAddress = "�ϼ��޼�����Ȼ������xx��˾", //����

                         FilterType = 1,
                      OrderFilterOption =new OrderFilterOption() {
                            
                      },  //��ѡ
                      

                    }
                }
            };

            ISFClient sFClient = new DefaultSFClient(_sFNetConfig);
            var response = await sFClient.ExcuteAsync(orderFilterRequest);

            Assert.True(response.Head == "OK");
        }

        public class TestObject : ASFResponse
        {
            public string Name { get; set; }

            public string Value { get; set; }
        }
    }
}
