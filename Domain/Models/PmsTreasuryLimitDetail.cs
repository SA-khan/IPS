using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsTreasuryLimitDetail
    {
        public int TrLimitDetailCode { get; set; }
        public int FInstTranCode { get; set; }
        public int? FInstTranType { get; set; }
        public int? FInstTranMode { get; set; }
        public int? FinstTypeCode { get; set; }
        public int? FinstCode { get; set; }
        public int? FinstBranchCode { get; set; }
        public int? FundCode { get; set; }
        public string TreasuryExpGroupby { get; set; }
        public decimal? ProductLimitAmt { get; set; }
        public decimal? ProductUtilizedLimit { get; set; }
        public decimal? TotalUtilizedLimit { get; set; }
    }
}
