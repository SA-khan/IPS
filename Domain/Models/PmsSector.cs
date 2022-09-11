using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsSector
    {
        public PmsSector()
        {
            PmsShares = new HashSet<PmsShare>();
        }

        public int SectorCode { get; set; }
        public string SectorName { get; set; }
        public string SectorDesc { get; set; }
        public string SectorMnemonic { get; set; }
        public short? SectorIndexSe { get; set; }
        public DateTime? SectorCreatedWhen { get; set; }
        public int? SectorModifiedBy { get; set; }
        public DateTime? SectorModifiedWhen { get; set; }
        public int? SectorCreatedBy { get; set; }

        public virtual ICollection<PmsShare> PmsShares { get; set; }
    }
}
