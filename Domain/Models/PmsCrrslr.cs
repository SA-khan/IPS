using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsCrrslr
    {
        public int FundMasterCode { get; set; }
        public DateTime CrrslrDate { get; set; }
        public int? GlDetailEntityCode { get; set; }
        public string GlDetailAccCode { get; set; }
        public int? GlHeadEntityType { get; set; }
        public int? GlHeadAccType { get; set; }
        public string GlHeadAccTitle { get; set; }
        public int? FInstTypeCode { get; set; }
        public int? FInstTranType { get; set; }
        public int? FinstTranMode { get; set; }
        public int? FInstCode { get; set; }
        public string FInstTranRefNo { get; set; }
        public string OrdExecDealTickNo { get; set; }
        public decimal? BankFundCapital { get; set; }
        public decimal? TotalCapital { get; set; }
        public decimal? Tdlamount { get; set; }
        public decimal? PerCrr { get; set; }
        public decimal? PerSlr { get; set; }
        public decimal? PerPib { get; set; }
        public decimal? Crramount { get; set; }
        public decimal? Slramount { get; set; }
        public decimal? PerPibamount { get; set; }
        public decimal? FaceValue { get; set; }
        public decimal? MktValue { get; set; }
        public decimal? AbFaceValue { get; set; }
        public decimal? AbCostOfInv { get; set; }
        public decimal? AbMktValue { get; set; }
        public decimal? AbPibvalue { get; set; }
        public decimal? AbSlrvalue { get; set; }
        public int? ValuesType { get; set; }
        public int? IsVerifySbp { get; set; }
        public int? TradInstTypeCode { get; set; }
        public int CrrslrSno { get; set; }
        public string ProductName { get; set; }
        public int? CrrslrCreatedBy { get; set; }
        public DateTime? CrrslrCreatedWhen { get; set; }
        public DateTime? CrrslrMaintainDate { get; set; }
    }
}
