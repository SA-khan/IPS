using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsFundMasterNote
    {
        public int FmnCode { get; set; }
        public int FundMasterCode { get; set; }
        public DateTime FmnDate { get; set; }
        public string FmnNotes { get; set; }
        public int FmnIsActive { get; set; }
        public int FmnSno { get; set; }
        public int FmnCreatedBy { get; set; }
        public DateTime? FmnCreatedWhen { get; set; }
        public int FmnModifiedBy { get; set; }
        public DateTime? FmnModifiedWhen { get; set; }
    }
}
