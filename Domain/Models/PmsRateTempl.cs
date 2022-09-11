using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsRateTempl
    {
        public int RateTemplCode { get; set; }
        public byte RateTemplType { get; set; }
        public string RateTemplTypeName { get; set; }
        public string RateTemplSlabName { get; set; }
        public int? RatetemplPeriodDays { get; set; }
        public decimal? RateTemplNoofDays { get; set; }
    }
}
