using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsInvBond
    {
        public int InvBondsCode { get; set; }
        public int TradInstTypeCode { get; set; }
        public string InvBondsName { get; set; }
        public bool? InvBondsListed { get; set; }
        public decimal InvBondsFaceValue { get; set; }
        public int? InvBondsMaturityPeriod { get; set; }
        public DateTime InvBondsMaturityDate { get; set; }
        public DateTime InvBondsIssueDate { get; set; }
        public int InvBondsCouponsQty { get; set; }
        public decimal InvBondsCouponRatePerAnnum { get; set; }
        public int InvBondsShutPeriod { get; set; }
        public string InvBondsDesc { get; set; }
        public byte? InvBondsAccrualBasis { get; set; }
        public int? InvBondsRedemptionTenor { get; set; }
        public byte? InvBondsAmortMethod { get; set; }
        public byte? InvBondsAmortStartBasis { get; set; }
        public byte? InvBondsLotBasisSale { get; set; }
        public byte? InvbondsAmortbasis { get; set; }
        public byte? Invbonds1stCpnAccrBasis { get; set; }
        public string InvbondsSecCode { get; set; }
        public int ProductCode { get; set; }
        public int? ShareCode { get; set; }
        public decimal? InvBondAuctionYield { get; set; }
        public string InvBondAucNo { get; set; }
        public DateTime? InvBondAucDate { get; set; }
        public decimal? InvBondAcceptAmount { get; set; }
        public decimal? InvBondParticiAmount { get; set; }
        public int? InvBondsRedemptionType { get; set; }
        public int? InvBondsYears { get; set; }
        public int? InvbondsCreatedby { get; set; }
        public DateTime? InvbondsCreatedwhen { get; set; }
        public int? InvbondsModifiedby { get; set; }
        public DateTime? InvbondsModifiedwhen { get; set; }
        public int? InvbondsIsauthorized { get; set; }
        public string InvbondsReason { get; set; }
        public int? InvbondsAuthorizedby { get; set; }
        public DateTime? InvbondsAuthorizedwhen { get; set; }
        public byte? RateTemplType { get; set; }
        public string RateTemplSlabName { get; set; }
        public decimal? InvBondsCouponMinRate { get; set; }
        public decimal? InvBondsCouponMaxRate { get; set; }
        public decimal? InvBondsCouponCapRate { get; set; }
        public decimal? InvBondsCouponFloorRate { get; set; }
        public decimal? InvBondsBaseRate { get; set; }
        public int? InvBondsIsMatured { get; set; }

        public virtual PmsUserDefProduct PmsUserDefProduct { get; set; }
        public virtual PmsTradingInstrumentType TradInstTypeCodeNavigation { get; set; }
    }
}
