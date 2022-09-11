using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsWfactivity
    {
        public int WfActivitySno { get; set; }
        public int ScreenCode { get; set; }
        public int? FundmasterCode { get; set; }
        public int? FundCode { get; set; }
        public DateTime? WfActivityDate { get; set; }
        public int? EntityType { get; set; }
        public int? EntityCode { get; set; }
        public string WfActivityReferenceNo { get; set; }
        public int? WorkFlowCode { get; set; }
        public int? WorkFlowTemplateSeq { get; set; }
        public int? WorkFlowAction { get; set; }
        public int? ModuleCode { get; set; }
        public int? WfActivityBy { get; set; }
        public DateTime? WfActivityWhen { get; set; }
        public string WfActivityReason { get; set; }
        public int? UserCode { get; set; }
    }
}
