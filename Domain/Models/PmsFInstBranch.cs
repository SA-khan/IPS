using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsFInstBranch
    {
        public int FInstBranchCode { get; set; }
        public int FInstCode { get; set; }
        public string FInstBranchName { get; set; }
        public int FInstTypeCode { get; set; }
        public string FInstBranchAddress { get; set; }
        public string FInstBranchDesc { get; set; }
        public string FInstBranchContactPerson { get; set; }
        public string FInstBranchFax { get; set; }
        public string FInstBranchEmail { get; set; }
        public string FInstBranchPhones { get; set; }
        public string FInstBranchAccountNo { get; set; }
        public string FInstBranchBankIpsaccNo { get; set; }
        public bool? FInstBranchCntrParty { get; set; }
        public bool? FInstBranchPrDealer { get; set; }
        public bool? FInstBranchSettBank { get; set; }
        public bool? FInstBranchDepBank { get; set; }
        public string FinstbranchBiccode { get; set; }
        public string FinstbranchSglaccNo { get; set; }
        public string FinstbranchCustomerId { get; set; }
        public int? FinstbranchCreatedBy { get; set; }
        public DateTime? FinstbranchCreatedWhen { get; set; }
        public int? FinstbranchModifiedBy { get; set; }
        public DateTime? FinstbranchModifiedWhen { get; set; }
        public int? FinstbranchIsAuthorized { get; set; }
        public string FinstbranchReason { get; set; }
        public int? FinstbranchAuthorizedBy { get; set; }
        public DateTime? FinstbranchAuthorizedWhen { get; set; }
        public int? FinstbranchInvestor { get; set; }

        public virtual PmsFInstituion FInst { get; set; }
    }
}
