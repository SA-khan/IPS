using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsSecurityRelease
    {
        public int RelCode { get; set; }
        public decimal UndSecCode { get; set; }
        public int InstTypeCode { get; set; }
        public int InstCode { get; set; }
        public decimal FInstTranCode { get; set; }
        public int FInstTranType { get; set; }
        public decimal RelQuantity { get; set; }
        public DateTime RelDate { get; set; }
        public decimal RelModifiedBy { get; set; }
        public DateTime RelModifiedWhen { get; set; }
    }
}
