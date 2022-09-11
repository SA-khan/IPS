using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsLimitFundConfig
    {
        public DateTime LmtFundDate { get; set; }
        public int FundMasterCode { get; set; }
        public int FundCode { get; set; }
        public decimal? LmtFundStopLossLmt { get; set; }
        public int? LmtFundDaysLmt { get; set; }
        public int? LmtFundDateBasis { get; set; }
        public int? LmtFundModifiedBy { get; set; }
        public DateTime? LmtFundModifiedWhen { get; set; }
        public int? TradInstTypeCode { get; set; }
    }
}
