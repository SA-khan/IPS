using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsWorkFlowTempReport
    {
        public int WorkFlowTemReportCode { get; set; }
        public int WorkFlowCode { get; set; }
        public DateTime WorkFlowDate { get; set; }
        public int WorkFlowTemplateSeq { get; set; }
        public int WorkFlowReportCode { get; set; }
        public int? ActorType { get; set; }
        public int? ActorCode { get; set; }
        public int? WorkFlowActionCode { get; set; }
    }
}
