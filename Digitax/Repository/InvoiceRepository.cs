using CoreSM.Models;
using CoreSM.Repository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CoreSM.Model
{
    public class InvoiceRepository : GenericRepository<Invoice>, IInvoice_Repository
    {
        private readonly SalesDbContext db;

        public InvoiceRepository(SalesDbContext context) : base(context)
        {
        }

        //  public List<Invoice> GetInvoice() => db.Invoice.ToList();
        public List<Invoice> GetInvoice()
        {
            var list = (from inv in _context.Invoice
                        join cat in _context.SalesCategory on inv.SaleCategoryID equals cat.ID
                        where inv.TaxWithheld == "yes"
                        select new Invoice
                        {
                            ID = inv.ID,
                            UserID = inv.UserID,
                            InvoiceDate = inv.InvoiceDate,
                            CNIC = inv.CNIC,
                            TaxPayerType = inv.TaxPayerType,
                            SaleType = cat.Category,
                            TaxRate = inv.TaxRate,
                            TaxWithheld = inv.TaxWithheld,
                            TaxAmount = inv.TaxAmount,
                        }).ToList();
            return list;

        }

        public Invoice PutInvoice(Invoice Invoice)
        {
            //_context.Invoice.Update(Invoice);
            _context.Entry(Invoice).State = EntityState.Modified;
            _context.SaveChanges();
            return Invoice;
        }

        public int AddInvoice(Invoice Invoice)
        {
            _context.Invoice.Add(Invoice);
            return _context.SaveChanges();
        }

        public Invoice GetInvoiceById(int Id)
        {
            return _context.Invoice.Where(x => x.ID == Id).FirstOrDefault();
        }
    }
}
