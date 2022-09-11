using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsTrDealerLimitConfig
    {
        public int DealerLimitCombination { get; set; }
        public int DealerLimitSno { get; set; }
        public int? ModuleType { get; set; }
        public int? TradinstTypeCode { get; set; }
        public int? ProductCode { get; set; }
        public int? FinstTranMode { get; set; }
        public string DelearLimtDescription { get; set; }
        public int? DealerLimitIsDayMonYear { get; set; }
        public int? DealerLimitStart { get; set; }
        public int? DealerLimitEnd { get; set; }
    }
}
