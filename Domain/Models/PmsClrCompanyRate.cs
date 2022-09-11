using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsClrCompanyRate
    {
        public short ClearingCompCode { get; set; }
        public short ClrCompRateTradeMode { get; set; }
        public int TradInstTypeCode { get; set; }
        public short ClrCompRateCode { get; set; }
        public decimal? ClrCompRateRateInAmount { get; set; }
        public decimal? ClrCompRateRateInPercent { get; set; }

        public virtual PmsClearingCompany ClearingCompCodeNavigation { get; set; }
        public virtual PmsTradingInstrumentType TradInstTypeCodeNavigation { get; set; }
    }
}
