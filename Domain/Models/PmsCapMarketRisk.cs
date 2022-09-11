using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsCapMarketRisk
    {
        public int FundMasterCode { get; set; }
        public int FundCode { get; set; }
        public int TradInstTypeCode { get; set; }
        public DateTime CapMarketRiskDate { get; set; }
        public int MarketCode { get; set; }
        public decimal? MarketLongPosition { get; set; }
        public decimal? MarketShortPosition { get; set; }
        public int? CapMarketRiskCreatedBy { get; set; }
        public DateTime? CapMarketRiskCreatedWhen { get; set; }
    }
}
