using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsAssetModuleRelation
    {
        public int AssetmoduleSno { get; set; }
        public int AssetTypeCode { get; set; }
        public int AssetmoduleCode { get; set; }
        public string AssetmoduleName { get; set; }
        public string AssetmoduleGroupby { get; set; }
        public int? AssetmoduleCreatedby { get; set; }
        public DateTime? AssetmoduleCreatedWhen { get; set; }
        public int? AssetmoduleModifyby { get; set; }
        public DateTime? AssetmoduleModifyWhen { get; set; }
    }
}
