using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsRiskLimitConfig
    {
        public int RiskLimitConfigCode { get; set; }
        public int FundmasterCode { get; set; }
        public DateTime RiskLimitConfigDate { get; set; }
        public int? RiskLimitConfigProduct { get; set; }
        public int? RiskLimitConfigAmountType { get; set; }
        public decimal? RiskLimitConfigMinAmountlimit { get; set; }
        public decimal? RiskLimitConfigMaxAmountlimit { get; set; }
        public int? RiskLimitConfigActive { get; set; }
        public int? RiskLimitConfigIsconfiguraion { get; set; }
        public int? RiskLimitConfigCreatedby { get; set; }
        public DateTime? RiskLimitConfigCreatedwhen { get; set; }
        public int? RiskLimitConfigModifiedby { get; set; }
        public DateTime? RiskLimitConfigModifiedwhen { get; set; }
    }
}
