using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsClearingCompany
    {
        public PmsClearingCompany()
        {
            PmsClrCompanyRates = new HashSet<PmsClrCompanyRate>();
        }

        public short ClearingCompCode { get; set; }
        public string ClearingCompName { get; set; }
        public string ClearingCompMnemonic { get; set; }
        public bool? ClearingCompIsActive { get; set; }
        public int? FInstBranchCode { get; set; }
        public string ClearingCompPhone { get; set; }
        public string ClearingCompFax { get; set; }
        public string ClearingCompEmail { get; set; }
        public string ClearingCompAddress { get; set; }
        public string ClearingCompDesc { get; set; }

        public virtual ICollection<PmsClrCompanyRate> PmsClrCompanyRates { get; set; }
    }
}
