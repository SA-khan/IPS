using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsScoreRating
    {
        public decimal ScoreRatingScore { get; set; }
        public int ScoreRatingRating { get; set; }
        public int ScoreRatingEntityType { get; set; }
        public int ScoreRatingSubProduct { get; set; }
        public DateTime ScoreRatingDate { get; set; }
        public int? ScoreRatingModifyBy { get; set; }
        public DateTime? ScoreRatingModifyWhen { get; set; }
        public int? ScoreRatingCreatedBy { get; set; }
        public DateTime? ScoreRatingCreatedWhen { get; set; }
    }
}
