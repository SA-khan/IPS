using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsCrFinstFinStatTmpDtl
    {
        public int FInstTypeCode { get; set; }
        public int FInstCode { get; set; }
        public int CalYearCode { get; set; }
        public DateTime FinstFinStatTmpDtlDate { get; set; }
        public string FinstFinStatTempEnum { get; set; }
        public int? FinstFinStatTempHeadType { get; set; }
        public decimal? FinstFinStatTmpDtlValue { get; set; }
        public int? FinstFinStatTmpDtlCreatedBy { get; set; }
        public DateTime? FinstFinStatTmpDtlCreatedWhen { get; set; }
        public int? FinstFinStatTmpDtlModifyBy { get; set; }
        public DateTime? FinstFinStatTmpDtlModifyWhen { get; set; }
    }
}
