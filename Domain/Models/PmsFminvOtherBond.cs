using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsFminvOtherBond
    {
        public int FminvOtherBondsCode { get; set; }
        public int FminvOtherBondsSno { get; set; }
        public int FundMasterCode { get; set; }
        public DateTime FminvOtherBondsDate { get; set; }
        public string FminvOtherBondsName { get; set; }
        public decimal FminvOtherBondsAmount { get; set; }
        public string FminvOtherBondsRemarks { get; set; }
        public int FminvOtherBondsActive { get; set; }
        public int? FminvOtherBondsCreatedBy { get; set; }
        public DateTime? FminvOtherBondsCreatedWhen { get; set; }
        public int FminvOtherBondsModifiedBy { get; set; }
        public DateTime FminvOtherBondsModifiedWhen { get; set; }
    }
}
