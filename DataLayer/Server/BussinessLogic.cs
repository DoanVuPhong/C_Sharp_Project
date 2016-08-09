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
        public bool AddAuthor(AuthorData a)
        {
            Author author = new Author();
            author.name = a.name;
            bool result = AuthorService.Add(author);
            return result;
        }

        public DataTable FilterBookByCategory(string category)
        {
            DataTable listBook = BookService.FilterByCategory(category);
            return listBook;
        }

        public DataTable GetAllBook()
        {
            DataTable listBook = BookService.GetAllBook();
            return listBook;
        }

        public BookData GetBookByID(int ID)
        {
            Book b = BookService.GetBookByID(ID);
            BookData book = new BookData()
            {
                ID = b.ID,
                ISBN = b.ISBN,
                Name = b.name,
                Description = b.description,
                Thumnail = b.thumbnail,
                Quantity = int.Parse(b.quantity.ToString()),
                Price = int.Parse(b.price.ToString()),
                Status = b.status,
                Year = b.year,
                Publisher_ID = int.Parse(b.publisher_ID.ToString())
            };
            return book;
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

        public DataTable SearchBookByAuthor(string author)
        {
            DataTable ListBook = BookService.SearchBookByAuthor(author);
            return ListBook;
        }

        public DataTable SearchBookByPublisher(string publisher)
        {
            DataTable ListBook = BookService.SearchBookByPublisher(publisher);
            return ListBook;
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
