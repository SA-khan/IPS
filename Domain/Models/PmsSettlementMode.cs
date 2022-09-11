using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsSettlementMode
    {
        public PmsSettlementMode()
        {
            PmsOrderExecs = new HashSet<PmsOrderExec>();
        }

        public int SettModeCode { get; set; }
        public string SettModeName { get; set; }
        public int SettModeDays { get; set; }
        public string SettModeDescription { get; set; }

        public virtual ICollection<PmsOrderExec> PmsOrderExecs { get; set; }
    }
}
