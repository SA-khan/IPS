using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsMngFeeCustBenchMark
    {
        public int BnchMarkCode { get; set; }
        public int FundMasterCode { get; set; }
        public DateTime CustBnchmrkDateCommence { get; set; }
        public decimal CustBnchmrkRate { get; set; }
        public decimal CustBnchmrkMFee { get; set; }
        public DateTime? CustBnchmrkDateValidity { get; set; }
    }
}
