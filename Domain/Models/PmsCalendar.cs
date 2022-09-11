using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsCalendar
    {
        public DateTime? CalDate { get; set; }
        public int? CalYearCode { get; set; }
        public int? CalPeriodCode { get; set; }
        public int? CalHoliday { get; set; }
        public string CalDescription { get; set; }
    }
}
