using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsFoOrder
    {
        public decimal OrderCode { get; set; }
        public int TradInstCode { get; set; }
        public int TradInstTypeCode { get; set; }
        public int? MarketCode { get; set; }
        public int CalYearCode { get; set; }
        public int CalPeriodCode { get; set; }
        public int? BrokerCode { get; set; }
        public int FundCode { get; set; }
        public DateTime? InvCommAppDate { get; set; }
        public decimal? OrderBrokerRate { get; set; }
        public int? OrderBrokerRateMode { get; set; }
        public int OrderMode { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal? OrderPriceLimit { get; set; }
        public decimal? OrderQuantity { get; set; }
        public decimal? OrderAmount { get; set; }
        public decimal? OrderActualQty { get; set; }
        public decimal? OrderActualAmt { get; set; }
        public DateTime OrderDateValidity { get; set; }
        public int OrderDateValidityMode { get; set; }
        public decimal? OrderUnExecAmount { get; set; }
        public decimal? OrderUnExecQuantity { get; set; }
        public int? OrderCancelled { get; set; }
        public decimal? OrderReferenceOrder { get; set; }
        public string OrderRefNo { get; set; }
        public DateTime? ShareAnnDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int? OrderSubtype { get; set; }
        public decimal? OrderFSalePrice { get; set; }
        public decimal? OrderFScriptCode { get; set; }
        public byte? OrderFState { get; set; }
        public decimal? OrderFBrokerRate { get; set; }
        public int? OrderFFundCode { get; set; }
        public decimal? OrderCvtfut { get; set; }
        public decimal? OrderCotratePer { get; set; }
        public decimal? CfsTradeNo { get; set; }
        public byte? OrderOnClearingSys { get; set; }
        public string OrderContraRefNo { get; set; }
        public DateTime? OrderCancelledDate { get; set; }
        public decimal? OrderFedfut { get; set; }
        public int? ProductCode { get; set; }
        public int? UserCode { get; set; }
        public int? SettModeCode { get; set; }
        public DateTime? SettDateDate { get; set; }
        public int? OrderState { get; set; }
        public int? FInstBranchCode { get; set; }
        public string OrderRemarks { get; set; }
        public string OrderUserDefNo { get; set; }
        public decimal? OrderYield { get; set; }
        public int? FInstBranchCode1 { get; set; }
        public int? OrderOpenCloseFlag { get; set; }

        public virtual PmsBroker BrokerCodeNavigation { get; set; }
        public virtual PmsCalPeriod Cal { get; set; }
        public virtual PmsMarket MarketCodeNavigation { get; set; }
        public virtual PmsTradingInstrumentType TradInstTypeCodeNavigation { get; set; }
    }
}
