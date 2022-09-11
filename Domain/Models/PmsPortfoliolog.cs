using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsPortfoliolog
    {
        public int PortfoliologSno { get; set; }
        public int? FundCode { get; set; }
        public int FundmasterCode { get; set; }
        public int? TradinstCode { get; set; }
        public int? TradinsttypeCode { get; set; }
        public int? OrderCode { get; set; }
        public int? BrokerCode { get; set; }
        public int? OrderMode { get; set; }
        public string OrdexecDealtickno { get; set; }
        public string FundName { get; set; }
        public string FundmasterName { get; set; }
        public decimal? OrderBrokerrate { get; set; }
        public int? OrderBrokerratemode { get; set; }
        public DateTime? OrderDate { get; set; }
        public decimal? OrderQuantity { get; set; }
        public decimal? OrderAmount { get; set; }
        public string OrderRefno { get; set; }
        public int? ProductCode { get; set; }
        public decimal? OrdexecAmount { get; set; }
        public DateTime? OrdexecDate { get; set; }
        public decimal? OrdexecPrice { get; set; }
        public decimal? OrdexecTradeyield { get; set; }
        public string OrdexecReferenceno { get; set; }
        public string OrdexecCntpartyname { get; set; }
        public decimal? InvbondsFacevalue { get; set; }
        public string InvbondsName { get; set; }
        public int? InvbondsMaturityperiod { get; set; }
        public DateTime? InvbondsIssuedate { get; set; }
        public DateTime? InvbondsMaturitydate { get; set; }
        public int? InvbondsRedemptiontenor { get; set; }
        public decimal? SettdateAmount { get; set; }
        public decimal? SettdateQuantity { get; set; }
        public decimal? SettdateRate { get; set; }
        public DateTime? SettdateDate { get; set; }
        public decimal? SettdateAccruedinterest { get; set; }
        public decimal? SettdateNetamount { get; set; }
        public decimal? InvbondsCouponrateperannum { get; set; }
        public int? InvbondsAccrualbasis { get; set; }
        public DateTime? CouponDate { get; set; }
        public DateTime? CouponEnddate { get; set; }
        public DateTime? CpoupnNextdate { get; set; }
        public DateTime? QuarterStartdate { get; set; }
        public DateTime? QuarterEnddate { get; set; }
        public int? Accperday { get; set; }
        public int? Coupondays { get; set; }
        public int? Remainingcoupondays { get; set; }
        public int? Interestrecdays { get; set; }
        public decimal? Totalamortquarter { get; set; }
        public decimal? Totalbeforequartervalue { get; set; }
        public decimal? OrdexecInceptionprice { get; set; }
        public decimal? OrdexecInterestoutstanding { get; set; }
        public string OrdexecCfsTradeno { get; set; }
        public DateTime? CouponProjecteddate { get; set; }
        public string Primarydealer { get; set; }
        public int? Noofcoupons { get; set; }
        public int? Matdays { get; set; }
        public decimal? Commtax { get; set; }
        public DateTime? Previouscoupon { get; set; }
        public DateTime? Latestcoupon { get; set; }
        public decimal? Outstandingirr { get; set; }
        public decimal? Balanceirr { get; set; }
        public decimal? Dbltotalaccruedamt { get; set; }
        public decimal? Totalirrincome { get; set; }
        public decimal? Closingirr { get; set; }
        public decimal? Openingirr { get; set; }
        public decimal? Marketprice { get; set; }
        public decimal? Premdiscount { get; set; }
        public decimal? Interestoutstanding { get; set; }
        public decimal? Interestaccrued { get; set; }
        public decimal? Acdinterstonpur { get; set; }
        public decimal? Totalinterst { get; set; }
        public decimal? Interestreceived { get; set; }
        public decimal? Intersttotos { get; set; }
        public int? PortfoliologIsverified { get; set; }
        public DateTime? PortfoliologProcenddate { get; set; }
        public int? PortfoliologCreatedby { get; set; }
        public DateTime? PortfoliologCreatedwhen { get; set; }
        public int? Interestoutdays { get; set; }
        public int? Paramflag { get; set; }
        public int? InvbondsYears { get; set; }
    }
}
