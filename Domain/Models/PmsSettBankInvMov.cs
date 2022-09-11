using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsSettBankInvMov
    {
        public int SettBnkCode { get; set; }
        public DateTime SettBnkDate { get; set; }
        public string OrdExecDealTickNo { get; set; }
        public int? TradInstTypeCode { get; set; }
        public int? TradInstCode { get; set; }
        public int? ProductCode { get; set; }
        public int? FundCode { get; set; }
        public int? OrderMode { get; set; }
        public int? SettBnkCurrBank { get; set; }
        public int? SettBnkOldBank { get; set; }
        public decimal? SettBnkQuantity { get; set; }
        public decimal? SettBnkAmount { get; set; }
        public int? SettBnkOrdInvMov { get; set; }
        public string SettBnkPurDealTickNo { get; set; }
        public byte[] SettBnkTimeStamp { get; set; }
        public int? SettBnkCreatedBy { get; set; }
        public string SettBnkCreatedWhen { get; set; }
        public int? SettBnkModifiedBy { get; set; }
        public string SettBnkModifiedWhen { get; set; }
    }
}
