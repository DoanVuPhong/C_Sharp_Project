using Interface_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ChannelFactory<IBussinessLogic> chanel = new ChannelFactory<IBussinessLogic>("ClientEndPoint");
            IBussinessLogic proxy = chanel.CreateChannel();
            AccountData a = new AccountData();
            a.ID = 1;
            a.username = "test update222222";
            a.password = "123";
            bool rs = proxy.AddAccount(a);
            Console.WriteLine(rs);
            Console.ReadLine();
        }
    }
}
