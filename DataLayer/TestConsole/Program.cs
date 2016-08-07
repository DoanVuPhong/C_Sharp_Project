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
            /*
            AuthorData a = new AuthorData();
            a.ID = 1;
            a.name = "test update222222";
            bool rs = proxy.AddAuthor(a);
            Console.WriteLine(rs);
            Console.ReadLine();
            */

            Console.WriteLine(proxy.UpdateOrder(new OrderData() {
                ID = 3,
                customer_name = "Nghia ABCss",
                date = new DateTime(2016,02,02),
                status="complete"
            }));
        }
    }
}
