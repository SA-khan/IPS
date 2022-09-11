using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsRecurrFeeType
    {
        public int RecurrFeeTypeCode { get; set; }
        public string RecurrFeeTypeName { get; set; }
        public string RecurrFeeTypeDesc { get; set; }
        public int? VfmtMstrFmtCode { get; set; }
        public int? TransactionType { get; set; }
    }
}
