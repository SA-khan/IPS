using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsSiletterNumber
    {
        public decimal SilSerialNo { get; set; }
        public int YearCode { get; set; }
        public int FundCode { get; set; }
        public DateTime SilDate { get; set; }
        public int BrokerCode { get; set; }
        public int? TradInstCode { get; set; }
        public int OrderMode { get; set; }
        public int TradInstTypeCode { get; set; }
        public string SilLetterNo { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
