using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsCdsholding
    {
        public int FundMasterCode { get; set; }
        public DateTime CdsDate { get; set; }
        public int TradInstTypeCode { get; set; }
        public int TradInstCode { get; set; }
        public string CdsParticipantId { get; set; }
        public int CdsAccountNo { get; set; }
        public decimal CdsPositionOwned { get; set; }
        public decimal? CdsAvailable { get; set; }
        public decimal? CdsPledged { get; set; }
        public decimal? CdsPledgedIn { get; set; }
        public decimal? CdsPledgedOut { get; set; }
        public decimal? CdsBlocked { get; set; }

        public virtual PmsFundMaster FundMasterCodeNavigation { get; set; }
    }
}
