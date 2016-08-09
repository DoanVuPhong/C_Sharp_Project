using System;
using System.Collections.Generic;
using System.Data;
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
        /*-----------------------------------------------------------------------------------------*/
        //Author Bussiness Logic Implement
        [OperationContract]
        bool AddAuthor(AuthorData a);
        [OperationContract]
        bool RemoveAuthor(AuthorData a);
        
        [OperationContract]
        bool UpdateAuthor(AuthorData a);
        [OperationContract]
        DataTable GetAllAuthor();
        //Author Bussiness Logic Implement
        /*-----------------------------------------------------------------------------------------*/
        /* Category Bussiness Logic*/
        /*==========================================================================================*/
        [OperationContract]
        bool AddCategory(CategoryData c);
        [OperationContract]
        bool RemoveCategory(CategoryData c);
        [OperationContract]
        bool UpdateCategory(CategoryData c);
        [OperationContract]
        DataTable GetAllCategory();

        /*==========================================================================================*/








        //Begin Bussiness Order

        [OperationContract]
        bool AddOrder(OrderData a);

        [OperationContract]

        bool UpdateOrder(OrderData a);
        [OperationContract]
        DataTable SearchByDate(DateTime date);

        //End bussiness Order
        //Account Business Logic Implement
        [OperationContract]
        bool AddAccount(AccountData b);
        [OperationContract]
        bool RemoveAccount(AccountData b);
        [OperationContract]
        bool checkLogin(string username, string password);


        //Begin Bussiness Publisher
        [OperationContract]
        bool AddPublisher(PublisherData p);
        [OperationContract]
        bool UpdatePublisher(PublisherData p);
        [OperationContract]
        bool DeletePublisher(PublisherData p);

        //End Bussiness Publisher

        //Begin Bussiness OrderDetail
        [OperationContract]
        bool AddOrderDetail(OrderDetailData p);
        [OperationContract]
        bool UpdateOrderDetail(OrderDetailData p);

        //End Bussiness OrderDetail

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
        // end business logic book
    }
}
