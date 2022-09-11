using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsVchrAmountType
    {
        public PmsVchrAmountType()
        {
            PmsVchrFmtDetails = new HashSet<PmsVchrFmtDetail>();
        }

        public short VAmtTypeCode { get; set; }
        public string VAmtTypeName { get; set; }
        public string VAmtTypeMnemonic { get; set; }

        public virtual ICollection<PmsVchrFmtDetail> PmsVchrFmtDetails { get; set; }
    }
}
