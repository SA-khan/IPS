using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsProcessPortfolio
    {
        public int Sno { get; set; }
        public int FundMasterCode { get; set; }
        public string FundMasterName { get; set; }
        public DateTime DateMonth { get; set; }
        public decimal? Beginning { get; set; }
        public decimal? Contribution { get; set; }
        public decimal? Withdrawls { get; set; }
        public decimal? Closing { get; set; }
        public decimal? ChangeInNav { get; set; }
        public decimal? Cash { get; set; }
        public decimal? Mtbs { get; set; }
        public decimal? Ltbs { get; set; }
        public decimal? Stock { get; set; }
        public decimal? OpenEnd { get; set; }
        public string PortfolioYear { get; set; }
        public int? FundIsActive { get; set; }
        public int? PortfolioIsLocked { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedWhen { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedWhen { get; set; }
    }
}
