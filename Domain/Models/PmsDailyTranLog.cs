using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsDailyTranLog
    {
        public int TranLogCode { get; set; }
        public int TranLogSno { get; set; }
        public DateTime TranLogDate { get; set; }
        public int TranLogModule { get; set; }
        public string TranLogDealTickNo { get; set; }
        public DateTime? TranLogInitialDate { get; set; }
        public DateTime? TranLogDealDate { get; set; }
        public DateTime? TranLogSettlementDate { get; set; }
        public int? FundmasterCode { get; set; }
        public int? FundCode { get; set; }
        public int? BrokerCode { get; set; }
        public int? TranLogCntrParty { get; set; }
        public int? TranLogSettBank { get; set; }
        public decimal? OrdExecTradeYield { get; set; }
        public decimal? OrdExecQuantity { get; set; }
        public decimal? OrdExecAmount { get; set; }
        public decimal? OrdExecPrice { get; set; }
        public decimal? SettDateAccruedInterest { get; set; }
        public decimal? SettDateBrokerCommission { get; set; }
        public decimal? SettDateNetAmount { get; set; }
        public int? TradInstTypeCode { get; set; }
        public int? TradInstCode { get; set; }
        public string PsrefPurDealTickNo { get; set; }
        public decimal? PsrefQuantity { get; set; }
        public decimal? PsrefAmount { get; set; }
        public decimal? PsrefPurPrice { get; set; }
        public int? FInstTranType { get; set; }
        public int? FInstTranCode { get; set; }
        public int? FinstTranMode { get; set; }
        public decimal? FInstTranAmount { get; set; }
        public decimal? FInstTranInterest { get; set; }
        public decimal? TranLogMarkup { get; set; }
        public decimal? FInstTranBrokerRate { get; set; }
        public decimal? TranLogMatAmount { get; set; }
        public decimal? FinstTranPrice1 { get; set; }
        public decimal? FinstTranPrice2 { get; set; }
        public decimal? UndSecAmount { get; set; }
        public string OrdExecDealTickNo { get; set; }
        public int? TranLogState { get; set; }
        public int? TranLogModifiedBy { get; set; }
        public DateTime? TranLogModifiedWhen { get; set; }
        public int? ProductCode { get; set; }
        public decimal? OrderBrokerRate { get; set; }
        public int? ActLogMasNo { get; set; }
        public int OrderSubType { get; set; }
        public int CalYearCode { get; set; }
        public int CalPeriodCode { get; set; }
        public int OrderBrokerRateMode { get; set; }
        public int OrderDateValidityMode { get; set; }
        public int MarketCode { get; set; }
        public int SettModeCode { get; set; }
        public int OrderOnClearingSys { get; set; }
        public int OrderCode { get; set; }
        public string TrusteeCode { get; set; }
        public int ShareType { get; set; }
        public int? OrdDealerLimitFlag { get; set; }
        public int? WorkFlowActionCode { get; set; }
    }
}
