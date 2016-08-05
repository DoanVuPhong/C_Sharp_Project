using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Services
{
   public class AccountServices
    {

        public static bool Add(Account a) {

            try
            {
                using (Book_Sale_ManagerEntities context = new Book_Sale_ManagerEntities()) {

                    //cái này giống với EntityManager trong java context = Entitymanager
                    //add vào bảng Account nhưng lúc này còn nằm trên bộ nhớ
                    context.Accounts.Add(a);
                    // lúc gọi SaveChanges mới xuống database Thực sự 
                    context.SaveChanges();
                    return true;

                    // test trong console

                }
            }
            catch (Exception)
            {
                throw;
            }
            return false;
        }















    }
}
