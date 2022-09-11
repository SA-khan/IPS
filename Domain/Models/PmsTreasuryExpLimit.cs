using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsTreasuryExpLimit
    {
        public int TrExpLimitsCode { get; set; }
        public int TreasuryExpSno { get; set; }
        public int TreasuryExpProduct { get; set; }
        public int TreasuryExpMode { get; set; }
        public int FInstBranchCode { get; set; }
        public int FundMasterCode { get; set; }
        public DateTime TrExpLimitsDate { get; set; }
        public int? TrExpLimitsType { get; set; }
        public int? TradInstTypeCode { get; set; }
        public int? SubProductCode { get; set; }
        public DateTime? TrExpLimitsExpiryDate { get; set; }
        public decimal? TrExpLimitsAmountLimit { get; set; }
        public decimal? TrExpLimitsAmountPercentage { get; set; }
        public int? TrExpLimitsCreatedBy { get; set; }
        public DateTime? TrExpLimitsCreatedWhen { get; set; }
        public int? TrExpLimitsModifyBy { get; set; }
        public DateTime? TrExpLimitsModifyWhen { get; set; }
        public int? FInstCode { get; set; }
        public int? TrExpLimitsIsAlco { get; set; }
        public DateTime? TrExpLimitsAlcoDate { get; set; }
    }
}
