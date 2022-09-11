using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsCoi
    {
        public int CoiCode { get; set; }
        public int ShareCode { get; set; }
        public int TradInstTypeCode { get; set; }
        public string CoiName { get; set; }
        public bool? CoiListed { get; set; }
        public DateTime CoiIssueDate { get; set; }
        public DateTime CoiMaturityDate { get; set; }
        public int CoiMaturityPeriod { get; set; }
        public int CoiCouponsQty { get; set; }
        public decimal CoiCouponRatePerAnnum { get; set; }
        public decimal CoiFaceValue { get; set; }
        public int? FundCode { get; set; }
        public int? BrokerCode { get; set; }
        public decimal? CoiBrokerRate { get; set; }
        public int? CoiBrokerRateMode { get; set; }
        public decimal? CoiBrokerage { get; set; }
        public string CoiTrustee { get; set; }
        public string CoiTransactionType { get; set; }
        public string CoiCounterParty { get; set; }
        public DateTime? CoiChkDeliveryDate { get; set; }
        public byte? CoiAccrualBasis { get; set; }
        public int FInstBranchCode { get; set; }
        public int CoiDaysType { get; set; }
        public DateTime? CoiPlacedate { get; set; }
        public int FInstTypeCode { get; set; }
        public int FInstCode { get; set; }

        public virtual PmsBroker BrokerCodeNavigation { get; set; }
        public virtual PmsFund FundCodeNavigation { get; set; }
        public virtual PmsShare ShareCodeNavigation { get; set; }
        public virtual PmsTradingInstrumentType TradInstTypeCodeNavigation { get; set; }
    }
}
