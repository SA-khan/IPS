using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsScriptExecutor
    {
        public int ScrpExecSno { get; set; }
        public int ScrpExecType { get; set; }
        public int? ScrpExecLastScripNo { get; set; }
        public int? ScrpExecCurrentScriptNo { get; set; }
        public string ScrpExecComments { get; set; }
        public int? ScrpExecCreatedBy { get; set; }
        public DateTime? ScrpExecCreatedWhen { get; set; }
    }
}
