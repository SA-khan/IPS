using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsDealTrack
    {
        public int DealTrackSNo { get; set; }
        public string FInstTranRefNo { get; set; }
        public int DealTrackStatus { get; set; }
        public int? DealTrackCreatedBy { get; set; }
        public DateTime? DealTrackCreatedWhen { get; set; }
        public int FundMasterCode { get; set; }
        public int FundCode { get; set; }
        public int? TradInstTypeCode { get; set; }
        public int? TranLogModule { get; set; }
    }
}
