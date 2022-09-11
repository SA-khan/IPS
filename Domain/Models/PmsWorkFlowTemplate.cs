using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsWorkFlowTemplate
    {
        public int WorkFlowCode { get; set; }
        public DateTime WorkFlowDate { get; set; }
        public string WorkFlowTemplateName { get; set; }
        public string WorkFlowTemplateDesc { get; set; }
        public int WorkFlowTemplateSeq { get; set; }
        public int? WorkFlowSequenceSkipIsAllowed { get; set; }
        public int ActorType { get; set; }
        public int ActorCode { get; set; }
        public int WorkFlowActionCode { get; set; }
        public int? WorkFlowTemplateCreatedBy { get; set; }
        public DateTime? WorkFlowTemplateCreatedWhen { get; set; }
        public int? WorkFlowTemplateModifiedBy { get; set; }
        public DateTime? WorkFlowTemplateModifiedWhen { get; set; }
    }
}
