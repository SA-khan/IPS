using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsPortfolioLimit
    {
        public int? AssetmoduleSno { get; set; }
        public int? AssetmoduleCode { get; set; }
        public int? AssetTypeCode { get; set; }
        public int? AssetallocCode { get; set; }
        public DateTime? AssetallocDate { get; set; }
        public decimal? AssetallocAmountLimit { get; set; }
        public decimal? AssetallocLimitPercentage { get; set; }
        public decimal? AssetValue { get; set; }
        public string AssetmoduleGroupby { get; set; }
        public int? Flag { get; set; }
        public string AssetmoduleName { get; set; }
        public decimal? FundNavNav { get; set; }
        public DateTime? ExpDate { get; set; }
        public int? ExpModifiedBy { get; set; }
        public DateTime? ExpModifiedWhen { get; set; }
        public int? ExpCreatedBy { get; set; }
        public DateTime? ExpCreatedWhen { get; set; }
    }
}
