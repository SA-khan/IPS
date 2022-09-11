using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsBankMrpDetail
    {
        public int BankMrpDetailSno { get; set; }
        public int FInstBranchCode { get; set; }
        public DateTime BankMrpDetailDate { get; set; }
        public int FundMasterCode { get; set; }
        public decimal BankFundCapital { get; set; }
        public decimal BankFundRate { get; set; }
        public decimal BankFundMarkUp { get; set; }
        public int BankFundAccrualBasis { get; set; }
        public int BankFundRateType { get; set; }
        public int? BankMrpDetailModifyBy { get; set; }
        public DateTime? BankMrpDetailModifyWhen { get; set; }
        public decimal? VmSno { get; set; }
    }
}
