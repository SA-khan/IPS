using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsGlAccountDetail
    {
        public int GlHeadEntityType { get; set; }
        public int GlHeadAccType { get; set; }
        public int GlDetailEntityCode { get; set; }
        public int FundCode { get; set; }
        public string GlDetailAccCode { get; set; }
        public string GlDetailDesc { get; set; }
        public string GlDetailAccTitle { get; set; }
        public int? GlAccountDetailCode { get; set; }
        public int? GlDetailColtrlType { get; set; }
        public int? GlDetailColtrlSubType { get; set; }
        public int? FundMasterCode { get; set; }
        public int? GlAccountDetailModule { get; set; }
        public string SubLedger { get; set; }
    }
}
