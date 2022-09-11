using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsFundMasterUser
    {
        public int FuSno { get; set; }
        public int FundMasterCode { get; set; }
        public int UserCode { get; set; }
        public string UserName { get; set; }
        public int? FuIsLinked { get; set; }
        public DateTime? FuLinkingDate { get; set; }
        public int? FuCreatedBy { get; set; }
        public DateTime? FuCreatedWhen { get; set; }
        public int? FuModifiedBy { get; set; }
        public DateTime? FuModifiedWhen { get; set; }
    }
}
