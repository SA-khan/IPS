using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsApprovedScrip
    {
        public int FundMasterCode { get; set; }
        public int TradInstCode { get; set; }
        public int TradInstTypeCode { get; set; }
        public DateTime AppScripDate { get; set; }
        public byte? AppScripStatus { get; set; }
        public int? AppScripModifiedBy { get; set; }
        public DateTime? AppScripModifiedWhen { get; set; }
        public int? AppScripCreatedBy { get; set; }
        public DateTime? AppScripCreatedWhen { get; set; }
    }
}
