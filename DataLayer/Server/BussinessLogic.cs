using Interface_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Server.Services;

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

        public bool checkLogin(string username, string password)
        {
            throw new NotImplementedException();
        }

        public bool Remove(AuthorData a)
        {
            Author author = new Author();
            author.ID = a.ID;
            author.name = a.name;
            bool result = AuthorService.Remove(author);
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

        public bool Update(AuthorData a)
        {
            Author author = new Author();
            author.name = a.name;
            author.ID = a.ID;
            bool result=AuthorService.Update(author);
            return result;
        }
    }
}
