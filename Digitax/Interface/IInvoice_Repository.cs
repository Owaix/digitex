using CoreSM.Interface;
using CoreSM.Models;
using System.Collections.Generic;

namespace CoreSM.Model
{
    public interface IInvoice_Repository : IGenericRepository<Invoice>
    {
        int AddInvoice(Invoice Invoice);
        List<Invoice> GetInvoice();
        Invoice PutInvoice(Invoice Invoice);
        Invoice GetInvoiceById(int id);
    }
}
