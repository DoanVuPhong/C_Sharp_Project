using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Services
{
    class AuthorService
    {

        public static bool Add(Author a)
        {

            try
            {
                using (Book_Sale_ManagerEntities context = new Book_Sale_ManagerEntities())
                {
                    context.Authors.Add(a);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
                return false;
            }
        }




        public static bool Remove(Author a)
        {

            try
            {
                using (Book_Sale_ManagerEntities context = new Book_Sale_ManagerEntities())
                {

                    Author author = context.Authors.FirstOrDefault(t => t.ID == a.ID);
                    if (author != null)
                    {
                        context.Authors.Remove(author);
                        context.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                throw;
                return false;
            }
        }


        public static bool Update(Author a) {

            try
            {
                using (Book_Sale_ManagerEntities context = new Book_Sale_ManagerEntities())
                {

                    Author author = context.Authors.FirstOrDefault(t => t.ID == a.ID);
                    if (author != null)
                    {
                        author.name = a.name;
                        context.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                throw;
                return false;
            }
        }









    }
}
