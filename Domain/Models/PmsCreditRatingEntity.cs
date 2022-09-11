using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsCreditRatingEntity
    {
        public int CreditRatingEntitySno { get; set; }
        public int CrRatCompCode { get; set; }
        public int? CrRatingType { get; set; }
        public int RatingCode { get; set; }
        public int? CreditRatingEntityEntityType { get; set; }
        public int? CreditRatingEntityEntityCode { get; set; }
        public string CreditRatingEntityDesc { get; set; }
        public int CrRatingCode { get; set; }
    }
}
