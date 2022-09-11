using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsEquityTradeLog
    {
        public int NccCode { get; set; }
        public DateTime NccDate { get; set; }
        public string NccIniSysId { get; set; }
        public decimal? NccTranId { get; set; }
        public DateTime? NccTranDate { get; set; }
        public DateTime? NccOpenDate { get; set; }
        public string NccTicketNo { get; set; }
        public int? NccIniCmid { get; set; }
        public int? NccTrader { get; set; }
        public int? NccClientCode { get; set; }
        public string NccConfId { get; set; }
        public decimal? NccCounterId { get; set; }
        public string NccCounterTrader { get; set; }
        public string NccSecSysmol { get; set; }
        public string NccSecName { get; set; }
        public decimal? NccBuyQty { get; set; }
        public decimal? NccBuyRate { get; set; }
        public decimal? NccBuyAmount { get; set; }
        public decimal? NccSellQty { get; set; }
        public decimal? NccSellRate { get; set; }
        public decimal? NccSellAmount { get; set; }
        public string NccModule { get; set; }
        public int? NccSetteMode { get; set; }
        public string NccMarket { get; set; }
        public string NccStatus { get; set; }
        public string NccCfsticketNo { get; set; }
        public DateTime? NccCfsdate { get; set; }
        public DateTime? NccModfyidate { get; set; }
        public int? NccModifyBy { get; set; }
        public byte? NccProcessState { get; set; }
        public int? FundMasterCode { get; set; }
        public int? CfsBrokerCode { get; set; }
    }
}
