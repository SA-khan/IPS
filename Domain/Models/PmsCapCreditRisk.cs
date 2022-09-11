using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsCapCreditRisk
    {
        public int FundMasterCode { get; set; }
        public int FundCode { get; set; }
        public int TradInstTypeCode { get; set; }
        public DateTime CapCreditRiskDate { get; set; }
        public int RatingCode { get; set; }
        public decimal? CapCreditRiskBaselRate { get; set; }
        public int? CapCreditRiskCreatedBy { get; set; }
        public DateTime? CapCreditRiskCreatedWhen { get; set; }
    }
}
