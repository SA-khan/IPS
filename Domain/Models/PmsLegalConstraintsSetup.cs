using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsLegalConstraintsSetup
    {
        public int LegalConstCode { get; set; }
        public int FundMasterCode { get; set; }
        public decimal? LegalConstPaidupCapLmt { get; set; }
        public decimal? LegalConstShareMpvar { get; set; }
        public decimal? LegalConstPortfolioLmt { get; set; }
        public decimal? LegalConstIndivInvLmt { get; set; }
        public decimal? LegalConstGroupInvLmt { get; set; }
        public decimal? LegalConstListedSecInvLmt { get; set; }
        public decimal? LegalConstSectorInvLmt { get; set; }
        public decimal? LegalConstBorrowLmt { get; set; }
        public bool LegalConstCheckPaidupCapLmt { get; set; }
        public bool LegalConstCheckShareMpvar { get; set; }
        public bool LegalConstCheckPortfolioLmt { get; set; }
        public bool LegalConstCheckIndivInvLmt { get; set; }
        public bool LegalConstCheckGroupInvLmt { get; set; }
        public bool LegalConstCheckListSecInvLmt { get; set; }
        public bool LegalConstCheckSectorInvLmt { get; set; }
        public bool LegalConstCheckBorrowLmt { get; set; }
        public int? LegalConstShareCostBasis { get; set; }
        public decimal? LegalConstBrokerCommTax { get; set; }
        public bool? LegalConstCalcBrkComm { get; set; }
        public string LegalConstDesc { get; set; }
        public bool? LegalConstCheckRequireCvt { get; set; }
        public bool? LegalConstCheckSbpalert { get; set; }
        public decimal? LegalConstSbpinvLmt { get; set; }
        public decimal? LegalConstBrokerComm { get; set; }
        public bool? LegalConstCheckBrokerComm { get; set; }
        public decimal? LegalConstCloseEndFund { get; set; }
        public bool? LegalConstCheckCloseEndFund { get; set; }
        public decimal? LegalConstGroupInvLmtSec { get; set; }
        public bool? LegalConstCheckGroupInvLmtSec { get; set; }
        public decimal? LegalConstOutStanding { get; set; }
        public bool? LegalConstCheckOutStanding { get; set; }
        public bool? LegalConstCheckFreeFloatLmt { get; set; }
        public decimal? LegalConstFreeFloatLmt { get; set; }
    }
}
