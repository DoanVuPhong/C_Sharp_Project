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


        //Author Bussiness Logic Implement

        //Begin Bussiness Order

        [OperationContract]
        bool AddOrder(OrderData a);

        [OperationContract]

        bool UpdateOrder(OrderData a);
        [OperationContract]
        DataTable SearchByDate(DateTime date);

        //End bussiness Order

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
    }
}
