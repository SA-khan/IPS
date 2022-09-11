using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsMarket
    {
        public PmsMarket()
        {
            PmsFoOrders = new HashSet<PmsFoOrder>();
            PmsOrders = new HashSet<PmsOrder>();
        }

        public int MarketCode { get; set; }
        public string MarketName { get; set; }
        public string MarketDesc { get; set; }
        public int? MarketPriceReadUtility { get; set; }
        public int? MarketType { get; set; }
        public int? CounCode { get; set; }

        public virtual ICollection<PmsFoOrder> PmsFoOrders { get; set; }
        public virtual ICollection<PmsOrder> PmsOrders { get; set; }
    }
}
