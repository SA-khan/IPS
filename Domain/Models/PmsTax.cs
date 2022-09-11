using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsTax
    {
        public int TaxCode { get; set; }
        public int TaxTypeCode { get; set; }
        public DateTime TaxDateCommence { get; set; }
        public int? BrokerCode { get; set; }
        public int? FundMasterCode { get; set; }
        public int? TradInstTypeCode { get; set; }
        public int? OrderMode { get; set; }
        public decimal? TaxInPercent { get; set; }
        public decimal? TaxInAmount { get; set; }
        public byte? TaxIsApplicable { get; set; }
        public DateTime? TaxDateModified { get; set; }
        public int? FundCode { get; set; }
        public int? FInstTypeCode { get; set; }
        public int? FInstCode { get; set; }
        public int? FInstBranchCode { get; set; }
        public DateTime? TaxDateExpiry { get; set; }
        public int? EntityCode { get; set; }
    }
}
