namespace CoreSM.ViewModels
{
    using CoreSM.Interface;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Sales_VM
    {

        public int RID { get; set; }
        [Display(Name = "Warehouse")]
        public int WarehouseID { get; set; }
        [Display(Name = "Sales Person")]
        public int SalesPersonID { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        [Display(Name = "Account")]
        public int AccountID { get; set; }
        [Display(Name = "Ref")]
        public string RefNumber { get; set; }
        public string Barcode { get; set; }
        [Display(Name = "Item")]
        public string IID { get; set; }
        [Display(Name = "Batch")]
        public string BatchNo { get; set; }
        [Display(Name = "Expiry")]
        public DateTime ExpireDate { get; set; }
        public string WholeSale { get; set; }
        public string CTN { get; set; }
        public string PCS { get; set; }
        public decimal Rate { get; set; }
        [Display(Name = "DISC(%)")]
        public int DisP { get; set; }
        [Display(Name = "DISC(Rs)")]
        public decimal DisRs { get; set; }
        public decimal Amount { get; set; }
        [Display(Name = "Total Amount")]
        public decimal TotalAmount { get; set; }
        public string Transport { get; set; }
        [Display(Name = "Company")]
        public int CompanyID { get; set; }
        [Display(Name = "Vendor")]
        public int VendorID { get; set; }
        [Display(Name = "Net Amount")]
        public double NetAmount { get; set; }
        public double Discount { get; set; }
        public string Remarks { get; set; }
        public DateTime dptInvoice { get; set; } = DateTime.Now;
        public String SIDetailjson { get; set; }
        public List<SaleInvoiceDetailVM> SaleInvoiceDetail { get; set; } = new List<SaleInvoiceDetailVM>();
        public int rdoprint { get; set; }
        public int msgStatus { get; set; }
        public string msg { get; set; }
        public string AC_Code { get; set; }
        public int isPrint { get; set; }
        public List<SinvList> sinvList { get; set; } = new List<SinvList>();
        public IUnitOfWork unitOfWork { get; set; }
    }
    public class SinvList
    {
        public int RID { get; set; }
        public string InvNo { get; set; }
        public string VenInvDate { get; set; }
    }

    public class SaleInvoiceDetailVM
    {
        public int SDID { get; set; }
        public double IID { get; set; }
        public string IName { get; set; }
        public string CTN { get; set; }
        public double PCS { get; set; }
        public double SalesPriceP { get; set; }
        public double TotalPcs { get; set; }
        public string DisP { get; set; }
        public string DisRs { get; set; }
        public double Amt { get; set; }
        public int ArticleNoID { get; set; }
        public string BatchNo { get; set; }
        public string ExpireDate { get; set; }
    }
}
