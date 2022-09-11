using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsAssetType
    {
        public int AssetCode { get; set; }
        public DateTime AssetDate { get; set; }
        public int FundMasterCode { get; set; }
        public int? AssetType { get; set; }
        public decimal? CostOfInvestment { get; set; }
        public decimal? MarketValue { get; set; }
        public byte? AssetState { get; set; }
        public string AssetDesc { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedWhen { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedWhen { get; set; }
    }
}
