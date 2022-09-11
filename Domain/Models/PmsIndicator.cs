using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsIndicator
    {
        public int IndicatorCode { get; set; }
        public string IndicatorName { get; set; }
        public string IndicatorDesc { get; set; }
        public int TradInstTypeCode { get; set; }
        public int? IndicatorModifiedBy { get; set; }
        public DateTime? IndicatorModifiedWhen { get; set; }
        public int? MarketCode { get; set; }
    }
}
