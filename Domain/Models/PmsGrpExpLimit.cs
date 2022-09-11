using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsGrpExpLimit
    {
        public int GrpExpLimitCode { get; set; }
        public int FundmasterCode { get; set; }
        public DateTime GrpExpLimitDate { get; set; }
        public int? GrpExpLimitProduct { get; set; }
        public decimal? GrpExpLimitAmountLimit { get; set; }
        public decimal? GrpExpLimitAmountPercentage { get; set; }
        public int? GrpExpLimitBasis { get; set; }
        public int? GrpExpLimitIsConfiguraion { get; set; }
        public int? GrpExpLimitCreatedBy { get; set; }
        public DateTime? GrpExpLimitCreatedWhen { get; set; }
        public int? GrpExpLimitModifiedBy { get; set; }
        public DateTime? GrpExpLimitModifiedWhen { get; set; }
    }
}
