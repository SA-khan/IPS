using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsCalPeriod
    {
        public PmsCalPeriod()
        {
            PmsFoOrders = new HashSet<PmsFoOrder>();
            PmsInvCommOrdApps = new HashSet<PmsInvCommOrdApp>();
            PmsOrderExecs = new HashSet<PmsOrderExec>();
            PmsOrders = new HashSet<PmsOrder>();
            PmsSettlementDates = new HashSet<PmsSettlementDate>();
            PmsTranMasters = new HashSet<PmsTranMaster>();
        }

        public int CalYearCode { get; set; }
        public int CalPeriodCode { get; set; }
        public string CalPeriodName { get; set; }
        public DateTime CalPeriodEndDate { get; set; }
        public DateTime CalPeriodStartDate { get; set; }

        public virtual PmsCalYear CalYearCodeNavigation { get; set; }
        public virtual ICollection<PmsFoOrder> PmsFoOrders { get; set; }
        public virtual ICollection<PmsInvCommOrdApp> PmsInvCommOrdApps { get; set; }
        public virtual ICollection<PmsOrderExec> PmsOrderExecs { get; set; }
        public virtual ICollection<PmsOrder> PmsOrders { get; set; }
        public virtual ICollection<PmsSettlementDate> PmsSettlementDates { get; set; }
        public virtual ICollection<PmsTranMaster> PmsTranMasters { get; set; }
    }
}
