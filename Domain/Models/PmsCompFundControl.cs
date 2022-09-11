using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsCompFundControl
    {
        public int CompFundCode { get; set; }
        public decimal? CompFundEntryPrice { get; set; }
        public decimal? CompFundExitPrice { get; set; }
        public decimal? CompFundYield { get; set; }
        public int? CompFundNature { get; set; }
        public DateTime? CompFundDate { get; set; }
        public string CompFundDesc { get; set; }
        public int TradInstTypeCode { get; set; }
        public int TradInstCode { get; set; }
        public int FundMasterCode { get; set; }
    }
}
