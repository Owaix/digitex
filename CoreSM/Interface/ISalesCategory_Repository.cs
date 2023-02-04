using CoreSM.Interface;
using CoreSM.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CoreSM.Model
{
    public interface ISalesCategory_Repository : IGenericRepository<SalesCategory>
    {
        IEnumerable<SalesCategory> GetSalesCategoryByType(string Type, string PayerType);
        SalesCategory GetSalesTaxByCategory(int ID);
        SalesCategory PutSalesCategory(SalesCategory category);        
    }
}
