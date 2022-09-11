using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsCountry
    {
        public int CounCode { get; set; }
        public int CurrCode { get; set; }
        public string CounName { get; set; }
        public string CounSymbol { get; set; }
    }
}
