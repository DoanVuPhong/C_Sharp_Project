using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

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
        //End bussiness Order



    }
}
