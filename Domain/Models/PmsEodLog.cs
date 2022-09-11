using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsEodLog
    {
        public int EodLogCode { get; set; }
        public int UserCode { get; set; }
        public int EodDetailSno { get; set; }
        public DateTime EodLogDate { get; set; }
        public decimal? EodLogDuration { get; set; }
        public DateTime? EodLogManhours { get; set; }
        public int? EodLogCreatedBy { get; set; }
        public DateTime? EodLogCreatedWhen { get; set; }
        public int? EodLogModifyBy { get; set; }
        public DateTime? EodLogModifyWhen { get; set; }
    }
}
