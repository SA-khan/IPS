using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsProcessImpairmentTesting
    {
        public int ProcessImpTestingSno { get; set; }
        public DateTime ProcessImpTestingProcessDate { get; set; }
        public DateTime? ProcessImpTestingFromDate { get; set; }
        public DateTime? ProcessImpTestingToDate { get; set; }
        public int TradInstTypeCode { get; set; }
        public int TradinstCode { get; set; }
        public int FundMasterCode { get; set; }
        public int FundCode { get; set; }
        public DateTime? MovAvgTranDate { get; set; }
        public decimal? MovAvgAverage { get; set; }
        public decimal? MovAvgQty { get; set; }
        public decimal? MovAvgAmtMov { get; set; }
        public decimal? MovAvgAmtCarr { get; set; }
        public decimal? DmpPrice { get; set; }
        public decimal? MarketValue { get; set; }
        public decimal? UnrealisedGainLoss { get; set; }
        public decimal? UnrealisedGainLossPer { get; set; }
        public decimal? UnrealisedGainLossMinPer { get; set; }
        public decimal? UnrealisedGainLossMaxPer { get; set; }
        public int? ProcessImpTestingIsVerified { get; set; }
        public int? ProcessImpTestingCreatedBy { get; set; }
        public DateTime? ProcessImpTestingCreatedWhen { get; set; }
        public int? ProcessImpTestingVerifiedBy { get; set; }
        public DateTime? ProcessImpTestingVerifiedWhen { get; set; }
    }
}
