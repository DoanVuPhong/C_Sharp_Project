using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Services
{
    class OrderDetailService
    {
        public static bool Add(Order_Detail o)
        {
            try
            {
                using (Book_Sale_ManagerEntities context = new Book_Sale_ManagerEntities())
                {
                    context.Order_Detail.Add(o);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Can't add order detail to database. Detail: {0}", ex);
            }
            return false;
        }
        public static bool Update(Order_Detail o)
        {
            using (Book_Sale_ManagerEntities context = new Book_Sale_ManagerEntities())
            {
                try
                {
                    Order_Detail update = context.Order_Detail.SingleOrDefault(x => x.ID == o.ID);
                    if (update != null)
                    {

                        if (o.Order != null) update.Order = o.Order;
                        if (o.order_ID != null) update.order_ID = o.order_ID;
                        if (o.quantity != null) update.quantity = o.quantity;
                        if (o.book_ID != null) update.book_ID = o.book_ID;
                        context.SaveChanges();
                        return true;
                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("Can't update order. Detail: {0}", ex);
                }
            }
            return false;
        }
    }
}
