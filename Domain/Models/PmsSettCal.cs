using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsSettCal
    {
        public int SettModeCode { get; set; }
        public int MarketCode { get; set; }
        public int CalYearCode { get; set; }
        public int CalPeriodCode { get; set; }
        public DateTime TradeDate { get; set; }
        public DateTime SettCalSettDate { get; set; }
        public string SettCalDesc { get; set; }
    }
}
