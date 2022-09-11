using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsDailyFundPosition
    {
        public int FundMasterCode { get; set; }
        public DateTime DailyFundPositionDate { get; set; }
        public int? FInstBranchCode { get; set; }
        public string GlDetailAccCode { get; set; }
        public string FInstBranchName { get; set; }
        public decimal? BankFundCapital { get; set; }
        public decimal? BankFundRate { get; set; }
        public decimal? BankFundMarkUp { get; set; }
        public decimal? BankFundAccrualBasis { get; set; }
        public decimal? VmSno { get; set; }
        public decimal? BankMrpRateBaseRate { get; set; }
        public decimal? ReceiptAmount { get; set; }
        public decimal? PaymentAmount { get; set; }
        public int? BrokerCode { get; set; }
        public string BrokerName { get; set; }
        public string PaymentMode { get; set; }
        public string InstrumentName { get; set; }
        public int? RptSesstion { get; set; }
        public int? Sno { get; set; }
        public decimal? TotalReceipt { get; set; }
        public decimal? TotalPayment { get; set; }
        public decimal? TotalOtherBankReceipt { get; set; }
        public decimal? TotalOtherBankPayment { get; set; }
        public string Symbol { get; set; }
        public int? DailyFundPositionIsVerified { get; set; }
        public int? DailyFundPositionCreatedBy { get; set; }
        public DateTime? DailyFundPositionCreatedWhen { get; set; }
        public int? DailyFundPositionModifyBy { get; set; }
        public DateTime? DailyFundPositionModifyWhen { get; set; }
        public int? DailyFundPositionProcessNo { get; set; }
        public decimal DailyFundPositionSno { get; set; }
        public int? DailyFundPositionSbptype { get; set; }
    }
}
