using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsGlVchrmaster
    {
        public decimal VmSno { get; set; }
        public int TransactionType { get; set; }
        public string VmCoCode { get; set; }
        public string VmVchrType { get; set; }
        public string VmYear { get; set; }
        public decimal VmPer { get; set; }
        public string VmNo { get; set; }
        public DateTime VmDt { get; set; }
        public string VmDtHij { get; set; }
        public string VmDesc { get; set; }
        public string VmDescArb { get; set; }
        public string VmAccruTag { get; set; }
        public string VmPstTag { get; set; }
        public string VmDeleted { get; set; }
        public string VmCreatedby { get; set; }
        public DateTime? VmCreatedwhen { get; set; }
        public string VmModifiedby { get; set; }
        public DateTime? VmModifiedwhen { get; set; }
        public string VmVerified { get; set; }
        public string VmDualcurrTag { get; set; }
        public string VmTransfertag { get; set; }
        public string VmSiteCode { get; set; }
        public decimal VmPacketRecvd { get; set; }
        public decimal? VmPacketSent { get; set; }
        public bool? VmTransfer { get; set; }
        public decimal? SettDateCode { get; set; }
        public int? SettDateType { get; set; }
        public DateTime? TranMasterDate { get; set; }
        public decimal? OrdExecCode { get; set; }
        public decimal? OrderCode { get; set; }
        public int? TradInstTypeCode { get; set; }
        public int? TradInstCode { get; set; }
        public decimal? FInstTranCode { get; set; }
        public int? FInstTranType { get; set; }
        public int? CouponCode { get; set; }
        public DateTime? ShareAnnDate { get; set; }
        public DateTime? ValuationDate { get; set; }
        public int? CpoptionCode { get; set; }
        public int? CpoptionType { get; set; }
        public int? FundCode { get; set; }
        public int? FeeCode { get; set; }
        public bool VmToBeReverse { get; set; }
        public byte? VmGlPosted { get; set; }
        public int? BrokerCode { get; set; }
        public short? ClearingCompCode { get; set; }
        public int? FundMasterCode { get; set; }
        public string OrdExecDealTickNo { get; set; }
        public int? FInstBranchCode { get; set; }
        public byte? OrderOnClearingSys { get; set; }
        public int? VmClearingParty { get; set; }
        public int? ProductCode { get; set; }
        public int? VmColtrlType { get; set; }
        public int? VmColtrlSubType { get; set; }
    }
}
