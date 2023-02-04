namespace CoreSM.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Sales_M
    {
        [Key]
        public int RID { get; set; }
        public Nullable<double> CompID { get; set; }
        public string RID2 { get; set; }
        public Nullable<System.DateTime> EDate { get; set; }
        public string CAC_Code { get; set; }
        public Nullable<double> AC_Code { get; set; }
        public string Ship_To { get; set; }
        public string Ship_ID { get; set; }
        public string Trans_ID { get; set; }
        public string BiltyNo { get; set; }
        public Nullable<double> SID { get; set; }
        public Nullable<double> WID { get; set; }
        public string Rem { get; set; }
        public Nullable<double> NetAmt2 { get; set; }
        public Nullable<double> DisAmt { get; set; }
        public Nullable<double> PreBal { get; set; }
        public Nullable<double> NetAmt { get; set; }
        public string AC_Code3 { get; set; }
        public string CashAmt { get; set; }
        public Nullable<double> APost { get; set; }
        public Nullable<double> Posted { get; set; }
        public Nullable<double> RCancel { get; set; }
        public Nullable<double> War_Cls { get; set; }
        public Nullable<double> Create_User_ID { get; set; }
        public Nullable<System.DateTime> Create_Date { get; set; }
        public Nullable<double> Edit_User_ID { get; set; }
        public Nullable<System.DateTime> Edit_Date { get; set; }
        public string Del_User_ID { get; set; }
        public string Del_Date { get; set; }
        public string InvNo { get; set; }
        public Nullable<System.DateTime> InvDT { get; set; }
        public string InvType { get; set; }
        public Nullable<int> CstId { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public string CstInvNo { get; set; }
        public string VenInvDate { get; set; }
        public Nullable<double> TransportExpense { get; set; }
        public string ReferenceNo { get; set; }
        public string CashCustomer { get; set; }
        public string contact { get; set; }
    }
}
