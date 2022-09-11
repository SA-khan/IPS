using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsCreditRating
    {
        public int CrRatingCode { get; set; }
        public int CrRatCompCode { get; set; }
        public DateTime CrRatingDate { get; set; }
        public byte CrRatingType { get; set; }
        public int? TradInstTypeCode { get; set; }
        public int? FinstTypeCode { get; set; }
        public int? CrRatingEntityCode { get; set; }
        public string CrRatingRating { get; set; }
        public decimal? CrRatingScore { get; set; }
        public decimal? CrRatingModifyby { get; set; }
        public DateTime? CrRatingModifyWhen { get; set; }
    }
}
