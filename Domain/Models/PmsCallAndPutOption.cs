using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsCallAndPutOption
    {
        public int CpoptionCode { get; set; }
        public int TradInstTypeCode { get; set; }
        public int TradInstCode { get; set; }
        public int CpoptionType { get; set; }
        public int CpoptionMonths { get; set; }
        public decimal CpoptionRateInAmount { get; set; }
        public byte? CpoptionTimeSpan { get; set; }

        public virtual PmsTradingInstrumentType TradInstTypeCodeNavigation { get; set; }
    }
}
