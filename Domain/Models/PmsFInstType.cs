using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsFInstType
    {
        public PmsFInstType()
        {
            PmsFInstituions = new HashSet<PmsFInstituion>();
        }

        public int FInstTypeCode { get; set; }
        public string FInstTypeName { get; set; }
        public string FInstTypeDesc { get; set; }
        public int? FInstTypeCreatedBy { get; set; }
        public DateTime? FInstTypeCreatedWhen { get; set; }
        public int? FInstTypeModifiedBy { get; set; }
        public DateTime? FInstTypeModifiedWhen { get; set; }
        public int? FInstTypeIsAuthorized { get; set; }
        public string FInstTypeReason { get; set; }
        public int? FInstTypeAuthorizedBy { get; set; }
        public DateTime? FInstTypeAuthorizedWhen { get; set; }

        public virtual ICollection<PmsFInstituion> PmsFInstituions { get; set; }
    }
}
