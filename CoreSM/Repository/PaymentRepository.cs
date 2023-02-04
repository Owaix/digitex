using CoreSM.Models;
using CoreSM.Repository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CoreSM.Model
{
    public class PaymentRepository : GenericRepository<Payment>, IPayment_Repository
    {
        private readonly SalesDbContext db;

        public PaymentRepository(SalesDbContext context) : base(context)
        {
        }

        //  public List<Payment> GetPayment() => db.Payment.ToList();
        public List<Payment> GetPayment()
        {
            var list = (from inv in _context.Payment
                        join cat in _context.SalesCategory on inv.SaleCategoryID equals cat.ID
                        where inv.TaxWithheld == "yes"
                        select new Payment
                        {
                            ID = inv.ID,
                            UserID = inv.UserID,
                            PaymentDate = inv.PaymentDate,
                            CNIC = inv.CNIC,
                            TaxPayerType = inv.TaxPayerType,
                            SaleType = cat.Category,
                            TaxRate = inv.TaxRate,
                            TaxWithheld = inv.TaxWithheld,
                            TaxAmount = inv.TaxAmount,
                        }).ToList();
            return list;

        }

        public Payment PutPayment(Payment Payment)
        {
            //_context.Payment.Update(Payment);
            _context.Entry(Payment).State = EntityState.Modified;
            _context.SaveChanges();
            return Payment;
        }

        public int AddPayment(Payment Payment)
        {
            _context.Payment.Add(Payment);
            return _context.SaveChanges();
        }

        public Payment GetPaymentById(int Id)
        {
            return _context.Payment.Where(x => x.ID == Id).FirstOrDefault();
        }
    }
}
