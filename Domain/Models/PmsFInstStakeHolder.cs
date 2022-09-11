using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsFInstStakeHolder
    {
        public int FInstStakeCode { get; set; }
        public int FInstTypeCode { get; set; }
        public int FInstCode { get; set; }
        public int? FinstStakeNature { get; set; }
        public int? FinstStakeGroup { get; set; }
        public string FinstStakeName { get; set; }
        public string FinstStakePasport { get; set; }
        public string FinstStakeCnic { get; set; }
        public DateTime? FinstStakePasportIssue { get; set; }
        public DateTime? FinstStakePasportExpire { get; set; }
        public DateTime? FinstStakeCnicissue { get; set; }
        public DateTime? FinstStakeCnicexpire { get; set; }
        public int? FinstStakeIsActive { get; set; }
        public DateTime? FinstStakeActiveDate { get; set; }
        public int? FinstStakeCreatedBy { get; set; }
        public DateTime? FinstStakeCreatedWhen { get; set; }
        public int? FinstStakeModifyBy { get; set; }
        public DateTime? FinstStakeModifyWhen { get; set; }
        public int? FinstStakeIsAuthorized { get; set; }
        public string FinstStakeReason { get; set; }
        public int? FinstStakeAuthorizedBy { get; set; }
        public DateTime? FinstStakeAuthorizedWhen { get; set; }
    }
}
