using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsIssuance
    {
        public int TfcCode { get; set; }
        public int? ShareCode { get; set; }
        public int TradInstTypeCode { get; set; }
        public string TfcName { get; set; }
        public string TfcIssuerName { get; set; }
        public string TfcSymbol { get; set; }
        public decimal? TfcCouponRatePerAnnum { get; set; }
        public bool? TfcListed { get; set; }
        public decimal TfcFaceValue { get; set; }
        public bool? TfcIsConvertible { get; set; }
        public decimal? TfcConversionPrice { get; set; }
        public decimal? TfcConversionQuantity { get; set; }
        public DateTime? TfcConvFixedDay { get; set; }
        public int? TfcConvPeriod { get; set; }
        public string TfcCreditRating { get; set; }
        public int TfcRedemptionTenor { get; set; }
        public DateTime TfcIssueDate { get; set; }
        public DateTime TfcMaturityDate { get; set; }
        public int TfcCouponsQty { get; set; }
        public decimal TfcCouponCapRate { get; set; }
        public decimal TfcCouponFloorRate { get; set; }
        public string TfcDesc { get; set; }
        public byte? TfcAccrualBasis { get; set; }
        public byte? TfcAmortMethod { get; set; }
        public byte? TfcAmortStartBasis { get; set; }
        public byte? TfcAmortBasis { get; set; }
        public byte? Tfc1stCpnAccrBasis { get; set; }
        public decimal? TfcBaseRate { get; set; }
        public byte? TfcRatesDay { get; set; }
        public byte? RateTemplType { get; set; }
        public string RateTemplSlabName { get; set; }
        public decimal? TfcCouponMinRate { get; set; }
        public decimal? TfcCouponMaxRate { get; set; }
        public decimal? TfcSize { get; set; }
        public string TfcIsino { get; set; }
        public byte? TfcNature { get; set; }
        public int ProductCode { get; set; }
        public int? TfcRedemptionType { get; set; }
        public bool? TfcIssuance { get; set; }
        public int? TfcSettThrough { get; set; }
        public int? FInstTypeCode { get; set; }
        public int? FInstCode { get; set; }
        public int? TfcYears { get; set; }
        public int? TfcCreatedby { get; set; }
        public DateTime? TfcCreatedwhen { get; set; }
        public int? TfcModifiedby { get; set; }
        public DateTime? TfcModifiedwhen { get; set; }
        public int? TfcIsauthorized { get; set; }
        public string TfcReason { get; set; }
        public int? TfcAuthorizedby { get; set; }
        public DateTime? TfcAuthorizedwhen { get; set; }
    }
}
