using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsSecurityRtprice
    {
        public int RtSno { get; set; }
        public string RtMrkStats { get; set; }
        public string RtSecName { get; set; }
        public decimal? RtVolume { get; set; }
        public decimal? RtOpenRate { get; set; }
        public decimal? RtHighRate { get; set; }
        public decimal? DmpLowRate { get; set; }
        public decimal? RtCurrentRate { get; set; }
        public decimal? RtPriceChange { get; set; }
        public decimal? RtPercntChange { get; set; }
        public decimal? RtIndexWtage { get; set; }
        public decimal? RtIndexPoint { get; set; }
        public decimal? RtNoOfShare { get; set; }
        public decimal? RtMktCapital { get; set; }
        public DateTime? RtDate { get; set; }
    }
}
