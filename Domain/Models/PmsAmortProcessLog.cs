using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsAmortProcessLog
    {
        public string OrdExecDealTickNo { get; set; }
        public DateTime AmortProcessDate { get; set; }
        public int? AmortCreatedBy { get; set; }
        public DateTime? AmortCreatedWhen { get; set; }
        public int? AmortModifyBy { get; set; }
        public DateTime? AmortModifyWhen { get; set; }
    }
}
