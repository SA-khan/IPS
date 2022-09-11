using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsShare
    {
        public PmsShare()
        {
            PmsCois = new HashSet<PmsCoi>();
            PmsSharesAnnouncements = new HashSet<PmsSharesAnnouncement>();
            PmsTfcs = new HashSet<PmsTfc>();
        }

        public int ShareCode { get; set; }
        public int TradInstTypeCode { get; set; }
        public int? GcompanyCode { get; set; }
        public int SectorCode { get; set; }
        public string ShareSymbol { get; set; }
        public string ShareName { get; set; }
        public bool? ShareListed { get; set; }
        public string ShareFascomCode { get; set; }
        public bool? ShareIsCdceligible { get; set; }
        public decimal ShareFaceValue { get; set; }
        public decimal ShareNoOfSharesIssued { get; set; }
        public string ShareDesc { get; set; }
        public bool? ShareTradeInFuture { get; set; }
        public decimal SharePaidupCapital { get; set; }
        public bool? ShareTranReporting { get; set; }
        public string ShareCompCode { get; set; }
        public bool? ShareDelisted { get; set; }
        public DateTime? ShareFutStartDate { get; set; }
        public DateTime? ShareFutEndDate { get; set; }
        public DateTime? ShareFutSettDate { get; set; }
        public int? CalperiodCode { get; set; }
        public int? CalyearCode { get; set; }
        public byte? ShareFutState { get; set; }
        public int? ShareFutPcode { get; set; }
        public string ShareSeccode { get; set; }
        public bool? ShareIsMerged { get; set; }
        public byte? ShareType { get; set; }
        public bool? ShareIsCfseligible { get; set; }
        public int? ShareAmcfInstCode { get; set; }
        public int? FundMasterCode { get; set; }
        public DateTime? ShareDelistedDate { get; set; }
        public string ShareIsMtseligible { get; set; }
        public string ShareRalsymbol { get; set; }
        public int? ShareBorrowerCode { get; set; }
        public int? RiskLimitConfigCode { get; set; }
        public int? ShareFundType { get; set; }
        public int? ShareNature { get; set; }
        public int? ShareRelatedParty { get; set; }
        public string ShareSecid { get; set; }

        public virtual PmsSector SectorCodeNavigation { get; set; }
        public virtual ICollection<PmsCoi> PmsCois { get; set; }
        public virtual ICollection<PmsSharesAnnouncement> PmsSharesAnnouncements { get; set; }
        public virtual ICollection<PmsTfc> PmsTfcs { get; set; }
    }
}
