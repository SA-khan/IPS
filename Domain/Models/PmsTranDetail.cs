using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsTranDetail
    {
        public decimal TranDetailCode { get; set; }
        public decimal TranMasterCode { get; set; }
        public int TranMasterType { get; set; }
        public DateTime TranDetailDate { get; set; }
        public decimal TranDetailAmount { get; set; }
        public decimal? TranDetailQuantity { get; set; }
        public int TranDetailType { get; set; }
        public int? FundCode { get; set; }
        public decimal? TranDetailPrice { get; set; }
        public byte? TranDetailState { get; set; }
        public decimal? TranDetailCarryingPrice { get; set; }
        public decimal? TranDetailTranQuantity { get; set; }
        public int? FInstBranchCode { get; set; }
        public DateTime? TranMasterEntProcDate { get; set; }
        public DateTime? TranMasterDelProcDate { get; set; }

        public virtual PmsTranMaster TranMaster { get; set; }
    }
}
