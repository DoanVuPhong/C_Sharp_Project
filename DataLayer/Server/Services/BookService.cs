using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Interface_Data;

namespace Server.Services
{
    public class BookService
    {
        public static bool AddBook(BookData b)
        {
            Book book = new Book();
            book.ISBN = b.ISBN;
            book.name = b.Name;
            book.price = b.Price;
            book.quantity = b.Quantity;
            book.status = b.Status;
            book.year = b.Year;
            book.publisher_ID = b.Publisher_ID;
            try
            {
                using (Book_Sale_ManagerEntities context = new Book_Sale_ManagerEntities())
                {
                    Console.WriteLine(b.Author.Count);
                    for (int i = 0; i < b.Author.Count; i++)
                    {
                        int ID = b.Author[i].ID;
                        Author author = context.Authors.FirstOrDefault(a => a.ID ==ID); 
                        Book_Author BA = new Book_Author();
                        BA.Author = author;
                        BA.Book = book;
                        book.Book_Author.Add(BA);
                    }
                    for (int i = 0; i < b.Category.Count; i++)
                    {
                        int ID = b.Category[i].ID;
                        Category category=context.Categories.FirstOrDefault(c=>c.ID==ID);
                        Book_Category temp = new Book_Category();
                        temp.Category = category;
                        temp.Book = book;
                        book.Book_Category.Add(temp);
                    }

                    context.Books.Add(book);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                LogService.log("BOOK", ex.StackTrace);
                return false;
            }
        }

        public static bool DeleteBook(Book b)
        {
            try
            {
                using (Book_Sale_ManagerEntities context = new Book_Sale_ManagerEntities())
                {
                    Book_Author book_author = context.Book_Author.FirstOrDefault(t => t.ID == b.ID);
                    while (book_author != null)
                    {
                        context.Book_Author.Remove(book_author);
                        context.SaveChanges();
                        book_author = context.Book_Author.FirstOrDefault(t => t.ID == b.ID);
                    }
                    Book_Category book_category = context.Book_Category.FirstOrDefault(t => t.ID == b.ID);
                    while (book_category != null)
                    {
                        context.Book_Category.Remove(book_category);
                        context.SaveChanges();
                        book_category = context.Book_Category.FirstOrDefault(t => t.ID == b.ID);
                    }
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
                LogService.log("BOOK", ex.Message);
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
                LogService.log("BOOK", ex.Message);
                return false;
            }
        }

        public static SqlConnection cnn = new SqlConnection("server = .\\SQL2012; database=Book_Sale_Manager;uid=sa;pwd=123");

        public static DataTable GetAllBook()
        {
            DataTable ListBook = new DataTable("ListAllBook");
            SqlCommand cmd = new SqlCommand("select b.ID, b.ISBN, b.description, b.name, b.price, b.quantity,"
                + " b.status, b.thumbnail, b.year ,p.name as Publihser_Name from Book b, Publisher p where b.publisher_ID = p.ID", cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                da.Fill(ListBook);
                return ListBook;
            }
            catch (Exception ex)
            {
                LogService.log("BOOK", ex.Message);
            }
            finally
            {
                if (cnn != null)
                {
                    cnn.Close();
                }
            }
            return null;
        }

        public static Book GetBookByID(int ID)
        {
            Book b = new Book();
            SqlCommand cmd = new SqlCommand("select b.ID, b.ISBN, b.description, b.name, b.price, b.quantity,"
                + " b.status, b.thumbnail, b.year ,p.name as Publihser_Name from Book b, Publisher p where b.publisher_ID = p.ID and b.ID = @ID", cnn);
            cmd.Parameters.AddWithValue("@ID", ID);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                b.ID = rd.GetInt32(0);
                b.ISBN = rd.GetString(1);
                b.name = rd.GetString(2);
                b.description = rd.GetString(3);
                b.thumbnail = rd.GetString(4);
                b.quantity = rd.GetInt32(5);
                b.price = rd.GetFloat(6);
                b.status = rd.GetString(7);
                b.year = rd.GetString(8);
                b.publisher_ID = rd.GetInt32(9);
            }
            return b;

        }

        public static DataTable SearchBookByAuthor(string author)
        {
            DataTable ListBook = new DataTable("ListBookByAuthor");
            SqlCommand cmd = new SqlCommand("select b.ID, b.ISBN, b.description, b.name, b.price, b.quantity,"
                + " b.status, b.thumbnail, b.year, p.name as 'Publisher_Name' from Book b, Publisher p "
                + "where b.ID in (select ba.book_ID from Book_Author ba where ba.author_ID in (select a.ID from Author a where a.name like @Author))"
                + " and p.ID = b.publisher_ID", cnn);
            cmd.Parameters.AddWithValue("@Author", "%" + author + "%"

                );
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                da.Fill(ListBook);
                return ListBook;
            }
            catch (Exception ex)
            {
                LogService.log("BOOK", ex.Message);
            }
            finally
            {
                if (cnn != null)
                {
                    cnn.Close();
                }
            }
            return null;
        }

        public static DataTable SearchBookByPublisher(string publisher)
        {
            DataTable ListBook = new DataTable("ListBookByAuthor");
            SqlCommand cmd = new SqlCommand("select b.* from Book b, (select * from Publisher p where p.name like @Publisher) p where p.ID = b.publisher_ID", cnn);
            cmd.Parameters.AddWithValue("@Publisher", "%" + publisher + "%");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                da.Fill(ListBook);
                return ListBook;
            }
            catch (Exception ex)
            {
                LogService.log("BOOK", ex.Message);
            }
            finally
            {
                if (cnn != null)
                {
                    cnn.Close();
                }
            }
            return null;
        }

        public static DataTable FilterByCategory(string category)
        {
            DataTable ListBook = new DataTable("ListBookByCategory");
            SqlCommand cmd = new SqlCommand("select b.ID, b.ISBN, b.description, b.name, b.price, b.quantity,"
                + "b.status, b.thumbnail, b.year, p.name as 'Publisher_Name' from Book b, Publisher p"
                + "where b.ID in (select bc.book_ID from Book_Category bc where bc.category_ID in (select c.ID from Category c where c.name like @Category))"
                 + "and p.ID = b.publisher_ID", cnn);
            cmd.Parameters.AddWithValue("@Category", "%" + category + "%");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                da.Fill(ListBook);
                return ListBook;
            }
            catch (Exception ex)
            {
                LogService.log("BOOK", ex.Message);
            }
            finally
            {
                if (cnn != null)
                {
                    cnn.Close();
                }
            }
            return null;
        }

        public static List<PublisherData> getAllPublisher()
        {
            using (Book_Sale_ManagerEntities context = new Book_Sale_ManagerEntities())
            {
                List<Publisher> publishers = context.Publishers.ToList();
                List<PublisherData> result = new List<PublisherData>();
                foreach (var item in publishers)
                {
                    PublisherData p = new PublisherData()
                    {
                        ID = item.ID,
                        name = item.name
                    };
                    result.Add(p);
                }
                return result;
            }

        }

        public static List<CategoryData> GetAllBookCategoryData()
        {
            using (Book_Sale_ManagerEntities contex = new Book_Sale_ManagerEntities())
            {
                List<Category> categories = contex.Categories.ToList();

                List<CategoryData> result = new List<CategoryData>();
                foreach (var item in categories)
                {
                    CategoryData i = new CategoryData();
                    i.ID = item.ID;
                    i.name = item.name;
                    i.status = item.status;
                    result.Add(i);
                }
                return result;
            }
        }

        public static List<AuthorData> GetAllBookAuthorData()
        {
            using (Book_Sale_ManagerEntities contex = new Book_Sale_ManagerEntities())
            {
                List<Author> authors = contex.Authors.ToList();

                List<AuthorData> result = new List<AuthorData>();
                foreach (var item in authors)
                {
                    AuthorData a = new AuthorData();
                    a.ID = item.ID;
                    a.name = item.name;
                    result.Add(a);
                }
                return result;
            }





        }
    }
}
