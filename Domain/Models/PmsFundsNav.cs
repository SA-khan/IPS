using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsFundsNav
    {
        public DateTime FundNavDate { get; set; }
        public int FundMasterCode { get; set; }
        public decimal? FundNavCapital { get; set; }
        public decimal? FundNavNav { get; set; }
        public decimal? FundNavUnits { get; set; }
        public decimal? FundNavTotalAssets { get; set; }
        public decimal? FundNavTotalLiabilities { get; set; }
        public decimal? FundNavAppDim { get; set; }
        public string FundNavDesc { get; set; }
        public int? FundNavUserCode { get; set; }
        public string FundNavUserName { get; set; }
        public int FundNavState { get; set; }
        public decimal? FundNavIndexKse { get; set; }
        public decimal? FundNavAdvances { get; set; }
        public decimal? FundNavFundingCost { get; set; }
        public decimal? FundNavTotalCapital { get; set; }
        public decimal? FundNavInvSec { get; set; }
        public decimal? FundNavComKpi1 { get; set; }
        public decimal? FundNavOffPrice { get; set; }
        public decimal? FundNavRedmpPrice { get; set; }

        public virtual PmsFundMaster FundMasterCodeNavigation { get; set; }
    }
}
