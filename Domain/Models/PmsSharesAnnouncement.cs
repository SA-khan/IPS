using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsSharesAnnouncement
    {
        public DateTime ShareAnnDate { get; set; }
        public int ShareCode { get; set; }
        public decimal? ShareAnnDivRate { get; set; }
        public DateTime? ShareAnnDateDivBkClos { get; set; }
        public decimal? ShareAnnBonusRate { get; set; }
        public DateTime? ShareAnnDateBonBkClos { get; set; }
        public decimal? ShareAnnRightsRateInPercent { get; set; }
        public decimal? ShareAnnRightsRateInAmount { get; set; }
        public decimal? ShareAnnRightSubPrice { get; set; }
        public decimal? ShareAnnPaidupCap { get; set; }
        public DateTime? ShareAnnDateRightBkClos { get; set; }
        public DateTime? ShareAnnRenunciationDate { get; set; }
        public int? ShareAnnNonRightShares { get; set; }
        public DateTime? ShareAnnDateIssue { get; set; }
        public DateTime? ShareAnnDateAgm { get; set; }
        public int? ShareAnnDivEyrCode { get; set; }
        public int? ShareAnnDivEprCode { get; set; }
        public int? ShareAnnBonEyrCode { get; set; }
        public int? ShareAnnBonEprCode { get; set; }
        public byte? ShareAnnDivNature { get; set; }
        public byte? ShareAnnBonNature { get; set; }
        public string ShareAnnQuotRefNo { get; set; }
        public decimal? ShareAnnSplitBonQtyInPercent { get; set; }
        public decimal? ShareAnnTaxRate { get; set; }
        public DateTime? ShareAnnActualDvdBkCls { get; set; }
        public DateTime? ShareAnnActualBonBkCls { get; set; }

        public virtual PmsShare ShareCodeNavigation { get; set; }
    }
}
