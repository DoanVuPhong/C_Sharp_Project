using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Server.Services
{
    class OrderService
    {

        public static bool Add(Order o)
        {
            try
            {
                using (Book_Sale_ManagerEntities context = new Book_Sale_ManagerEntities())
                {
                    context.Orders.Add(o);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Can't add order to database. Detail: {0}", ex);
            }
            return false;
        }
        public static bool Update(Order o)
        {
            using (Book_Sale_ManagerEntities context = new Book_Sale_ManagerEntities())
            {
                try
                {
                    Order update = context.Orders.SingleOrDefault(x => x.ID == o.ID);
                    if (update != null)
                    {

                        if (o.Account != null) update.Account = o.Account;
                        if (o.account_ID != null) update.account_ID = o.account_ID;
                        if (o.customer_name != null) update.customer_name = o.customer_name;
                        if (o.date != null) update.date = o.date;
                        if (o.Order_Detail != null) update.Order_Detail = o.Order_Detail;
                        if (o.status != null) update.status = o.status;

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

        public static DataTable SearchByDate(DateTime date)
        {



            DataTable listOrder = new DataTable("OrderByDate");

            SqlConnection conn = new SqlConnection("server=PHONGDVSE61654//SQL2012;database=Book_Sale_Manager;uid=sa;pwd=123");

            SqlCommand cmd = new SqlCommand("select * from [Order] where [date] = @datetime", conn);
            cmd.Parameters.AddWithValue("@datetime", date.ToString());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                da.Fill(listOrder);
                return listOrder;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                if (conn!=null){
                    conn.Close();
                }
            }
            return null;
        }


    }
}
