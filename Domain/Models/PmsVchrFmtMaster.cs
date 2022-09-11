using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsVchrFmtMaster
    {
        public short VfmtMstrSno { get; set; }
        public short VfmtMstrFmtCode { get; set; }
        public short VfmtMstrCode { get; set; }
        public short? VfmtMstrSubCode { get; set; }
        public string VfmtMstrName { get; set; }
        public string VfmtMstrMnemonic { get; set; }
        public bool? VfmtMstrIsActive { get; set; }
        public byte? VfmtMstrGenBasis { get; set; }
        public byte? VfmtMstrDateBasis { get; set; }
        public string VfmtMstrDesc { get; set; }
        public string VfmtVchrFlag { get; set; }
        public string VfmtVchrType { get; set; }
        public int? VmftVchrTranType { get; set; }
        public byte? OrderOnClearingSys { get; set; }
        public string ProductCode { get; set; }
        public string VfmtMstrColtrlType { get; set; }
        public string VfmtMstrColtrlSubType { get; set; }
        public string FinsttranMode { get; set; }
    }
}
