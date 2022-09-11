using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsFundLimit
    {
        public int FundLmtEntityCode { get; set; }
        public int FundLmtEntityType { get; set; }
        public int FundMasterCode { get; set; }
        public decimal? FundLmtAmount { get; set; }
        public decimal? FundLmtPercentage { get; set; }
        public DateTime FundLmtModifiedDate { get; set; }
        public int? FundlmtCreatedBy { get; set; }
        public DateTime? FundlmtCreatedWhen { get; set; }
        public int? FundlmtModifiedBy { get; set; }
        public DateTime? FundlmtModifiedWhen { get; set; }
        public int? FundlmtIsAuthorized { get; set; }
        public string FundlmtReason { get; set; }
        public int? FundlmtAuthorizedBy { get; set; }
        public DateTime? FundlmtAuthorizedWhen { get; set; }
    }
}
