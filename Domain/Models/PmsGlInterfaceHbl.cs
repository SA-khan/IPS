using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsGlInterfaceHbl
    {
        public int? GroupId { get; set; }
        public string Status { get; set; }
        public string OutMsg { get; set; }
        public int? LedgerId { get; set; }
        public string JeSource { get; set; }
        public string JeCategory { get; set; }
        public string CurrencyCode { get; set; }
        public DateTime? AccountingDate { get; set; }
        public decimal? DrAmount { get; set; }
        public decimal? CrAmount { get; set; }
        public string Segment1 { get; set; }
        public string Segment2 { get; set; }
        public string Segment3 { get; set; }
        public string Segment4 { get; set; }
        public string Segment5 { get; set; }
        public string Segment6 { get; set; }
        public string Segment7 { get; set; }
        public string Segment8 { get; set; }
        public string Segment9 { get; set; }
        public string RefJournalName { get; set; }
        public string ExternalReference { get; set; }
        public string LineDescription { get; set; }
        public string LineRef1 { get; set; }
        public string LineRef2 { get; set; }
        public int? Cby { get; set; }
        public DateTime? Cdate { get; set; }
        public int? FundmasterCode { get; set; }
        public int? FundCode { get; set; }
    }
}
