using Interface_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ChannelFactory<IBussinessLogic> chanel = new ChannelFactory<IBussinessLogic>("ClientEndPoint");
            IBussinessLogic proxy = chanel.CreateChannel();
          
            DataTable list = proxy.SearchByDate(new DateTime(2016,07,07));
            foreach (DataRow row in list.Rows) // Loop over the rows.
            {
                Console.WriteLine("--- Row ---"); // Print separator.
                Console.WriteLine(row["ID"].ToString());
                Console.WriteLine(row["date"].ToString());
            }
            Console.WriteLine("End loop");
            Console.ReadLine();

        }
    }
}
