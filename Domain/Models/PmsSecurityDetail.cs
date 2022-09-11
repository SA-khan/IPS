using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsSecurityDetail
    {
        public int SecurityDetailSno { get; set; }
        public int TradinstTypeCode { get; set; }
        public int TradInstCode { get; set; }
        public DateTime? SecurityDetailEffDate { get; set; }
        public int? SecurityDetailAccrualBasis { get; set; }
        public int? SecurityDetailCreatedBy { get; set; }
        public DateTime? SecurityDetailCreatedWhen { get; set; }
        public int? SecurityDetailModifiedBy { get; set; }
        public DateTime? SecurityDetailModifiedWhen { get; set; }
    }
}
