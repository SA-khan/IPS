using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsLimitBreach
    {
        public int? LbCode { get; set; }
        public DateTime? LbProDate { get; set; }
        public string LbRptStatus { get; set; }
        public int? LbApprovalBy { get; set; }
        public DateTime? LbMarketDate { get; set; }
        public decimal? LbMarketRate { get; set; }
        public DateTime? TradeDate { get; set; }
        public decimal? MovavgQty { get; set; }
        public decimal? MovAvgAmtMov { get; set; }
        public string FundName { get; set; }
        public string FundMnemonic { get; set; }
        public string FundMasterName { get; set; }
        public string ShareName { get; set; }
        public DateTime? InvCommAppDate { get; set; }
        public decimal? InvCommAppAmount { get; set; }
        public int? LbCreatedBy { get; set; }
        public DateTime? LbCreatedWhen { get; set; }
        public int? LbModifyBy { get; set; }
        public DateTime? LbModifyWhen { get; set; }
        public int? FundMasterCode { get; set; }
    }
}
