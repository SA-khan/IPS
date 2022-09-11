using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsExecptTranLog
    {
        public int ExecptTransLogCode { get; set; }
        public int UserCode { get; set; }
        public int EodLogCode { get; set; }
        public int? EodDetailSno { get; set; }
        public DateTime ExecptTransLogDate { get; set; }
        public int ExecptTransLogSource { get; set; }
        public string OrderRefNo { get; set; }
        public string OrdExecDealTickNo { get; set; }
        public string FInstTranRefNo { get; set; }
        public int? ExecptTransLogCreatedBy { get; set; }
        public DateTime? ExecptTransLogCreatedWhen { get; set; }
        public string ExecptTransLogModifyBy { get; set; }
        public DateTime? ExecptTransLogModifyWhen { get; set; }
        public int? ExecptTransLogMode { get; set; }
    }
}
