using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsOrderExec
    {
        public PmsOrderExec()
        {
            PmsSettlementDates = new HashSet<PmsSettlementDate>();
        }

        public decimal OrdExecCode { get; set; }
        public decimal OrderCode { get; set; }
        public int TradInstCode { get; set; }
        public int TradInstTypeCode { get; set; }
        public int CustodianCode { get; set; }
        public string OrdExecDealTickNo { get; set; }
        public int CalYearCode { get; set; }
        public int SettModeCode { get; set; }
        public decimal? OrdExecQuantity { get; set; }
        public int CalPeriodCode { get; set; }
        public decimal? OrdExecAmount { get; set; }
        public DateTime OrdExecDate { get; set; }
        public decimal OrdExecPrice { get; set; }
        public decimal? OrdExecRateCot { get; set; }
        public decimal? OrdExecOtherCotcharges { get; set; }
        public decimal? OrdExecDividendRec { get; set; }
        public int OrdExecState { get; set; }
        public decimal? OrdExecTradeYield { get; set; }
        public decimal? OrdExecBrokerRate { get; set; }
        public int? OrdExecBrokerRateMode { get; set; }
        public int? TrusteeCode { get; set; }
        public string OrdExecSglaccountNo { get; set; }
        public string OrdExecCntPartyName { get; set; }
        public string OrdExecReferenceNo { get; set; }
        public string OrdExecAccNo { get; set; }
        public int? FundCode { get; set; }
        public decimal? OrdExecRptActualQty { get; set; }
        public string OrdExecTmpDealTicNo { get; set; }
        public bool? OrdExecReqAmortSch { get; set; }
        public byte? OrdExecGlPosted { get; set; }
        public short? OrdExecStateVoucher { get; set; }
        public string OrdExecContractNo { get; set; }
        public string OrdExecDocumentNo { get; set; }
        public int? OrderSubtype { get; set; }
        public decimal? OrderExecYield { get; set; }
        public bool? OrderExecIsAccrued { get; set; }
        public byte? OrdExecStatus { get; set; }
        public byte? OrderOnClearingSys { get; set; }
        public decimal? CfsTradeNo { get; set; }
        public decimal? OrdExecBrokerYield { get; set; }
        public int? OrdExecPrimDealer { get; set; }
        public int? OrdExecSettBank { get; set; }
        public decimal? OrdExecPriceSbp { get; set; }
        public int? FInstBranchCode { get; set; }
        public decimal? OrdExecInceptionPrice { get; set; }
        public decimal? OrdExecInterestOutStanding { get; set; }
        public int? OrdExecThirdParty { get; set; }
        public int? OrdexecCreatedby { get; set; }
        public DateTime? OrdexecCreatedWhen { get; set; }
        public int? OrdexecModifyby { get; set; }
        public DateTime? OrdexecModifyWhen { get; set; }
        public int? OrdexecEditCounter { get; set; }
        public int? OrderIpsbnkCode { get; set; }
        public decimal? OrdExecAmountCvt { get; set; }
        public bool? OrdExecVchrCreated { get; set; }
        public int? OrdExecSettThru { get; set; }

        public virtual PmsCalPeriod Cal { get; set; }
        public virtual PmsCustodian CustodianCodeNavigation { get; set; }
        public virtual PmsOrder PmsOrder { get; set; }
        public virtual PmsSettlementMode SettModeCodeNavigation { get; set; }
        public virtual PmsTrustee TrusteeCodeNavigation { get; set; }
        public virtual ICollection<PmsSettlementDate> PmsSettlementDates { get; set; }
    }
}
