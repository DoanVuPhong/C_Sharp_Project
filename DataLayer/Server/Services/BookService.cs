using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

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
                    Console.WriteLine("Add a new book successful");
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Can't add Book to database. Detail: {0}");
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
                        Console.WriteLine("Delete a Book successful");
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
                        Console.WriteLine("Update book successful");
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

        public static SqlConnection cnn = new SqlConnection("server = .\\SQLEXPRESS; database=Book_Sale_Manager;uid=sa;pwd=12345678");

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
            catch (Exception e)
            {
                throw new Exception(e.Message);
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
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //try
            //{
            //    if (cnn.State == ConnectionState.Closed)
            //    {
            //        cnn.Open();
            //    }
            //    da.Fill(ListBook);
            //    return ListBook;
            //}
            //catch (Exception e)
            //{
            //    throw new Exception(e.Message);
            //}
            //finally
            //{
            //    if (cnn != null)
            //    {
            //        cnn.Close();
            //    }
            //}
            //return null;
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
            catch (Exception e)
            {
                throw new Exception(e.Message);
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
            catch (Exception e)
            {
                throw new Exception(e.Message);
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
            catch (Exception e)
            {
                throw new Exception(e.Message);
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
    }
}
