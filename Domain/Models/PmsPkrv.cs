using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsPkrv
    {
        public decimal PkrvCode { get; set; }
        public int PkrvTempCode { get; set; }
        public DateTime PkrvDate { get; set; }
        public int BrokerCode { get; set; }
        public decimal? PkrvBrokerYield { get; set; }
        public decimal? PkrvAvgYield { get; set; }
    }
}
