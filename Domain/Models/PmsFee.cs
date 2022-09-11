using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsFee
    {
        public int? FundMasterCode { get; set; }
        public string FeeName { get; set; }
        public decimal? FeePercent { get; set; }
        public decimal? FeeAmount { get; set; }
        public DateTime? FeeUpdated { get; set; }

        public virtual PmsFundMaster FundMasterCodeNavigation { get; set; }
    }
}
