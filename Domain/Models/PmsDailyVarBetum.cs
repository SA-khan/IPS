using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsDailyVarBetum
    {
        public int DailyVarBetaSno { get; set; }
        public int DailyVarBetaType { get; set; }
        public DateTime DailyVarBetaProcessDate { get; set; }
        public int TradInstTypeCode { get; set; }
        public int TradinstCode { get; set; }
        public int IndicatorCode { get; set; }
        public DateTime IndicatorDate { get; set; }
        public decimal IndicatorChangePoint { get; set; }
        public decimal DailyVarBetaIndicatorLnvalue { get; set; }
        public decimal DmpPrice { get; set; }
        public decimal DailyVarBetaDmpLnvalue { get; set; }
        public decimal DailyVarBetaVar { get; set; }
        public decimal DailyVarBetaBeta { get; set; }
        public decimal DailyVarBetaStdDev { get; set; }
        public int? DailyVarBetaIsVerified { get; set; }
        public int? DailyVarBetaCreatedBy { get; set; }
        public DateTime? DailyVarBetaCreatedWhen { get; set; }
        public int? DailyVarBetaVerifiedBy { get; set; }
        public DateTime? DailyVarBetaVerifiedWhen { get; set; }
    }
}
