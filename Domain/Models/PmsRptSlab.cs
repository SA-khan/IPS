using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsRptSlab
    {
        public int RptslabId { get; set; }
        public int RptslabType { get; set; }
        public string RptslabTitle { get; set; }
        public int RptslabFormattype { get; set; }
        public int RptslabDays { get; set; }
        public int? RptslabCreatedby { get; set; }
        public DateTime? RptslabCreatedwhen { get; set; }
        public int? RptslabModifyby { get; set; }
        public DateTime? RptslabModifywhen { get; set; }
    }
}
