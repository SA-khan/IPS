using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsTblTmp
    {
        public int? ShareCode { get; set; }
        public string TblTmpCode { get; set; }
        public string ShareName { get; set; }
        public decimal? OrderQuantity { get; set; }
        public decimal? OrderPriceLimit { get; set; }
        public decimal? MovAvgCarryCost { get; set; }
        public decimal? SalePrice { get; set; }
        public decimal? PurchasePrice { get; set; }
        public decimal? DmpPrice { get; set; }
    }
}
