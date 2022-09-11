using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsAmortScheduleQuarterly
    {
        public decimal? OrdExecCode { get; set; }
        public decimal? OrderCode { get; set; }
        public int TradInstCode { get; set; }
        public int TradInstTypeCode { get; set; }
        public DateTime CouponDate { get; set; }
        public DateTime OrdExecDate { get; set; }
        public decimal OrdExecQuantity { get; set; }
        public int AmortCouponDays { get; set; }
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
        public decimal? AmortRepayment { get; set; }
        public DateTime AmortUpdateDate { get; set; }
        public int CouponCode { get; set; }
        public int FundCode { get; set; }
        public decimal? AmortIrr { get; set; }
        public int AutoIncrement { get; set; }
    }
}
