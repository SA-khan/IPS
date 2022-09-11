using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsMmiannouncement
    {
        public int TradInstTypeCode { get; set; }
        public int TradInstCode { get; set; }
        public DateTime MmiAnnDate { get; set; }
        public int? MmiAnnNewCouponCode { get; set; }
        public int? MmiAnnOldCouponCode { get; set; }
        public string MmiAnnCreditRating { get; set; }
        public string MmiAnnRatingAgency { get; set; }

        public virtual PmsTradingInstrumentType TradInstTypeCodeNavigation { get; set; }
    }
}
