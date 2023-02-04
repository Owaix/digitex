using CoreSM.Interface;
using CoreSM.Models;
using System.Collections.Generic;

namespace CoreSM.Model
{
    public interface IPayment_Repository : IGenericRepository<Payment>
    {
        int AddPayment(Payment Payment);
        List<Payment> GetPayment();
        Payment PutPayment(Payment Payment);
        Payment GetPaymentById(int id);
    }
}
