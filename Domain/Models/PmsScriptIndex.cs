using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsScriptIndex
    {
        public int IndexCode { get; set; }
        public int TradInstCode { get; set; }
        public int TradInstTypeCode { get; set; }
        public byte? ScrptIndexStatus { get; set; }
        public DateTime? ScrptIndexDate { get; set; }
        public int? ScrptIndexModifiedBy { get; set; }
        public string ScrptIndexModifiedWhen { get; set; }
    }
}
