using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsTrustee
    {
        public PmsTrustee()
        {
            PmsOrderExecs = new HashSet<PmsOrderExec>();
            PmsTrstFees = new HashSet<PmsTrstFee>();
        }

        public int TrusteeCode { get; set; }
        public string TrusteeTitle { get; set; }
        public string TrusteeBank { get; set; }
        public string TrusteeBranch { get; set; }
        public string TrusteeAddress { get; set; }
        public string TrusteePhones { get; set; }
        public string TrusteeFaxes { get; set; }
        public string TrusteePostCode { get; set; }
        public string TrusteeContactPerson { get; set; }
        public bool TrusteeIsActive { get; set; }
        public string TrusteeAccNo { get; set; }

        public virtual ICollection<PmsOrderExec> PmsOrderExecs { get; set; }
        public virtual ICollection<PmsTrstFee> PmsTrstFees { get; set; }
    }
}
