using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsBorrowProduct
    {
        public int BrprodCode { get; set; }
        public int FInstTypeCode { get; set; }
        public int FInstCode { get; set; }
        public int FInstBranchCode { get; set; }
        public DateTime? BrprodIssueDate { get; set; }
        public DateTime? BrprodMaturityDate { get; set; }
        public decimal? BrprodAmount { get; set; }
        public DateTime? BrProdShutPeriod { get; set; }
        public int? RateTemplCode { get; set; }
        public int? RateTemplType { get; set; }
        public int? BrprodAccBasis { get; set; }
        public decimal? BrprodBaseRate { get; set; }
        public string BrprodName { get; set; }
    }
}
