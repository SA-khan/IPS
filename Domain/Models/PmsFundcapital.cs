using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsFundcapital
    {
        public int FundCapCode { get; set; }
        public DateTime FundCapDate { get; set; }
        public int FundMasterCode { get; set; }
        public int? FundCapType { get; set; }
        public decimal? FundCapAmount { get; set; }
        public string FundCapDesc { get; set; }
        public byte? FundCapState { get; set; }
        public int? FInstTypeCode { get; set; }
        public int? FInstCode { get; set; }
        public int? FInstBranchCode { get; set; }
        public int? CashTypeCode { get; set; }
        public decimal? FundCapQuantity { get; set; }
        public DateTime? FundCapMaturityDate { get; set; }
        public int? FundCapReportType { get; set; }
        public int? FundCapAccuralMethod { get; set; }
    }
}
