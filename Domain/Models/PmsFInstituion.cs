using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsFInstituion
    {
        public PmsFInstituion()
        {
            PmsFInstBranches = new HashSet<PmsFInstBranch>();
        }

        public int FInstCode { get; set; }
        public string FInstName { get; set; }
        public int FInstTypeCode { get; set; }
        public decimal? FInstDepositLimit { get; set; }
        public decimal? FInstRepoLimit { get; set; }
        public string FInstRating { get; set; }
        public string FInstDesc { get; set; }
        public byte? FInstSglorBank { get; set; }
        public string FInstBankAccNo { get; set; }
        public int? ShareCode { get; set; }
        public int? FInstZakatImplication { get; set; }
        public int? FInstMra { get; set; }
        public int? FinstCreatedBy { get; set; }
        public DateTime? FinstCreatedWhen { get; set; }
        public int? FinstModifiedBy { get; set; }
        public DateTime? FinstModifiedWhen { get; set; }
        public int? FinstIsAuthorized { get; set; }
        public string FinstReason { get; set; }
        public int? FinstAuthorizedBy { get; set; }
        public DateTime? FinstAuthorizedWhen { get; set; }
        public int? FinstIsRelatedParty { get; set; }

        public virtual PmsFInstType FInstTypeCodeNavigation { get; set; }
        public virtual ICollection<PmsFInstBranch> PmsFInstBranches { get; set; }
    }
}
