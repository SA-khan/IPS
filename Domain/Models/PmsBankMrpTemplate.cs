using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsBankMrpTemplate
    {
        public int BankMrpTemplCode { get; set; }
        public decimal BankMrpTemplFromValue { get; set; }
        public decimal BankMrpTemplToValue { get; set; }
        public decimal? BankMrpTemplFlatRate { get; set; }
        public int? BankMrpTemplModifyBy { get; set; }
        public DateTime? BankMrpTemplModifyWhen { get; set; }
    }
}
