using System.ComponentModel.DataAnnotations;

namespace CoreSM.Models
{
    public class SalesCategory
    {
        [Key]
        public int ID { get; set; }
        public string Type { get; set; }
        public string PayerType { get; set; }
        public string Category { get; set; }
        public decimal TaxRate { get; set; }
    }
}