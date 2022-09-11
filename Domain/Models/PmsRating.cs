using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsRating
    {
        public int RatingCode { get; set; }
        public string RatingName { get; set; }
        public string RatingDesc { get; set; }
        public int? RatingModifiedBy { get; set; }
        public DateTime? RatingModifiedWhen { get; set; }
    }
}
