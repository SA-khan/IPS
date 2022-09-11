using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsEquityKatLog
    {
        public int KatCode { get; set; }
        public DateTime KatDate { get; set; }
        public int? FundMasterCode { get; set; }
        public int? BrokerCode { get; set; }
        public string KatIniSysId { get; set; }
        public decimal? KatTranId { get; set; }
        public DateTime? KatTranDate { get; set; }
        public string KatTicketNo { get; set; }
        public int? KatTrader { get; set; }
        public int? KatClientCode { get; set; }
        public string KatCounterTrader { get; set; }
        public string KatSecSysmol { get; set; }
        public string KatSecName { get; set; }
        public decimal? KatBuyQty { get; set; }
        public decimal? KatBuyRate { get; set; }
        public decimal? KatBuyAmount { get; set; }
        public decimal? KatSellQty { get; set; }
        public decimal? KatSellRate { get; set; }
        public decimal? KatSellAmount { get; set; }
        public decimal? KatExecutedQty { get; set; }
        public decimal? KatOutstandingQty { get; set; }
        public decimal? KatGrossAmount { get; set; }
        public decimal? KatOrderQty { get; set; }
        public string KatModule { get; set; }
        public int? KatSetteMode { get; set; }
        public string KatMarket { get; set; }
        public string KatStatus { get; set; }
        public DateTime? KatCreatedDate { get; set; }
        public int? KatCreatedBy { get; set; }
        public DateTime? KatModfyiDate { get; set; }
        public int? KatModifyBy { get; set; }
        public byte? KatProcessState { get; set; }
    }
}
