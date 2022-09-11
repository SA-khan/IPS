using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsRiskAppetite
    {
        public int RiskAppetiteSno { get; set; }
        public int FundMasterCode { get; set; }
        public DateTime RiskAppetiteDate { get; set; }
        public decimal RiskAppetiteLoss { get; set; }
        public int RiskAppetiteIsActive { get; set; }
        public string RiskAppetiteFundFlag { get; set; }
        public int? RiskAppetiteCreatedBy { get; set; }
        public DateTime? RiskAppetiteCreatedWhen { get; set; }
    }
}
