using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsPkrvtemplate
    {
        public int PkrvTempCode { get; set; }
        public int PkrvTempUpperBond { get; set; }
        public byte PkrvTempType { get; set; }
        public bool PkrvTempActive { get; set; }
    }
}
