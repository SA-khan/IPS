using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsCashFlow
    {
        public int CfCode { get; set; }
        public decimal FinstTranCode { get; set; }
        public int FInstTranType { get; set; }
        public DateTime CfDateSettlement { get; set; }
        public DateTime? CfDateDelivery { get; set; }
        public decimal CfRate { get; set; }
        public decimal CfPrincipalRedeem { get; set; }
        public decimal CfAmount { get; set; }
        public decimal CfNetAmount { get; set; }
        public decimal CfBrokerCommission { get; set; }
        public decimal CfWhtaxBcom { get; set; }
        public byte CfState { get; set; }
        public string CfRefNo { get; set; }
        public byte? CfFlag { get; set; }
        public decimal? CfFixedAmt { get; set; }
        public decimal? CfFloatAmt { get; set; }
        public decimal? CfTotalFixedMrkup { get; set; }
        public decimal? CfTotalFloatMrkup { get; set; }
        public decimal? CfFixedMrkup { get; set; }
        public decimal? CfFloatMrkup { get; set; }
        public decimal? CfOutFixed { get; set; }
        public decimal? CfOutFloat { get; set; }
        public byte? CfTerm { get; set; }
        public decimal? CfPrincipalRedeemFloat { get; set; }
        public DateTime? CfActMaturityDate { get; set; }
        public decimal? CfWhtaxAmount { get; set; }
        public decimal? CfAvgPkrvRate { get; set; }
        public decimal? VmSno { get; set; }
        public int? CfVchrState { get; set; }
        public int? TransactionType { get; set; }
        public decimal? CfAvgYield { get; set; }
        public int? CfModifiedBy { get; set; }
        public DateTime? CfModifiedWhen { get; set; }
        public int? CfCreatedby { get; set; }
        public DateTime? CfCreatedWhen { get; set; }
        public int? CfEditCounter { get; set; }
        public int? CfRoInstCode { get; set; }
        public int? CfSettbank { get; set; }
        public DateTime? CfActReleaseDate { get; set; }
        public decimal? CfPenaltyRate { get; set; }
        public int? CfCouponNature { get; set; }
        public int? CfCouponMaturity { get; set; }
        public int? CfIsExtendMaturity { get; set; }
        public DateTime? CfAmtExtendDate { get; set; }
        public decimal? CfOutStandAmount { get; set; }
        public int? CfZakatenable { get; set; }
        public decimal? CfZakatamount { get; set; }
    }
}
