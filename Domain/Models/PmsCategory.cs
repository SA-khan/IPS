using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsCategory
    {
        public int CatCode { get; set; }
        public string CatName { get; set; }
        public int CatType { get; set; }
    }
}
