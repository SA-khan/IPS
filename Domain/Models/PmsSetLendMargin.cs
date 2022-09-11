using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsSetLendMargin
    {
        public int LenMarCode { get; set; }
        public byte LenMarTranType { get; set; }
        public int FInstTypeCode { get; set; }
        public int FInstCode { get; set; }
        public int FundCode { get; set; }
        public decimal? LenMarPercent { get; set; }
        public decimal? LenMarAmount { get; set; }
        public int LenMarEntityType { get; set; }
        public DateTime? LenMarValidityDate { get; set; }
        public string LenMarDescription { get; set; }
        public DateTime? LenmarIssueDate { get; set; }
        public int? FundMasterCode { get; set; }
        public int? LenMarCancelState { get; set; }
        public DateTime? LenMarCancelDate { get; set; }
    }
}
