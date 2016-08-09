using Interface_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Server.Services;
using System.Data;

namespace Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BussinessLogic" in both code and config file together.
    public class BussinessLogic : IBussinessLogic
    {

        public bool AddAccount(AccountData b)
        {
            Account account = new Account();
            account.username = b.username;
            account.password = b.password;
            account.phone = b.phone;
            account.email = b.email;
            account.type = b.type;
            bool result = AccountService.Add(account);
            return result;
        }

        public bool AddAuthor(AuthorData a)
        {
            Author author = new Author();
            author.name = a.name;
            bool result = AuthorService.Add(author);
            return result;
        }

        public bool AddCategory(CategoryData c)
        {
            Category category = new Category();
            category.name = c.name;
            category.status = c.status;
            return CategoryService.Add(category);
        }

        public DataTable GetAllAuthor()
        {
          return  AuthorService.GetAllAuthor();
        }

        public bool RemoveAuthor(AuthorData a)
        {
            Author author = new Author();
            author.ID = a.ID;
            author.name = a.name;
            bool result = AuthorService.Remove(author);
            return result;
        }

        public bool UpdateAuthor(AuthorData a)
        {
            Author author = new Author();
            author.name = a.name;
            author.ID = a.ID;
            bool result=AuthorService.Update(author);
            return result;
        }

        public bool AddOrder(OrderData od)
        {
            Order o = new Order()
            {
                ID = od.ID,
                account_ID = od.account_ID,
                customer_name = od.customer_name,
                status = od.status,
                date = od.date
            };
            bool result = OrderService.Add(o);
            return result;
        }

        public bool UpdateOrder(OrderData od)
        {
            Order o = new Order()
            {
                ID = od.ID,
                account_ID = od.account_ID,
                customer_name = od.customer_name,
                status = od.status,
                date = od.date
            };
            bool result = OrderService.Update(o);
            return result;
        }

        public bool RemoveCategory(CategoryData c)
        {
            Category category = new Category();
            category.name = c.name;
            category.ID = c.ID;
            category.status = c.status;
            return CategoryService.Remove(category);    
        }

        public bool UpdateCategory(CategoryData c)
        {
            Category category = new Category();
            category.ID = c.ID;
            category.name = c.name;
            category.status = c.status;
            return CategoryService.Update(category);
        }

        public DataTable GetAllCategory()
        {
            return CategoryService.getAllCategory();
        }
        public bool checkLogin(string username, string password)
        {
            Account account = new Account();
            account.username = username;
            account.password = password;
            bool result = AccountService.checkLogin(account.username, account.password);
            return result;
        }
        public bool RemoveAccount(AccountData b)
        {
            Account account = new Account();
            account.ID = b.ID;
            account.username = b.username;
            account.password = b.password;
            account.phone = b.phone;
            account.email = b.email;
            account.type = b.type;
            bool result = AccountService.Remove(account);
            return result;
        }

       

        public bool AddOrder(OrderData od)
        {
            Order o = new Order()
            {
                ID = od.ID,
                account_ID = od.account_ID,
                customer_name = od.customer_name,
                status = od.status,
                date = od.date
            };
            bool result = OrderService.Add(o);
            return result;
        }

        public bool UpdateOrder(OrderData od)
        {
            Order o = new Order()
            {
                ID = od.ID,
                account_ID = od.account_ID,
                customer_name = od.customer_name,
                status = od.status,
                date = od.date
            };
            bool result = OrderService.Update(o);
            return result;
        }

        public bool RemoveCategory(CategoryData c)
        {
            Category category = new Category();
            category.name = c.name;
            category.ID = c.ID;
            category.status = c.status;
            return CategoryService.Remove(category);    
        }

        public bool UpdateCategory(CategoryData c)
        {
            Category category = new Category();
            category.ID = c.ID;
            category.name = c.name;
            category.status = c.status;
            return CategoryService.Update(category);
        }

        public DataTable GetAllCategory()
        {
            return CategoryService.getAllCategory();
        }
    }
}
