using CoreSM.Model;
using System;

namespace CoreSM.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IUsers_Repository Users { get; }
        IInvoice_Repository Invoice { get; }
        IPayment_Repository Payment { get; }
        ISalesCategory_Repository SalesCategory { get; }
        int Complete();
    }
}
