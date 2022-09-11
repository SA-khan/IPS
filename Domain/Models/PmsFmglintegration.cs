using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsFmglintegration
    {
        public int? Sno { get; set; }
        public int? FundMasterCode { get; set; }
        public string FundMasterGlcompCode { get; set; }
        public string FundMasterSiteCode { get; set; }
        public string FundMasterCostCenter { get; set; }
        public string FundMasterGldbname { get; set; }
        public string FmglintegDbserver { get; set; }
        public string FmglintegDbuser { get; set; }
        public string FmglintegDbpassword { get; set; }
        public int? FmglintegDbtype { get; set; }
        public int? GlmodeCode { get; set; }
        public string FmglMnemonic { get; set; }
        public string LedgerId { get; set; }
    }
}
