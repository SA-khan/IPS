using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsDailyIndex
    {
        public DateTime IndicatorDate { get; set; }
        public int IndicatorCode { get; set; }
        public string IndicatorName { get; set; }
        public decimal? IndicatorPreviousIndex { get; set; }
        public decimal? IndicatorCurrentIndex { get; set; }
        public decimal? IndicatorChangePoint { get; set; }
        public decimal? IndicatorChangePersent { get; set; }
        public int? IndexCreatedBy { get; set; }
        public DateTime? IndexCreatedWhen { get; set; }
        public int? IndexModifiedBy { get; set; }
        public DateTime? IndexModifiedWhen { get; set; }
    }
}
