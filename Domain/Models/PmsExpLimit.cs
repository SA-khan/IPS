using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsExpLimit
    {
        public int ExpLimitCode { get; set; }
        public int ExpLimitType { get; set; }
        public int ExpLimitValueType { get; set; }
        public decimal ExpLimitValue { get; set; }
        public int? ExpLimitEntitycode { get; set; }
        public DateTime? ExpLimitDate { get; set; }
        public int? ExpLimitIsActive { get; set; }
        public int? ExpLimtCreatedBy { get; set; }
        public DateTime? ExpLimtCreatedWhen { get; set; }
        public int? ExpLimitModifiedBy { get; set; }
        public DateTime? ExpLimitModifiedWhen { get; set; }
    }
}
