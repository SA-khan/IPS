using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsParam
    {
        public int ParamCode { get; set; }
        public int? TradInstTypeCode { get; set; }
        public int? ProductCode { get; set; }
        public int? FundMasterCode { get; set; }
        public int? ParamSalKnOfType { get; set; }
        public bool? ParamInvMovement { get; set; }
        public DateTime? ParamDtOfCommence { get; set; }
        public DateTime? ParamDtOfExpiry { get; set; }
        public string ParamDesc { get; set; }
        public int? ParamCreatedBy { get; set; }
        public DateTime? ParamCreatedWhen { get; set; }
        public int? ParamModifiedBy { get; set; }
        public DateTime? ParamModifiedWhen { get; set; }
        public byte? ParamPkrv { get; set; }
        public byte? ParamTradeDate { get; set; }
        public int? ParamRepoPkrv { get; set; }
        public DateTime? ParamCgtdate { get; set; }
        public int? ParamType { get; set; }
        public int? FundCode { get; set; }
        public int? ParamIsOnetimeMvgAvg { get; set; }
        public int? ParamInterestCalc { get; set; }
        public int? ParamFlag { get; set; }
        public int? ParamRepoPkrvpremCalc { get; set; }
        public int? ParamIsExposure { get; set; }
        public decimal? ParamValue { get; set; }
        public DateTime? ParamCutoffDate { get; set; }
    }
}
