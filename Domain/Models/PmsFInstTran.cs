using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsFInstTran
    {
        public decimal FInstTranCode { get; set; }
        public int FInstTranType { get; set; }
        public byte FinstTranMode { get; set; }
        public byte? FinstTranTerm { get; set; }
        public string FinstTranDesc { get; set; }
        public DateTime FInstTranDate { get; set; }
        public int FInstTypeCode { get; set; }
        public int FInstCode { get; set; }
        public int FInstBranchCode { get; set; }
        public decimal FInstTranAmount { get; set; }
        public decimal FInstTranInterest { get; set; }
        public int FundCode { get; set; }
        public int? BrokerCode { get; set; }
        public decimal? FInstTranBrokerRate { get; set; }
        public int? FInstTranBrokerRateMode { get; set; }
        public string FInstTranRefNo { get; set; }
        public int? FInstTranState { get; set; }
        public DateTime? InvCommAppDate { get; set; }
        public string FInstTranCrossRefNo { get; set; }
        public byte? FInstTranAccrualBasis { get; set; }
        public byte? FinstTranTermPayment { get; set; }
        public byte? FinstTranTermInterest { get; set; }
        public int? TradInstTypeCode { get; set; }
        public string FInstTranPreIpoName { get; set; }
        public byte? OrdExecStatus { get; set; }
        public int? FInstPartyTypeCode { get; set; }
        public int? FInstPartyCode { get; set; }
        public int? FInstPartyBranchCode { get; set; }
        public int? FinstTranDealTerm { get; set; }
        public int? FinstTranDealTermPro { get; set; }
        public decimal? FinstTranTotalExposure { get; set; }
        public int? FinsttranSettBank { get; set; }
        public string CrRatCompName { get; set; }
        public int? FundMasterCode { get; set; }
        public int? FinsttranCreatedby { get; set; }
        public DateTime? FinsttranCreatedWhen { get; set; }
        public int? FinsttranModifyby { get; set; }
        public DateTime? FinsttranModifyWhen { get; set; }
        public int? FinsttranEditCounter { get; set; }
        public int? FinstTranIsManualPkrv { get; set; }
        public DateTime? FInstTranPkrvdate { get; set; }
        public int? FinsttranSettThru { get; set; }
        public int? OrdDealerLimitFlag { get; set; }
    }
}
