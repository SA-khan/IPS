using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsCreditRatingCompany
    {
        public int CrRatCompCode { get; set; }
        public string CrRatCompName { get; set; }
        public string CrRatCompRating { get; set; }
        public string CrRatCompDesc { get; set; }
    }
}
