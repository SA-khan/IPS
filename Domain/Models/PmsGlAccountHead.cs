using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsGlAccountHead
    {
        public int GlHeadEntityType { get; set; }
        public int GlHeadAccType { get; set; }
        public string GlHeadAccTitle { get; set; }
    }
}
