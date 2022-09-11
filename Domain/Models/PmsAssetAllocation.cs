using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsAssetAllocation
    {
        public int AssetallocCode { get; set; }
        public int AssetmoduleSno { get; set; }
        public int AssetTypeCode { get; set; }
        public int AssetmoduleCode { get; set; }
        public int FundMasterCode { get; set; }
        public DateTime AssetallocDate { get; set; }
        public decimal? AssetallocAmountLimit { get; set; }
        public decimal? AssetallocLimitPercentage { get; set; }
        public int? AssetallocCreatedby { get; set; }
        public DateTime? AssetallocCreatedWhen { get; set; }
        public int? AssetallocModifyby { get; set; }
        public DateTime? AssetallocModifyWhen { get; set; }
        public int? AssetallocIsAlco { get; set; }
        public int? FundCode { get; set; }
        public int AssetallocSno { get; set; }
    }
}
