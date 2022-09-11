using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsUnderlyingSec
    {
        public decimal UndSecCode { get; set; }
        public int InstTypeCode { get; set; }
        public int InstCode { get; set; }
        public decimal? OrdExecCode { get; set; }
        public decimal? OrderCode { get; set; }
        public int? TradInstTypeCode { get; set; }
        public int? TradInstCode { get; set; }
        public DateTime? ShareAnnDate { get; set; }
        public decimal? FInstTranCode { get; set; }
        public int? FInstTranType { get; set; }
        public int? FundCode { get; set; }
        public decimal UndSecQuantity { get; set; }
        public decimal UndSecAmount { get; set; }
        public decimal? UndSecBaseRate { get; set; }
        public int UndSecState { get; set; }
        public decimal? UndSecMarketPrice { get; set; }
        public DateTime? UndSecPledgedDate { get; set; }
        public string OrdExecDealTickNo { get; set; }
        public DateTime? UndSecReleasedDate { get; set; }
        public DateTime? UndSecDmpdate { get; set; }
        public decimal? UndSecMarginPercent { get; set; }
        public int UndSecInstType { get; set; }
        public decimal? UndSecRelQuantity { get; set; }
        public int? UndSecUnownedSecurity { get; set; }
        public int? ProductCode { get; set; }
    }
}
