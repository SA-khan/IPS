using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsTrDealerLimit
    {
        public int UdlSno { get; set; }
        public int UserCode { get; set; }
        public int? DealerLimitCombination { get; set; }
        public decimal? UdlAmount { get; set; }
        public int? UdlIsActive { get; set; }
        public int? UdlUserLevel { get; set; }
        public DateTime? UdlIssueDate { get; set; }
        public DateTime? UdlExpDate { get; set; }
        public int? UdlCreatedBy { get; set; }
        public DateTime? UdlCreatedWhen { get; set; }
        public int? UdlModifiedBy { get; set; }
        public DateTime? UdlModifiedWhen { get; set; }
        public int? DealerLimitType { get; set; }
    }
}
