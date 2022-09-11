using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsWorkFlowLog
    {
        public int WorkFlowSno { get; set; }
        public int WorkFlowCode { get; set; }
        public string WorkFlowName { get; set; }
        public string WorkFlowDesc { get; set; }
        public DateTime WorkFlowDate { get; set; }
        public int? WorkFlowIsActive { get; set; }
        public int? WorkFlowEntityCode { get; set; }
        public int? WorkFlowStages { get; set; }
        public int? WorkFlowCreatedBy { get; set; }
        public DateTime? WorkFlowCreatedWhen { get; set; }
        public int? WorkFlowModifiedBy { get; set; }
        public DateTime? WorkFlowModifiedWhen { get; set; }
    }
}
