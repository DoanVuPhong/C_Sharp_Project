using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Services
{
    class CategoryService
    {

        public static bool Add(Category c) {


            try
            {

                using (Book_Sale_ManagerEntities context = new Book_Sale_ManagerEntities()) {
                    context.Categories.Add(c);
                    context.SaveChanges();
                    return true;
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
                Console.WriteLine(e.StackTrace);
                return false;
            }



        }



    }
}
