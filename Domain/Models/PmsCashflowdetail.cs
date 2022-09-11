using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsCashflowdetail
    {
        public int CfCode { get; set; }
        public int FinsttranCode { get; set; }
        public int FinsttranType { get; set; }
        public DateTime CfDatesettlement { get; set; }
        public decimal CfRate { get; set; }
        public decimal CfPrincipalredeem { get; set; }
        public decimal CfAmount { get; set; }
        public decimal? CfMarkup { get; set; }
    }
}
