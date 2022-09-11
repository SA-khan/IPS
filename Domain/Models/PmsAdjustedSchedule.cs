using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsAdjustedSchedule
    {
        public int TradInstCode { get; set; }
        public int TradInstTypeCode { get; set; }
        public int CouponCode { get; set; }
        public DateTime OrdExecDate { get; set; }
        public decimal OrdExecQuantity { get; set; }
        public decimal AmortCouponDays { get; set; }
        public decimal AmortUrp { get; set; }
        public decimal AmortCost { get; set; }
        public decimal AmortUnamortPremPerUnit { get; set; }
        public int AmortDaysTillCertMat { get; set; }
        public decimal AmortAmortPerDay { get; set; }
        public decimal AmortCouponAmortPerDay { get; set; }
        public decimal AmortCouponAmort { get; set; }
        public decimal? AmortPrincipalPrem { get; set; }
        public decimal? AmortCpnMatAmt { get; set; }
        public decimal? AmortAccruedProfit { get; set; }
        public DateTime? CouponDate { get; set; }
        public decimal? AmortRepayment { get; set; }
        public DateTime AmortUpdateDate { get; set; }
        public int FundCode { get; set; }
        public decimal? AmortIrr { get; set; }
        public string InvBondsName { get; set; }
        public DateTime InvBondsMaturityDate { get; set; }
        public DateTime InvBondsIssueDate { get; set; }
        public decimal InvBondsCouponRatePerAnnum { get; set; }
        public int? InvBondsRedemptionTenor { get; set; }
        public decimal? SettDateAmount { get; set; }
        public decimal? SettDateQuantity { get; set; }
        public decimal SettDateRate { get; set; }
        public DateTime SettDateDate { get; set; }
        public decimal? SettDateNetAmount { get; set; }
        public decimal? SettDateAccruedInterest { get; set; }
        public decimal? SettDateBrokerCommission { get; set; }
        public decimal? OrdExecAmount { get; set; }
        public decimal OrdExecPrice { get; set; }
        public decimal? OrderExecYield { get; set; }
        public string OrdExecDealTickNo { get; set; }
        public decimal? OrdExecTradeYield { get; set; }
        public string OrdExecContractNo { get; set; }
        public string FundName { get; set; }
        public string FundMasterName { get; set; }
        public decimal? MovAvgQty { get; set; }
        public byte TransactionType { get; set; }
        public DateTime? TransactionDate { get; set; }
        public int? OrdExecCode { get; set; }
        public int? OrderCode { get; set; }
        public int AutoIncrement { get; set; }
    }
}
