using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsCity
    {
        public int CityCode { get; set; }
        public int? CounCode { get; set; }
        public string CityName { get; set; }
    }
}
