using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsShareFinancing
    {
        public int FundMasterCode { get; set; }
        public int TradInstCode { get; set; }
        public int TradInstTypeCode { get; set; }
        public DateTime FinancingDate { get; set; }
        public DateTime? FinancingExpDate { get; set; }
        public decimal? FinancingAmount { get; set; }
        public byte? FinancingStatus { get; set; }
        public int? FinancingModifiedBy { get; set; }
        public DateTime? FinancingModifiedWhen { get; set; }
        public int? FinancingCreatedBy { get; set; }
        public DateTime? FinancingCreatedWhen { get; set; }
    }
}
