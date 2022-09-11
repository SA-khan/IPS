using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsBrokerageRate
    {
        public int BrokerCode { get; set; }
        public int BrkRateType { get; set; }
        public int BrkRateTradeMode { get; set; }
        public int TradInstTypeCode { get; set; }
        public int BrkRateCode { get; set; }
        public decimal BrkRateMinPrice { get; set; }
        public decimal BrkRateMaxPrice { get; set; }
        public decimal? BrkRateRateInAmount { get; set; }
        public decimal? BrkRateRateInPercent { get; set; }
        public decimal? BrkRateCapCommission { get; set; }
        public decimal? BrkRateFloorCommission { get; set; }
        public int? OrderSubtype { get; set; }
        public int? BrkRateSlabType { get; set; }
        public int? BrkrateCreatedBy { get; set; }
        public DateTime? BrkrateCreatedWhen { get; set; }
        public int? BrkrateModifiedBy { get; set; }
        public DateTime? BrkrateModifiedWhen { get; set; }
        public int? BrkrateIsAuthorized { get; set; }
        public string BrkrateReason { get; set; }
        public int? BrkrateAuthorizedBy { get; set; }
        public DateTime? BrkrateAuthorizedWhen { get; set; }

        public virtual PmsBroker BrokerCodeNavigation { get; set; }
        public virtual PmsTradingInstrumentType TradInstTypeCodeNavigation { get; set; }
    }
}
