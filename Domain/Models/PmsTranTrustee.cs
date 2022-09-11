using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsTranTrustee
    {
        public int TranTrusteeSno { get; set; }
        public int TrusteeCode { get; set; }
        public string FInstTranRefNo { get; set; }
        public int? FundCode { get; set; }
        public int? FundMasterCode { get; set; }
        public int? DtschemaType { get; set; }
        public int? TranTrusteeCreatedBy { get; set; }
        public DateTime? TranTrusteeCreatedWhen { get; set; }
    }
}
