using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsCategoryLimit
    {
        public int CatLimitCode { get; set; }
        public int CatCode { get; set; }
        public int CatType { get; set; }
        public int CatLimitValueType { get; set; }
        public decimal CatLimitValue { get; set; }
        public int CatLimitIsActive { get; set; }
        public int? CatLimitCreatedBy { get; set; }
        public DateTime? CatLimitCreatedWhen { get; set; }
    }
}
