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
            //AuthorData a = new AuthorData();
            //a.ID = 1;
            //a.name = "test update222222";
            //bool rs = proxy.AddAuthor(a);
            BookData b = new BookData();
            b.ISBN = "Test Book";
            b.Name = "Book";
            b.Price = 2;
            b.Publisher_ID = 1;
            b.Quantity = 3;
            b.Status = "C#";
            bool rs = proxy.IAddBook(b);
            Console.WriteLine(rs);
            Console.ReadLine();
        }
    }
}
