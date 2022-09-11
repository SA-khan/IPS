using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsUserDefProduct
    {
        public PmsUserDefProduct()
        {
            PmsInvBonds = new HashSet<PmsInvBond>();
            PmsTbills = new HashSet<PmsTbill>();
            PmsTfcs = new HashSet<PmsTfc>();
        }

        public int TradInstTypeCode { get; set; }
        public int ProductCode { get; set; }
        public string ProductName { get; set; }
        public string UserName { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? IsGovtBond { get; set; }

        public virtual ICollection<PmsInvBond> PmsInvBonds { get; set; }
        public virtual ICollection<PmsTbill> PmsTbills { get; set; }
        public virtual ICollection<PmsTfc> PmsTfcs { get; set; }
    }
}
