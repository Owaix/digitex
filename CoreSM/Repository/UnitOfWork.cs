using CoreSM.Interface;
using CoreSM.Model;

namespace CoreSM.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SalesDbContext _context;
        public UnitOfWork(SalesDbContext context)
        {
            _context = context;
            Users = new UsersRepository(_context);
            SalesCategory = new SalesCategoryRepository(_context);
            Invoice = new InvoiceRepository(_context);
            Payment = new PaymentRepository(_context);
        }
        public IUsers_Repository Users { get; set; }
        public ISalesCategory_Repository SalesCategory { get; set; }
        public IInvoice_Repository Invoice { get; set; }
        public IPayment_Repository Payment { get; set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
