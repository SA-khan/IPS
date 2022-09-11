using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsCouponDetail
    {
        public int CouponCode { get; set; }
        public int TradInstTypeCode { get; set; }
        public int TradInstCode { get; set; }
        public DateTime CouponDate { get; set; }
        public DateTime CouponSuspendeddate { get; set; }
        public int? CouponSuspended { get; set; }
        public int? CpndetailModifyby { get; set; }
        public DateTime? CpndetailModifyWhen { get; set; }
    }
}
