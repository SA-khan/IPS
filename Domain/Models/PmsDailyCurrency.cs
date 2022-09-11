using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsDailyCurrency
    {
        public DateTime DcurrDate { get; set; }
        public int CurrCode { get; set; }
        public decimal? DcurrBuying { get; set; }
        public decimal? DcurrSelling { get; set; }
        public int? DcurrBaseCurrency { get; set; }
    }
}
