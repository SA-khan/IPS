using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsTaxType
    {
        public int TaxTypeCode { get; set; }
        public string TaxTypeName { get; set; }
        public string TaxTypeMnemonic { get; set; }
        public string TaxTypeDesc { get; set; }
    }
}
