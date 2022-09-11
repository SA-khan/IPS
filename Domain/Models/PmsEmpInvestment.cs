using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsEmpInvestment
    {
        public int EmpCode { get; set; }
        public int TradInstCode { get; set; }
        public int TradInstTypeCode { get; set; }
        public decimal EmpInvAmount { get; set; }
        public decimal EmpInvQuantity { get; set; }

        public virtual PmsEmployee EmpCodeNavigation { get; set; }
        public virtual PmsTradingInstrumentType TradInstTypeCodeNavigation { get; set; }
    }
}
