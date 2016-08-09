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
    class console
    {
        static void Main(string[] args)
        {
            ChannelFactory<IBussinessLogic> chanel = new ChannelFactory<IBussinessLogic>("ClientEndPoint");
            IBussinessLogic proxy = chanel.CreateChannel();
            DataTable t = proxy.GetAllAuthor();
            foreach (DataRow i in t.Rows) {
                Console.WriteLine(i["name"].ToString());
            }
            Console.ReadLine();
            {

            }
              


        }
    }
}
