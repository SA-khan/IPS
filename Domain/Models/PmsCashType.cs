using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsCashType
    {
        public int CashTypeCode { get; set; }
        public int CashType { get; set; }
        public string CashTag { get; set; }
        public byte? CashFlag { get; set; }
        public byte? CashTypeValidityDate { get; set; }
        public byte? CashTypeQuantity { get; set; }
    }
}
