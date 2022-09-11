using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsScripInOutDef
    {
        public int? PorfoliGrpWiseLmtCode { get; set; }
        public int? TradinstTypeCode { get; set; }
        public int? TradinstCode { get; set; }
        public string ScripInOutDefInFundFlag { get; set; }
        public string ScripInOutDefOutFundFlag { get; set; }
    }
}
