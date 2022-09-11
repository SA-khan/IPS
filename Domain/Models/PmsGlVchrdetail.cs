using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsGlVchrdetail
    {
        public decimal VmSno { get; set; }
        public int TransactionType { get; set; }
        public string VdCoCode { get; set; }
        public string VdVchrType { get; set; }
        public string VdYear { get; set; }
        public decimal VdVchrPer { get; set; }
        public string VdVchrNo { get; set; }
        public decimal VdTransNo { get; set; }
        public string VdAccCode { get; set; }
        public DateTime VdDt { get; set; }
        public string VdDtHij { get; set; }
        public string VdDesc { get; set; }
        public string VdDescArb { get; set; }
        public decimal VdDrAmt { get; set; }
        public decimal VdCrAmt { get; set; }
        public string VdRef { get; set; }
        public decimal VdAmtSetoff { get; set; }
        public string VdReconTag { get; set; }
        public DateTime? VdReconDt { get; set; }
        public string VdReconDtHij { get; set; }
        public string VdPstTag { get; set; }
        public string VdBankStno { get; set; }
        public string VdCostcntrCode { get; set; }
        public decimal? VdQuantity { get; set; }
        public string VdPartyCode { get; set; }
        public string VdCreatedby { get; set; }
        public DateTime? VdCreatedwhen { get; set; }
        public string VdModifiedby { get; set; }
        public DateTime? VdModifiedwhen { get; set; }
        public string VdVerified { get; set; }
        public string VdCurrCode { get; set; }
        public decimal? VdExchRate { get; set; }
        public string VdFctransTag { get; set; }
        public decimal VdDrRepcurr1 { get; set; }
        public decimal VdCrRepcurr1 { get; set; }
        public decimal VdDrRepcurr2 { get; set; }
        public decimal VdCrRepcurr2 { get; set; }
        public decimal VdDrRepcurr3 { get; set; }
        public decimal VdCrRepcurr3 { get; set; }
        public decimal VdDrRepcurr4 { get; set; }
        public decimal VdCrRepcurr4 { get; set; }
        public decimal VdDrRepcurr5 { get; set; }
        public decimal VdCrRepcurr5 { get; set; }
        public string VdRef1 { get; set; }
        public string VdRef2 { get; set; }
        public string VdRef3 { get; set; }
        public string VdSiteCode { get; set; }
        public decimal VdPacketRecvd { get; set; }
        public decimal? VdPacketSent { get; set; }
        public int? GlHeadEntityType { get; set; }
        public int? GlHeadAccType { get; set; }
        public int? GlDetailEntityCode { get; set; }
        public int? VdColtrlType { get; set; }
        public int? VdColtrlSubType { get; set; }
    }
}
