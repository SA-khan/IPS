using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsInvCommOrdApp
    {
        public int InvCommAppCode { get; set; }
        public int InvCommAppType { get; set; }
        public DateTime InvCommAppDate { get; set; }
        public int? TradInstTypeCode { get; set; }
        public int? TradInstCode { get; set; }
        public int? FInstTypeCode { get; set; }
        public int? FInstCode { get; set; }
        public int? FInstBranchCode { get; set; }
        public int? CalYearCode { get; set; }
        public int? CalPeriodCode { get; set; }
        public decimal InvCommAppAmount { get; set; }
        public decimal InvCommAppQuantity { get; set; }
        public decimal? InvCommAppRate { get; set; }
        public int? InvCommAppCancelState { get; set; }
        public int? FundCode { get; set; }
        public int? InvCommAppDealDays { get; set; }
        public DateTime? InvCommAppDateValidity { get; set; }
        public DateTime? InvCommAppDateCancel { get; set; }
        public decimal? InvCommAppRateTo { get; set; }
        public decimal? InvCommAppYieldFrom { get; set; }
        public decimal? InvCommAppYieldTo { get; set; }

        public virtual PmsCalPeriod Cal { get; set; }
        public virtual PmsFund FundCodeNavigation { get; set; }
        public virtual PmsTradingInstrumentType TradInstTypeCodeNavigation { get; set; }
    }
}
