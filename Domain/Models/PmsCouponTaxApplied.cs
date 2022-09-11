using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsCouponTaxApplied
    {
        public int CouponCode { get; set; }
        public int TradInstTypeCode { get; set; }
        public int TradInstCode { get; set; }
        public string OrdExecDealTickNo { get; set; }
        public int CtaIsApplied { get; set; }
        public int? CtaCreatedBy { get; set; }
        public DateTime? CtaCreatedWhen { get; set; }
        public int? CtaModifiedBy { get; set; }
        public DateTime? CtaModifiedWhen { get; set; }
        public decimal? CtaAmount { get; set; }
    }
}
