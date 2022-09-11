using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsCurrency
    {
        public int CurrCode { get; set; }
        public string CurrCountry { get; set; }
        public string CurrName { get; set; }
        public string CurrSymbol { get; set; }
        public string CurrSign { get; set; }
        public int? CurrBaseCurrency { get; set; }
    }
}
