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
            /*
            AuthorData a = new AuthorData();
            a.ID = 1;
            a.name = "Nghia";
            bool rs = proxy.AddAuthor(a);
            Console.WriteLine(rs);
            Console.ReadLine();
            
            Console.WriteLine(proxy.UpdateOrder(new OrderData() {
                ID = 3,
                customer_name = "Nghia ABC",
                date = new DateTime(2016,02,02),
                status="complete"
            }));
            */


            /*
            Console.WriteLine(proxy.AddPublisher(new PublisherData() {
                name ="Nghia"
            }));
            Console.WriteLine(proxy.UpdatePublisher(new PublisherData()
            {
                ID = 1,
                name = "NghiaThanh"
            }));
            Console.WriteLine(proxy.DeletePublisher(new PublisherData() {
                ID =1
            }));
            

            Console.WriteLine(proxy.AddOrderDetail(new OrderDetailData() {
                book_ID =9,
                order_ID =3,
                quantity =3
            }));
            Console.WriteLine(proxy.UpdateOrderDetail(new OrderDetailData()
            {
                ID = 3,
                book_ID = 9,
                order_ID = 3,
                quantity = 1000
            }));
            */

            DataTable list = proxy.SearchByDate(new DateTime(2016,07,07));
            foreach (DataRow row in list.Rows) // Loop over the rows.
            {
                Console.WriteLine("--- Row ---"); // Print separator.
                Console.WriteLine(row["ID"].ToString());
                Console.WriteLine(row["date"].ToString());
            }
            Console.ReadLine();

        }
    }
}
