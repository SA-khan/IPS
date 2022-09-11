using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsPurSalRef
    {
        public string PsrefPurDealTickNo { get; set; }
        public string PsrefSalDealTickNo { get; set; }
        public decimal? PsrefQuantity { get; set; }
        public decimal? PsrefAmount { get; set; }
        public decimal? PsrefSalPrice { get; set; }
        public decimal? PsrefPurPrice { get; set; }
        public int? PsrefKnoffType { get; set; }
        public int? PsrefModifiedBy { get; set; }
        public DateTime? PsrefModifiedWhen { get; set; }
        public int? FundCode { get; set; }
        public int? TradInstTypeCode { get; set; }
        public int? TradInstCode { get; set; }
        public decimal? PsrefBalQty { get; set; }
        public DateTime? PsrefPurDate { get; set; }
    }
}
