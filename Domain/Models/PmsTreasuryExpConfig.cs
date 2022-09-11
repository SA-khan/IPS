using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsTreasuryExpConfig
    {
        public int TreasuryExpSno { get; set; }
        public int TreasuryExpProduct { get; set; }
        public int TreasuryExpMode { get; set; }
        public int? TradInstTypeCode { get; set; }
        public int? SubProductCode { get; set; }
        public string TreasuryExpProductName { get; set; }
        public string TreasuryExpGroupby { get; set; }
        public int? TreasuryExpCreatedBy { get; set; }
        public DateTime? TreasuryExpCreatedWhen { get; set; }
        public int? TreasuryExpModifyBy { get; set; }
        public DateTime? TreasuryExpModifyWhen { get; set; }
        public int? TreasuryExpIsActive { get; set; }
        public string TreasuryExpGroupName { get; set; }
    }
}
