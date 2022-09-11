using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsCustodian
    {
        public PmsCustodian()
        {
            PmsOrderExecs = new HashSet<PmsOrderExec>();
        }

        public int CustodianCode { get; set; }
        public string CustodianName { get; set; }
        public string CustodianDescription { get; set; }
        public string CustodianAddress { get; set; }
        public int? CounCode { get; set; }
        public int? CityCode { get; set; }
        public string CustodianAccNo { get; set; }
        public string CustodianConPerson { get; set; }
        public string CustodianPartAccNo { get; set; }
        public string CustodianCdsaccNo { get; set; }

        public virtual ICollection<PmsOrderExec> PmsOrderExecs { get; set; }
    }
}
