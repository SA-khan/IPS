using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsSecurityDmprice
    {
        public DateTime DmpDate { get; set; }
        public int TradInstTypeCode { get; set; }
        public int TradInstCode { get; set; }
        public string DmpSecName { get; set; }
        public decimal? DmpHigh { get; set; }
        public decimal? DmpLow { get; set; }
        public decimal? DmpVolume { get; set; }
        public decimal? DmpPrevious { get; set; }
        public decimal? DmpPrice { get; set; }
        public decimal? DmpValuation { get; set; }
        public int? DmpState { get; set; }
        public decimal? DmpIndex { get; set; }
        public int? DmpMarket { get; set; }
        public DateTime? PkrvDate { get; set; }
        public string DmpTrade { get; set; }
        public decimal? DmpTradedPrice { get; set; }
        public string DmpProvisioning { get; set; }
        public decimal? DmpProvisioningPrice { get; set; }
        public int? DmpScripType { get; set; }
        public decimal? DmpKmi30Index { get; set; }
        public decimal? DmpKse100Index { get; set; }
        public decimal? DmpDuration { get; set; }
        public decimal? ModDuration { get; set; }
        public decimal? BpsPrice { get; set; }

        public virtual PmsTradingInstrumentType TradInstTypeCodeNavigation { get; set; }
    }
}
