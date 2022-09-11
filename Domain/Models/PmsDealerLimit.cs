using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsDealerLimit
    {
        public int DealerCode { get; set; }
        public DateTime DealerDate { get; set; }
        public int TradInstTypeCode { get; set; }
        public int FundMasterCode { get; set; }
        public int TradInstCode { get; set; }
        public int DealerLmoCode { get; set; }
        public string DealerLmoName { get; set; }
        public decimal? DealerAmtLimit { get; set; }
        public int? DealerCreatedBy { get; set; }
        public DateTime? DealerCreatedWhen { get; set; }
        public int? DealerModifiedBy { get; set; }
        public DateTime? DealerModifiedWhen { get; set; }
        public int? DealerIsActive { get; set; }
    }
}
