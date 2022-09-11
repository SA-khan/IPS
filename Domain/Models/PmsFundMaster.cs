using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsFundMaster
    {
        public PmsFundMaster()
        {
            PmsCdsholdings = new HashSet<PmsCdsholding>();
            PmsCustomersAccounts = new HashSet<PmsCustomersAccount>();
            PmsFundsNavs = new HashSet<PmsFundsNav>();
        }

        public int FundMasterCode { get; set; }
        public string FundMasterName { get; set; }
        public string FundMasterDesc { get; set; }
        public string FundMasterMnemonic { get; set; }
        public DateTime? FundMasterModifiDate { get; set; }
        public string FundMasterGlcompCode { get; set; }
        public decimal? FundMasterCapital { get; set; }
        public string FundMasterGldbname { get; set; }
        public string FundMasterSiteCode { get; set; }
        public string FundMasterCostCenter { get; set; }
        public decimal? FundMasterSaleLoad { get; set; }
        public string FundMasterNavRptCode { get; set; }
        public decimal? FundMasterMfeePer { get; set; }
        public int? UhaFundMastercode { get; set; }
        public byte? FundmasterType { get; set; }
        public string FundmasterNcssid { get; set; }
        public string FundMasterAccNo { get; set; }
        public string FundMasterBankName { get; set; }
        public int? FInstTypeCode { get; set; }
        public int? FInstCode { get; set; }
        public int? FundMasterNavCalcType { get; set; }
        public int? FundMasterNavBalance { get; set; }
        public int? FInstBranchCode { get; set; }
        public int? FundMasterEodstatus { get; set; }
        public string FundmasterUin { get; set; }

        public virtual ICollection<PmsCdsholding> PmsCdsholdings { get; set; }
        public virtual ICollection<PmsCustomersAccount> PmsCustomersAccounts { get; set; }
        public virtual ICollection<PmsFundsNav> PmsFundsNavs { get; set; }
    }
}
