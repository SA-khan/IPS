using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsTranMaster
    {
        public PmsTranMaster()
        {
            PmsTranDetails = new HashSet<PmsTranDetail>();
        }

        public decimal TranMasterCode { get; set; }
        public int TranMasterType { get; set; }
        public int? CalYearCode { get; set; }
        public int? CalPeriodCode { get; set; }
        public decimal? SettDateCode { get; set; }
        public int? SettDateType { get; set; }
        public DateTime? TranMasterRolloverDate { get; set; }
        public DateTime TranMasterDate { get; set; }
        public decimal? OrdExecCode { get; set; }
        public decimal? OrderCode { get; set; }
        public int? TradInstTypeCode { get; set; }
        public int? TradInstCode { get; set; }
        public decimal? FInstTranCode { get; set; }
        public int? FInstTranType { get; set; }
        public int? CouponCode { get; set; }
        public DateTime? ShareAnnDate { get; set; }
        public int? CpoptionCode { get; set; }
        public int? CpoptionType { get; set; }
        public int? TranMasterState { get; set; }
        public int? UserId { get; set; }
        public byte? TranMasterAnnProcState { get; set; }
        public DateTime? TranMasterEntProcDate { get; set; }
        public DateTime? TranMasterDelProcDate { get; set; }
        public string TranMasterRemark { get; set; }

        public virtual PmsCalPeriod Cal { get; set; }
        public virtual PmsSettlementDate SettDate { get; set; }
        public virtual ICollection<PmsTranDetail> PmsTranDetails { get; set; }
    }
}
