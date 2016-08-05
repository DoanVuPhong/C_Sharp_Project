using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace TestDrive
{
    class Program
    {
        static void Main(string[] args)
        {
            Account c = new Account();
            c.username = "Tu nv";
            c.password = "cu teo";
           bool result=  DataLayer.Services.AccountServices.Add(c);

            Console.WriteLine(result);


        }
    }
}
