using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsOutstandingposition
    {
        public int OutstandingposSerialno { get; set; }
        public DateTime OutstandingposProcessdatetime { get; set; }
        public int FundmasterCode { get; set; }
        public string FundmasterName { get; set; }
        public int? FinsttranType { get; set; }
        public int? FinsttranMode { get; set; }
        public int? TradinsttypeCode { get; set; }
        public int? ProductCode { get; set; }
        public string OutstandingposName { get; set; }
        public int? OutstandingposRpttype { get; set; }
        public decimal? OutstandingposFacevalue { get; set; }
        public decimal? OutstandingposOutstandingvalu { get; set; }
        public decimal? OutstandingposProductvalue { get; set; }
        public decimal? OutstandingposWar { get; set; }
        public decimal? OutstandingposOutstandtot { get; set; }
        public decimal? OutstandingposProducttot { get; set; }
        public decimal? OutstandingposWartot { get; set; }
        public decimal? OutstandingposCommvalue { get; set; }
        public decimal? OutstandingposCommwar { get; set; }
        public decimal? OutstandingposCommproduct { get; set; }
        public decimal? OutstandingposCommvaluetot { get; set; }
        public decimal? OutstandingposCommwartot { get; set; }
        public decimal? OutstandingposCommproducttot { get; set; }
        public decimal? OutstandingposAverageperday { get; set; }
        public decimal? OutstandingposAvgperdaytotal { get; set; }
        public decimal? OutstandingposIncome { get; set; }
        public decimal? OutstandingposIncometotal { get; set; }
        public int? OutstandingposNoofdays { get; set; }
        public int? OutstandingposDaysinyear { get; set; }
        public int? OutstandingposTradinmonth { get; set; }
        public int? OutstandingposIsverify { get; set; }
        public int? OutstandingposCreatedby { get; set; }
        public DateTime? OutstandingposCreatedwhen { get; set; }
        public int? OutstandingposModifyby { get; set; }
        public DateTime? OutstandingposModifywhen { get; set; }
        public DateTime? OutstandingposGainlossdatetime { get; set; }
        public int? OutstandingposRptsection { get; set; }
        public int? OutstandingposTotal { get; set; }
        public int? Rptcategory { get; set; }
    }
}
