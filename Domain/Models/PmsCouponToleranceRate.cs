using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsCouponToleranceRate
    {
        public int CouponToleranceRateSno { get; set; }
        public DateTime CouponToleranceRateDate { get; set; }
        public int TradinstTypeCode { get; set; }
        public int TradinstCode { get; set; }
        public int? ProductCode { get; set; }
        public int? CouponToleranceRateIsActive { get; set; }
        public decimal? CouponTolRateRate { get; set; }
        public int? CouponTolRateCreatedBy { get; set; }
        public DateTime? CouponTolRateCreatedWhen { get; set; }
        public int? CouponTolRateModifiedBy { get; set; }
        public DateTime? CouponTolRateModifiedWhen { get; set; }
    }
}
