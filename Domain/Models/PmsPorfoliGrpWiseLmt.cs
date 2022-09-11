using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsPorfoliGrpWiseLmt
    {
        public int PorfoliGrpWiseLmtSno { get; set; }
        public int FundmasterCode { get; set; }
        public DateTime PorfoliGrpWiseLmtDate { get; set; }
        public string PorfoliGrpWiseLmtFFlag { get; set; }
        public decimal? PorfoliGrpWiseLmtLimit { get; set; }
        public int? PorfoliGrpWiseLmtIsActive { get; set; }
        public int? PorfoliGrpWiseLmtCode { get; set; }
        public int? PorfoliGrpWiseLmtCreatedBy { get; set; }
        public DateTime? PorfoliGrpWiseLmtCreatedWhen { get; set; }
        public string PorfoliGrpWiseLmtFundMemonics { get; set; }
    }
}
