using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsBrkTfcmrkPrice
    {
        public int TfcCode { get; set; }
        public DateTime MrkDate { get; set; }
        public int TradInstTypeCode { get; set; }
        public int BrokerCode { get; set; }
        public string MrkBrkSymbol { get; set; }
        public string MrkSymbol { get; set; }
        public decimal? MrkBid { get; set; }
        public decimal? MrkOffer { get; set; }
        public decimal? MrkVolume { get; set; }
        public int? UserId { get; set; }
        public DateTime? Datetime { get; set; }
    }
}
