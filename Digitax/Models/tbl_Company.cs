
namespace CoreSM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public  class tbl_Company
    {
        [Key]
        public int CompID { get; set; }
        public string Comp { get; set; }
        public string CShort { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public string Eml { get; set; }
        public Nullable<bool> isDelete { get; set; }
        public Nullable<int> companyID { get; set; }
    }
}
