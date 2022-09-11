using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsMarketTiming
    {
        public int MarketTimingSno { get; set; }
        public int MarketCode { get; set; }
        public DateTime? MarketTimingOpen { get; set; }
        public DateTime? MarketTimingClose { get; set; }
        public DateTime? MarketTimingAppliedDate { get; set; }
        public string MarketTimingRemarks { get; set; }
        public int? MarketTimingCreatedby { get; set; }
        public DateTime? MarketTimingCreatedWhen { get; set; }
        public int? MarketTimingModifiedBy { get; set; }
        public DateTime? MarketTimingModifiedWhen { get; set; }
    }
}
