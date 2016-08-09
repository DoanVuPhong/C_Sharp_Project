using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Services
{
    class PublisherService
    {
        public static bool Add(Publisher p)
        {
            try
            {
                using (Book_Sale_ManagerEntities context = new Book_Sale_ManagerEntities())
                {
                    context.Publishers.Add(p);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Can't add publiser to database. Detail: {0}", ex);
            }
            return false;
        }

        public static bool Update(Publisher p)
        {
            using (Book_Sale_ManagerEntities context = new Book_Sale_ManagerEntities())
            {
                try
                {
                    Publisher update = context.Publishers.SingleOrDefault(x => x.ID == p.ID);
                    if (update != null)
                    {

                        if (p.name != null) update.name = p.name;
                        context.SaveChanges();
                        return true;
                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("Can't publisher order. Detail: {0}", ex);
                }
            }
            return false;
        }

        public static bool Delete(Publisher p)
        {
            using (Book_Sale_ManagerEntities context = new Book_Sale_ManagerEntities())
            {
                try
                {
                    Publisher re = context.Publishers.SingleOrDefault(x => x.ID == p.ID);
                    if (re != null)
                    {

                        context.Publishers.Remove(re);
                        context.SaveChanges();
                        return true;
                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("Can't delete order. Detail: {0}", ex);
                }
            }
            return false;
        }
    }
}
