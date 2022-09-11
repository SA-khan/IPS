using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsCalYear
    {
        public PmsCalYear()
        {
            PmsCalPeriods = new HashSet<PmsCalPeriod>();
        }

        public int CalYearCode { get; set; }
        public string CalYearName { get; set; }
        public string CalYearDesc { get; set; }

        public virtual ICollection<PmsCalPeriod> PmsCalPeriods { get; set; }
    }
}
