using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsVchrFmtDetail
    {
        public byte VfmtDtlCode { get; set; }
        public short VfmtMstrSno { get; set; }
        public short VfmtMstrFmtCode { get; set; }
        public short VfmtMstrCode { get; set; }
        public short? VAmtTypeCode { get; set; }
        public int? GlHeadEntityType { get; set; }
        public int? GlHeadAccType { get; set; }
        public short? VfmtDtlAmountType { get; set; }
        public string VfmtDtlDesc { get; set; }

        public virtual PmsVchrAmountType VAmtTypeCodeNavigation { get; set; }
    }
}
