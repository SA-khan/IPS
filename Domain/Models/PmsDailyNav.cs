using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsDailyNav
    {
        public DateTime NavDate { get; set; }
        public int FundMasterCode { get; set; }
        public decimal? NavAmount { get; set; }
        public DateTime? NavCreatedWhen { get; set; }
        public byte? FundNavState { get; set; }
        public decimal? NavNavPercent { get; set; }
        public decimal? NavCustFee { get; set; }
        public decimal? NavIndexkse { get; set; }
        public decimal? NavOutstandingUnit { get; set; }
        public int? NavIsPosted { get; set; }
        public decimal? NavUnitsSold { get; set; }
        public decimal? NavUnitsRedeemed { get; set; }
        public decimal? NavTotalOutstandingUnits { get; set; }
        public byte? NavVerify { get; set; }
        public DateTime? NavUnitFetchingDate { get; set; }
    }
}
