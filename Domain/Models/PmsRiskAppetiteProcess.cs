using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsRiskAppetiteProcess
    {
        public int FundMasterCode { get; set; }
        public DateTime RaProcessDate { get; set; }
        public decimal RiskAppititeLoss { get; set; }
        public decimal RaProcessSurplusValuation { get; set; }
        public decimal RaProcessDividend { get; set; }
        public decimal RaProcessCapitalGain { get; set; }
        public decimal RaProcessAvgInvestment { get; set; }
        public DateTime RaProcessDateFrom { get; set; }
        public DateTime RaProcessDateTo { get; set; }
        public int RaProcessLock { get; set; }
        public int? RaProcessCreatedBy { get; set; }
        public DateTime? RaProcessCreatedWhen { get; set; }
    }
}
