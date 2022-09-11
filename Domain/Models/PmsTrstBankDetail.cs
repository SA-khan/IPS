using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsTrstBankDetail
    {
        public int FundMasterCode { get; set; }
        public int? FInstTypeCode { get; set; }
        public int? FInstCode { get; set; }
        public int EntityType { get; set; }
        public int EntityCode { get; set; }
        public string BranchAccountNo { get; set; }
        public string TrstBankDetailTfcCdsAccount { get; set; }
        public string TrstBankDetailGovtSecAccount { get; set; }
        public string TrstBankDetailEquitycdsAct { get; set; }
        public decimal? TrstBankDetailCreatedBy { get; set; }
        public DateTime? TrstBankDetailCreatedWhen { get; set; }
        public decimal? TrstBankDetailModifyBy { get; set; }
        public DateTime? TrstBankDetailModifyWhen { get; set; }
    }
}
