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
        public bool AddAuthor(AuthorData a)
        {
            Author author = new Author();
            author.name = a.name;
            bool result = AuthorService.Add(author);
            return result;
        }

        public bool IAddBook(BookData b)
        {
            Book book = new Book();
            book.name = b.Name;
            book.description = b.Description;
            book.thumbnail = b.Thumnail;
            book.quantity = b.Quantity;
            book.price = b.Price;
            book.status = b.Status;
            book.year = b.Year;
            book.publisher_ID = b.Publisher_ID;
            bool result = BookService.AddBook(book);
            return result;
        }

        public bool IRemoveBook(BookData b)
        {
            Book book = new Book();
            book.ID = b.ID;
            book.name = b.Name;
            book.description = b.Description;
            book.thumbnail = b.Thumnail;
            book.quantity = b.Quantity;
            book.price = b.Price;
            book.status = b.Status;
            book.year = b.Year;
            book.publisher_ID = b.Publisher_ID;
            bool result = BookService.DeleteBook(book);
            return result;
        }

        public bool IUpdateBook(BookData b)
        {
            Book book = new Book();
            book.ID = b.ID;
            book.name = b.Name;
            book.description = b.Description;
            book.thumbnail = b.Thumnail;
            book.quantity = b.Quantity;
            book.price = b.Price;
            book.status = b.Status;
            book.year = b.Year;
            book.publisher_ID = b.Publisher_ID;
            bool result = BookService.UpdateBook(book);
            return result;
        }

        public bool Remove(AuthorData a)
        {
            Author author = new Author();
            author.ID = a.ID;
            author.name = a.name;
            bool result = AuthorService.Remove(author);
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
