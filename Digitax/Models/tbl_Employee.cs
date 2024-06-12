
namespace CoreSM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public  class tbl_Employee
    {
        [Key]
        public int ID { get; set; }
        public string EmployeName { get; set; }
        public Nullable<int> PyteTypeID { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<int> ACCode { get; set; }
        public Nullable<int> companyID { get; set; }
        public Nullable<int> AllowTable { get; set; }
        public string Cnic { get; set; }
        public Nullable<System.DateTime> DateOfAppointment { get; set; }
        public string MobileNo { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string CurrentAddress { get; set; }
        public string PermantAddress { get; set; }
        public Nullable<int> EmployeeType { get; set; }
        public Nullable<int> Department { get; set; }
        public Nullable<int> Designation { get; set; }
    }
}
