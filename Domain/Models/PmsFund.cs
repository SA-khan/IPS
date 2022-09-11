using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsFund
    {
        public PmsFund()
        {
            PmsCois = new HashSet<PmsCoi>();
            PmsInvCommOrdApps = new HashSet<PmsInvCommOrdApp>();
            PmsOrders = new HashSet<PmsOrder>();
        }

        public int FundCode { get; set; }
        public int? FundMasterCode { get; set; }
        public string FundName { get; set; }
        public string FundDesc { get; set; }
        public string FundMnemonic { get; set; }
        public DateTime? FundCreationDate { get; set; }
        public bool? FundUseCarryCost { get; set; }
        public string FundCostCenter { get; set; }
        public bool? FundCvtasCost { get; set; }
        public bool? FundBrkasCost { get; set; }
        public decimal? FundFutMovPer { get; set; }
        public bool? FundCvtasCostFut { get; set; }
        public bool? FundBrkasCostFut { get; set; }
        public bool? FundCvtasCostTfc { get; set; }
        public bool? FundBrkasCostTfc { get; set; }
        public bool? FundCvtasCostPib { get; set; }
        public bool? FundBrkasCostPib { get; set; }
        /// <summary>
        /// Accrued interest impact in first coupon or not
        /// </summary>
        public byte? FundIsMmiaccrued { get; set; }
        public bool? FundYearEnd { get; set; }
        public bool? FundFedasCost { get; set; }
        public bool? FundCvtasCostTbill { get; set; }
        public bool? FundBrkasCostTbill { get; set; }
        /// <summary>
        /// Amortization required or not
        /// </summary>
        public byte? FundIsMmiamort { get; set; }
        public byte? FundIsMmiaccruedPib { get; set; }
        public byte? FundIsMmiamortPib { get; set; }
        public bool? FundFedasCostFut { get; set; }
        public bool? FundCdcasCost { get; set; }
        public bool? FundIsFrozen { get; set; }
        public int? FundNature { get; set; }
        public int? FundIsAccIrrtbill { get; set; }
        public int? FundUnRealGainLoss { get; set; }
        public int? FundPibyieldBasisMap { get; set; }
        public int? FundPibpriceBasisMap { get; set; }

        public virtual ICollection<PmsCoi> PmsCois { get; set; }
        public virtual ICollection<PmsInvCommOrdApp> PmsInvCommOrdApps { get; set; }
        public virtual ICollection<PmsOrder> PmsOrders { get; set; }
    }
}
