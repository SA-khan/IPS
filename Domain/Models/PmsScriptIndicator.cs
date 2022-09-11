using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsScriptIndicator
    {
        public int IndicatorCode { get; set; }
        public int TradInstCode { get; set; }
        public int TradInstTypeCode { get; set; }
        public byte? ScrptIndStatus { get; set; }
        public int? ScrptIndModifiedBy { get; set; }
        public DateTime? ScrptIndModifiedWhen { get; set; }
        public DateTime ScrptIndDate { get; set; }
        public int? ScrptIndCreatedBy { get; set; }
        public DateTime? ScrptIndCreatedWhen { get; set; }
    }
}
