﻿using System;
using System.Collections.Generic;
using System.Data;
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
        
        
        
        
        /*==========================================================================================*/









    }
}
