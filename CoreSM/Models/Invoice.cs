using System;
using System.ComponentModel.DataAnnotations;

namespace CoreSM.Models
{
    public class Invoice
    {
        [Key]
        public int ID { get; set; }
        public int UserID { get; set; }
        public DateTime InvoiceDate { get; set; } = DateTime.Now;
        public string CNIC { get; set; }
        public string TaxPayerType { get; set; }
        public string SaleType { get; set; }
        public int SaleCategoryID { get; set; }
        public decimal TaxRate { get; set; }
        public string TaxWithheld { get; set; }
        public decimal TaxAmount { get; set; }
    }
}