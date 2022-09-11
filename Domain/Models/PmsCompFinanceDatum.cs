using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsCompFinanceDatum
    {
        public int CompFinCode { get; set; }
        public int? CrRatCompCode { get; set; }
        public string CrRatCompRating { get; set; }
        public DateTime? CrRatCompDate { get; set; }
        public string CompFinRating { get; set; }
        public DateTime? CompFinRatingDate { get; set; }
        public decimal? CompFinEps { get; set; }
        public DateTime? CompFinEpsDate { get; set; }
        public decimal? CompFinNav { get; set; }
        public DateTime? CompFinNavDate { get; set; }
        public decimal? CompFinPe { get; set; }
        public DateTime? CompFinPeDate { get; set; }
        public string CompFinDesc { get; set; }
        public int TradInstTypeCode { get; set; }
        public int TradInstCode { get; set; }
        public decimal? CompFinVaR { get; set; }
        public DateTime? CompFinVaRDate { get; set; }
        public decimal? CompFinDps { get; set; }
        public DateTime? CompFinDpsDate { get; set; }
        public decimal? CompFinEquity { get; set; }
        public DateTime? CompFinEquityDate { get; set; }
    }
}
