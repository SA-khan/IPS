using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsParamConfig
    {
        public int ParamType { get; set; }
        public string ParamCnfgPhysicalName { get; set; }
        public string ParamCnfgDescription { get; set; }
        public int? ParamCnfgType { get; set; }
    }
}
