using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsEmployee
    {
        public PmsEmployee()
        {
            PmsEmpInvestments = new HashSet<PmsEmpInvestment>();
        }

        public int EmpCode { get; set; }
        public string EmpName { get; set; }
        public string EmpStaffCode { get; set; }
        public string EmpAddress { get; set; }
        public string EmpDesignation { get; set; }
        public string EmpDept { get; set; }
        public string EmpPhone { get; set; }
        public string EmpFax { get; set; }
        public string EmpEmail { get; set; }
        public string EmpNationality { get; set; }
        public bool EmpActive { get; set; }

        public virtual ICollection<PmsEmpInvestment> PmsEmpInvestments { get; set; }
    }
}
