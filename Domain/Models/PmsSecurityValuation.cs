using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsSecurityValuation
    {
        public DateTime ValDate { get; set; }
        public int TradInstTypeCode { get; set; }
        public int TradInstCode { get; set; }
        public int FundCode { get; set; }
        public decimal ValPrice { get; set; }
        public decimal ValHolding { get; set; }
        public decimal ValValuation { get; set; }
        public string ValDescription { get; set; }
    }
}
