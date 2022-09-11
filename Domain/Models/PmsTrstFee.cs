using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsTrstFee
    {
        public int TrstFeeCode { get; set; }
        public int TrusteeCode { get; set; }
        public decimal? TrstFeeMin { get; set; }
        public decimal TrstFeeMax { get; set; }
        public decimal TrstFeePercent { get; set; }
        public decimal? TrstFeePlusAmount { get; set; }
        public int? TrstFeeFeeType { get; set; }
        public int? TrstFeeHighLow { get; set; }
        public decimal? TrstFeeCapPercent { get; set; }
        public decimal? TrstFeeFloorPercent { get; set; }
        public int? TrstFeeIsHighLow { get; set; }
        public int? TrstFeeIsExceeded { get; set; }

        public virtual PmsTrustee TrusteeCodeNavigation { get; set; }
    }
}
