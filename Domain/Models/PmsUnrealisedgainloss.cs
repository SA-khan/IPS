using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsUnrealisedgainloss
    {
        public int UnrealisedglSno { get; set; }
        public int FundmasterCode { get; set; }
        public int FundCode { get; set; }
        public int TradinsttypeCode { get; set; }
        public int TradinstCode { get; set; }
        public string UnrealisedglType { get; set; }
        public string UnrealisedglValue { get; set; }
        public decimal? UnrealisedglNetvalue { get; set; }
        public string PsrefPurdealtickno { get; set; }
        public string PsrefSaldealtickno { get; set; }
        public DateTime UnrealisedglDate { get; set; }
        public int? UnrealisedglCreatedby { get; set; }
        public DateTime? UnrealisedglCreatedwhen { get; set; }
    }
}
