using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Services
{
    public class BookService
    {
        public static bool AddBook(Book b)
        {
            try
            {
                using (Book_Sale_ManagerEntities context = new Book_Sale_ManagerEntities())
                {
                    context.Books.Add(b);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Can't add Book to database. Detail: {0}", ex);
            }
            return false;
        }

        public static bool DeleteBook(Book b)
        {
            try
            {
                using (Book_Sale_ManagerEntities context = new Book_Sale_ManagerEntities())
                {
                    Book book = context.Books.FirstOrDefault(t => t.ID == b.ID);
                    if (book != null)
                    {
                        context.Books.Remove(b);
                        context.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Can't Remove Book to database. Detail: {0}", ex);
            }
            return false;
        }

        public static bool UpdateBook(Book b)
        {
            try
            {
                using (Book_Sale_ManagerEntities context = new Book_Sale_ManagerEntities())
                {
                    Book book = context.Books.FirstOrDefault(t => t.ID == b.ID);
                    if (book != null)
                    {
                        if (book.ISBN != null) book.ISBN = b.ISBN;
                        if (book.name != null) book.name = b.name;
                        if (book.description != null) book.description = b.description;
                        if (book.thumbnail != null) book.thumbnail = b.thumbnail;
                        if (book.quantity != null) book.quantity = b.quantity;
                        if (book.price != null) book.price = b.price;
                        if (book.status != null) book.status = b.status;
                        if (book.year != null) book.year = b.year;
                        if (book.publisher_ID != null) book.publisher_ID = b.publisher_ID;
                        context.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Can't Update Book to database. Detail: {0}", ex);
            }
        }
    }
}
