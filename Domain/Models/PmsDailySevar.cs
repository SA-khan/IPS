using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsDailySevar
    {
        public DateTime VarDate { get; set; }
        public int TradInstTypeCode { get; set; }
        public int TradInstCode { get; set; }
        public string VarSymbol { get; set; }
        public decimal? VarValue { get; set; }
        public decimal? VarHairCut { get; set; }
        public decimal? VarWeekAvg { get; set; }
        public decimal? VarAccQty { get; set; }
        public decimal? VarHourAvgRate { get; set; }
        public decimal? VarFreefloat { get; set; }
    }
}
