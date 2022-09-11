using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsBankMrpRatesDetail
    {
        public int BankMrpRateCode { get; set; }
        public int FInstBranchCode { get; set; }
        public int FundMasterCode { get; set; }
        public DateTime BankMrpRateDate { get; set; }
        public int BankMrpRateRateType { get; set; }
        public int? RateTemplCode { get; set; }
        public int? BankMrpRateAccrualBasis { get; set; }
        public decimal? BankMrpRateBaseRate { get; set; }
        public int? BankMrpTemplCode { get; set; }
        public int? BankMrpRateModifyBy { get; set; }
        public DateTime? BankMrpRateModifyWhen { get; set; }
    }
}
