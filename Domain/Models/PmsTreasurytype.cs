using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsTreasurytype
    {
        public int FinsttranType { get; set; }
        public string FinsttranTypename { get; set; }
        public int FinsttranMode { get; set; }
        public string FinsttranModename { get; set; }
        public int? TreasurytypeCreatedby { get; set; }
        public DateTime? TreasurytypeCreatedwhen { get; set; }
        public int? TreasurytypeModifyby { get; set; }
        public DateTime? TreasurytypeModifywhen { get; set; }
    }
}
