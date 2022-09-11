using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsProposhare
    {
        public int InstTypeCode { get; set; }
        public int InstCode { get; set; }
        public int FundCode { get; set; }
        public int FInstTypeCode { get; set; }
        public int FInstCode { get; set; }
        public int FInstBranchCode { get; set; }
        public DateTime ProposhareDate { get; set; }
        public decimal? ProposhareQuantity { get; set; }
        public byte? ProposhareType { get; set; }
        public decimal? ProposhareHolding { get; set; }
        public string ProposhareDesc { get; set; }
    }
}
