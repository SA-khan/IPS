using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsMarketToleranceRate
    {
        public int FundMasterCode { get; set; }
        public DateTime MktToleranceRateDate { get; set; }
        public int TradinstTypeCode { get; set; }
        public int TradinstCode { get; set; }
        public int? ProductCode { get; set; }
        public decimal? MktToleranceRateRate { get; set; }
        public int? MktToleranceRateCreatedBy { get; set; }
        public DateTime? MktToleranceRateCreateddWhen { get; set; }
        public int? MktToleranceRateModifiedBy { get; set; }
        public DateTime? MktToleranceRateModifiedWhen { get; set; }
    }
}
