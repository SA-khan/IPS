using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsCategoryLimitConfig
    {
        public int CatLimitConfigCode { get; set; }
        public int CatType { get; set; }
        public int CatCode { get; set; }
        public int? EntityCode { get; set; }
        public int? CatLimitConfigIsActive { get; set; }
        public int? CatLimitConfigCreatedBy { get; set; }
        public DateTime? CatLimitConfigCreatedWhen { get; set; }
    }
}
