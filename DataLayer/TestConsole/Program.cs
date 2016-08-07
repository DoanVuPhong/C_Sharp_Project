using Interface_Data;
using System;
using System.Collections.Generic;
using System.Data;
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
            Console.WriteLine(proxy.UpdateOrder(new OrderData()
            {
                ID = 3,
                customer_name = "Nghia ABC",
                date = new DateTime(2016, 02, 02),
                status = "complete"
            }));

        }
    }
}
