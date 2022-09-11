using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsGlParam
    {
        public byte GlParamCode { get; set; }
        public byte? GlParamIntegMode { get; set; }
        public byte? GlParamChangeTransfer { get; set; }
        public byte? GlParamAccrualPolicy { get; set; }
        public byte? GlParamVchrTransferState { get; set; }
        public short? GlParamAccrualSdays { get; set; }
        public short? GlParamAccrualEdays { get; set; }
        public byte? GlParamDateBasis { get; set; }
        public byte? GlParamCostCntrBasis { get; set; }
    }
}
