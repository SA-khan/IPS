using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsDailyRate
    {
        public int DRateCode { get; set; }
        public DateTime DRateDate { get; set; }
        public int RateTemplCode { get; set; }
        public byte RateTemplType { get; set; }
        public decimal? DRateBid { get; set; }
        public decimal? DRateOffer { get; set; }
        public string RateTemplSlabName { get; set; }
        public int? FInstBranchCode { get; set; }
    }
}
