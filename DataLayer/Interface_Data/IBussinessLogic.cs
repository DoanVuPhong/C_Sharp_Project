using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace Interface_Data
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBussinessLogic" in both code and config file together.
    [ServiceContract]
    public interface IBussinessLogic
    {

        //Author Bussiness Logic Implement
        [OperationContract]
        bool AddAuthor(AuthorData a);
        [OperationContract]
        bool Remove(AuthorData a);
        [OperationContract]
        bool Update(AuthorData a);


        //Book Bussiness Logic Implement
        [OperationContract]
        bool IAddBook(BookData b);
        [OperationContract]
        bool IUpdateBook(BookData b);
        [OperationContract]
        bool IRemoveBook(BookData b);
        [OperationContract]
        DataTable GetAllBook();
        [OperationContract]
        BookData GetBookByID(int ID);
        [OperationContract]
        DataTable SearchBookByAuthor(string author);
        [OperationContract]
        DataTable SearchBookByPublisher(string publisher);
        [OperationContract]
        DataTable FilterBookByCategory(string category);
    }
}
