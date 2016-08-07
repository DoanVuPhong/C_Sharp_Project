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
            CategoryData c = new CategoryData();
          
            c.name = "Maria ozawa";
            Console.WriteLine(proxy.AddCategory(c));

            DataTable table = proxy.GetAllCategory();

            
                Console.WriteLine(table.ToString());
            foreach (DataRow item in table.Rows)
            {
                Console.WriteLine(item["name"].ToString());
            }

            Console.ReadLine();


        }
    }
}
