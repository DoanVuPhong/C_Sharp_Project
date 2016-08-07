using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Services
{
    class BookService
    {
        public bool AddBook(Book b)
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

        public bool DeleteBook(Book b)
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

        public bool UpdateBook(Book b)
        {
            try
            {
                using (Book_Sale_ManagerEntities context = new Book_Sale_ManagerEntities())
                {
                    Book book = context.Books.FirstOrDefault(t => t.ID == b.ID);
                    if(book != null)
                    {
                        book.ISBN = b.ISBN;
                        book.name = b.name;
                        book.description = b.description;
                        book.thumbnail = b.thumbnail;
                        book.quantity = b.quantity;
                        book.price = b.price;
                        book.status = b.status;
                        book.year = b.year;
                        book.publisher_ID = b.publisher_ID;
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
