using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsLoanDatum
    {
        public int LoanCode { get; set; }
        public int FundmasterCode { get; set; }
        public DateTime LoanDate { get; set; }
        public int BorrowerCode { get; set; }
        public string BorrowerName { get; set; }
        public int? LoanCycle { get; set; }
        public decimal? LoanPrincipal { get; set; }
        public int? LoanIsFunded { get; set; }
        public decimal? LoanGroupCode { get; set; }
        public string LoanGroupDescription { get; set; }
        public decimal LoanFacilityCode { get; set; }
        public string LoanFacilityDescription { get; set; }
        public int? LoanIsLocked { get; set; }
        public int? LoanCreatedby { get; set; }
        public DateTime? LoanCreatedwhen { get; set; }
        public int? LoanModifyby { get; set; }
        public DateTime? LoanModifywhen { get; set; }
    }
}
