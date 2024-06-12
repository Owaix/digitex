
namespace CoreSM.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class COA_M
    {
        [Key]
        public Nullable<double> MAC_Code { get; set; }
        public string MTitle { get; set; }
        public Nullable<double> SubAC_Code { get; set; }
        public string SubTitle { get; set; }
        public int CAC_Code { get; set; }
        public string CATitle { get; set; }
    }
}
