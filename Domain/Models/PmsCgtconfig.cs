using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsCgtconfig
    {
        public int CgtCode { get; set; }
        public int? CalYearCode { get; set; }
        public int? CgtYear { get; set; }
        public decimal? CgtTaxRate { get; set; }
        public decimal? CgtAdvRate { get; set; }
        public int? CgtSlabFrom { get; set; }
        public int? CgtSlabTo { get; set; }
        public DateTime? CgtModifiedWhen { get; set; }
        public int? CgtModifiedBy { get; set; }
        public DateTime CgtCreatedWhen { get; set; }
        public int? CgtCreatedBy { get; set; }
        public DateTime? CgtFromDate { get; set; }
        public DateTime? CgtToDate { get; set; }
        public int? CgtModuleType { get; set; }
        public int? CgtFundType { get; set; }
    }
}
