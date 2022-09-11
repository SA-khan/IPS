using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsCdrHead
    {
        public int CdrHeadCode { get; set; }
        public int FundMasterCode { get; set; }
        public string GlAccCode { get; set; }
        public string FundMasterCostCenter { get; set; }
        public string GlAccTitle { get; set; }
        public bool? IsActive { get; set; }
    }
}
