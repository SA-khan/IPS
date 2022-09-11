using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsCfstradeLog
    {
        public int CfsCode { get; set; }
        public DateTime CfsDate { get; set; }
        public int FundMasterCode { get; set; }
        public int CfsFileType { get; set; }
        public string CfsSystemId { get; set; }
        public string CfsSymbol { get; set; }
        public string CfsBrokerCode { get; set; }
        public decimal? CfsOrderNo { get; set; }
        public string CfsOrderType { get; set; }
        public decimal? CfsTradeNo { get; set; }
        public int? CfsRelCode { get; set; }
        public DateTime? CfsTradeEntryDate { get; set; }
        public DateTime? CfsEffectiveDate { get; set; }
        public decimal? CfsExposureRate { get; set; }
        public decimal? CfsPremiumRate { get; set; }
        public int? CfsDays { get; set; }
        public decimal? CfsTradeQty { get; set; }
        public decimal? CfsGainRate { get; set; }
        public decimal? CfsPurPrice { get; set; }
        public decimal? CfsKatsTicketNo { get; set; }
        public string CfsClient { get; set; }
        public DateTime? CfsModfyidate { get; set; }
        public int? CfsModifyBy { get; set; }
        public byte? CfsProcessState { get; set; }
        public decimal? CfsPremiumPer { get; set; }
    }
}
