using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsPolicyAndRegulation
    {
        public int PolicyCode { get; set; }
        public int FInstTypeCode { get; set; }
        public int FInstCode { get; set; }
        public decimal? PolicyAcquirePercentage { get; set; }
        public bool? PolicyCheckAcquirePercentage { get; set; }
        public DateTime? PolicyModfyidate { get; set; }
        public int? PolicyModifyBy { get; set; }
    }
}
