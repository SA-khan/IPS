using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsSectorExposure
    {
        public int? SectorCode { get; set; }
        public DateTime? SectorExpDate { get; set; }
        public string SectorName { get; set; }
        public string FundName { get; set; }
        public string FundMasterName { get; set; }
        public decimal? PijiclAsfinvest { get; set; }
        public decimal? PijiclHftinvest { get; set; }
        public decimal? FundTotInvest { get; set; }
        public decimal? LimitUtiliz { get; set; }
        public string LimitStatus { get; set; }
        public decimal? AllocPijiclAsf { get; set; }
        public decimal? AllocPijiclHft { get; set; }
        public decimal? FundCapital { get; set; }
        public decimal? ShareSold { get; set; }
        public decimal? SectorExpModifiedBy { get; set; }
        public DateTime? SectorExpModifiedWhen { get; set; }
        public DateTime? SectorExpCreatedWhen { get; set; }
        public int? SectorExpCreatedBy { get; set; }
    }
}
