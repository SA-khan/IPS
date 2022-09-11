using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsCertificate
    {
        public int CertCode { get; set; }
        public int TradInstTypeCode { get; set; }
        public string CertNo { get; set; }
        public string CertName { get; set; }
        public DateTime CertIssueDate { get; set; }
        public DateTime CertMaturityDate { get; set; }
        public decimal CertAmount { get; set; }
        public int? CertBranchCode { get; set; }
        public bool? CertIssuance { get; set; }
        public int? CertRollOver { get; set; }
        public int? CertYears { get; set; }

        public virtual PmsTradingInstrumentType TradInstTypeCodeNavigation { get; set; }
    }
}
