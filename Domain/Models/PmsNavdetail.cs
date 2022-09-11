using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsNavdetail
    {
        public DateTime NavDate { get; set; }
        public int FundMasterCode { get; set; }
        public int? NavdetAccCode { get; set; }
        public string NavdetAccTitle { get; set; }
        public byte? NavdetAccNature { get; set; }
        public decimal? NavdetAmount { get; set; }
    }
}
