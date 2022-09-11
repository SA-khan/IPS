using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsCoupon
    {
        public int CouponCode { get; set; }
        public int TradInstTypeCode { get; set; }
        public int TradInstCode { get; set; }
        public decimal CouponRates { get; set; }
        public decimal CouponPrincipalRedeem { get; set; }
        public DateTime CouponDate { get; set; }
        public int CouponRateType { get; set; }
        public decimal CouponZakat { get; set; }
        public int CouponState { get; set; }
        public byte? CouponUpdate { get; set; }
        public decimal? CouponSpreadRate { get; set; }
        public int? CouponIsLinked { get; set; }
        public int? CouponSuspended { get; set; }
        public int? CouponMatpayrealisedType { get; set; }
        public DateTime? CouponMatpayrealised { get; set; }
        public string CouponMatfundMaster { get; set; }
        public string CouponMatsettBank { get; set; }
        public int? CouponCreatedBy { get; set; }
        public DateTime? CouponCreatedWhen { get; set; }
        public int? CouponModifiedBy { get; set; }
        public DateTime? CouponModifiedWhen { get; set; }

        public virtual PmsTradingInstrumentType TradInstTypeCodeNavigation { get; set; }
    }
}
