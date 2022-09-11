using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsApproveTradingLimit
    {
        public int FundMasterCode { get; set; }
        public DateTime AppTradLimitDate { get; set; }
        public decimal AppTradLimitLimit { get; set; }
        public DateTime? AppTradLimitExpDate { get; set; }
        public byte? AppTradLimitStatus { get; set; }
        public int? AppTradLimitModifiedBy { get; set; }
        public DateTime? AppTradLimitModifiedWhen { get; set; }
        public int? AppTradLimitCreatedBy { get; set; }
        public DateTime? AppTradLimitCreatedWhen { get; set; }
    }
}
