using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsFundTransfer
    {
        public int FundMasterCode { get; set; }
        public DateTime FundtransferIssueDate { get; set; }
        public DateTime FundtransferClearingeDate { get; set; }
        public string FundtransferSerialNo { get; set; }
        public string FundtransferFromBank { get; set; }
        public string FundtransferFromBankDesc { get; set; }
        public string FundtransferToBank { get; set; }
        public string FundtransferToBankDesc { get; set; }
        public decimal FundtransferTransferAmt { get; set; }
        public int? FundtransferType { get; set; }
        public int? FundtransferMode { get; set; }
        public int? FundtransferStatus { get; set; }
        public int? VmSno { get; set; }
        public int? FundtransferCreatedBy { get; set; }
        public DateTime? FundtransferCreatedWhen { get; set; }
        public int? FundtransferModifiedBy { get; set; }
        public DateTime? FundtransferModifiedWhen { get; set; }
        public int? FundTransferCode { get; set; }
    }
}
