using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsDailyFmrdatum
    {
        public int FundMasterCode { get; set; }
        public int TradInstTypeCode { get; set; }
        public int InstrumentCode { get; set; }
        public int FundCode { get; set; }
        public int ProductCode { get; set; }
        public DateTime DailyFmrReportDate { get; set; }
        public string InstrumentName { get; set; }
        public DateTime InstrumentIssueDate { get; set; }
        public DateTime InstrumentMaturityDate { get; set; }
        public decimal? InstrumentCouponRate { get; set; }
        public int? InstrumentTenor { get; set; }
        public DateTime? MarketDate { get; set; }
        public decimal? MarketRate { get; set; }
        public decimal? MarketAvgAmt { get; set; }
        public string FundMasterName { get; set; }
        public string FundMnemonic { get; set; }
        public string FundName { get; set; }
        public DateTime? MovAvgTranDate { get; set; }
        public decimal? MovAvgAverage { get; set; }
        public decimal? MovAvgAmtMov { get; set; }
        public decimal? PkrvAvgYield { get; set; }
        public string CreditRating { get; set; }
        public int? SerialNo { get; set; }
        public decimal? FaceValue { get; set; }
        public DateTime? LastCpnDate { get; set; }
        public DateTime? NextCpnDate { get; set; }
        public decimal? TotalDays { get; set; }
        public decimal? AverageCost100 { get; set; }
        public decimal? MufapPrice100 { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Redeem { get; set; }
        public decimal? Accrual { get; set; }
        public decimal? Yield { get; set; }
        public decimal? NavAmount { get; set; }
        public decimal? NumberofUnits { get; set; }
        public decimal? Nav { get; set; }
        public string ProductName { get; set; }
        public decimal? Pkrv { get; set; }
        public decimal? InstYield { get; set; }
        public decimal? WeightAverage { get; set; }
        public DateTime? NavDate { get; set; }
        public string GroupRating { get; set; }
        public string ProtfolioRating { get; set; }
        public int? DailyFmrIsVerified { get; set; }
        public int? DailyFmrCreatedBy { get; set; }
        public DateTime? DailyFmrCreatedWhen { get; set; }
        public int? DailyFmrModifyBy { get; set; }
        public DateTime? DailyFmrModifyWhen { get; set; }
        public string FInstName { get; set; }
        public string TranTypeName { get; set; }
    }
}
