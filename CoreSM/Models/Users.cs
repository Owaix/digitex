using System.ComponentModel.DataAnnotations;

namespace CoreSM.Models
{
    public class Users
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public bool IsInvoice { get; set; }
        public bool IsPayment { get; set; }
    }
}
