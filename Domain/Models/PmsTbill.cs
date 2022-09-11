using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsTbill
    {
        public int TbillCode { get; set; }
        public int TradInstTypeCode { get; set; }
        public string TbillName { get; set; }
        public bool? TbillListed { get; set; }
        public decimal TbillAmount { get; set; }
        public decimal TbillAuctionYield { get; set; }
        public DateTime TbillIssueDate { get; set; }
        public DateTime TbillMaturityDate { get; set; }
        public int TbillMaturityPeriod { get; set; }
        public string TbillDesc { get; set; }
        public string TbillSecCode { get; set; }
        public string TbillAucNo { get; set; }
        public DateTime? TbillAucDate { get; set; }
        public int ProductCode { get; set; }
        public int? ShareCode { get; set; }
        public byte? TbillIsMatured { get; set; }
        public decimal? TbillAcceptAmount { get; set; }
        public decimal? TbillParticiAmount { get; set; }
        public int? TbillMaturityType { get; set; }
        public DateTime? TbillMatpayRealised { get; set; }
        public string TbillMatfundMaster { get; set; }
        public string TbillMatsettBank { get; set; }
        public int? TbillYears { get; set; }
        public int? TbillCreatedby { get; set; }
        public DateTime? TbillCreatedwhen { get; set; }
        public int? TbillModifiedby { get; set; }
        public DateTime? TbillModifiedwhen { get; set; }
        public int? TbillIsauthorized { get; set; }
        public string TbillReason { get; set; }
        public int? TbillAuthorizedby { get; set; }
        public DateTime? TbillAuthorizedwhen { get; set; }
        public decimal? TbillAcutionprice { get; set; }
        public byte? TbillAmortMethod { get; set; }

        public virtual PmsUserDefProduct PmsUserDefProduct { get; set; }
    }
}
