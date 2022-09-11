using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsCouponRealisedDetail
    {
        public int CouponCode { get; set; }
        public int TradinstTypeCode { get; set; }
        public int TradInstCode { get; set; }
        public int FundMasterCode { get; set; }
        public DateTime? CrDate { get; set; }
        public int? FInstBranchCode { get; set; }
        public int? CrCreatedBy { get; set; }
        public DateTime? CrCreatedWhen { get; set; }
        public int? CrModifiedBy { get; set; }
        public DateTime? CrModifiedWhen { get; set; }
    }
}
