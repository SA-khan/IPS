using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsDealRate
    {
        public int DealRatesCode { get; set; }
        public decimal FinstTranCode { get; set; }
        public int FinstTranType { get; set; }
        public DateTime DealRatesAccDate { get; set; }
        public int? RateTemplCode { get; set; }
        public byte? RateTemplType { get; set; }
        public byte? DealRatesState { get; set; }
        public decimal? DealRatesFixedRate { get; set; }
        public byte? DealRatesAccBasis { get; set; }
        public decimal? DealRatesBaseRate { get; set; }
        public decimal? VmSno { get; set; }
        public int? TransactionType { get; set; }
        public DateTime? DealRatesApplDate { get; set; }
        public decimal? DealRatesAccRate { get; set; }
        public byte? DealRatesRecursiveRate { get; set; }
        public int? DealRatesVchrState { get; set; }
    }
}
