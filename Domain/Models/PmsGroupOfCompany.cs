using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsGroupOfCompany
    {
        public int GcompanyCode { get; set; }
        public string GcompanyName { get; set; }
        public string GcompanyDesc { get; set; }
        public string GcompanyMnemonic { get; set; }
    }
}
