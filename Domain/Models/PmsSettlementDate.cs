using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsSettlementDate
    {
        public PmsSettlementDate()
        {
            PmsTranMasters = new HashSet<PmsTranMaster>();
        }

        public decimal SettDateCode { get; set; }
        public int SettDateType { get; set; }
        public decimal? FInstTranCode { get; set; }
        public int? FInstTranType { get; set; }
        public decimal? OrderCode { get; set; }
        public int? TradInstTypeCode { get; set; }
        public int? TradInstCode { get; set; }
        public decimal? OrdExecCode { get; set; }
        public int? CalYearCode { get; set; }
        public int? CalPeriodCode { get; set; }
        public decimal? SettDateAmount { get; set; }
        public decimal? SettDateQuantity { get; set; }
        public decimal SettDateRate { get; set; }
        public DateTime SettDateDate { get; set; }
        public int? SettDateState { get; set; }
        public decimal? SettDateNetAmount { get; set; }
        public decimal? SettDateAccruedInterest { get; set; }
        public decimal? SettDateBrokerCommission { get; set; }
        public decimal? SettDateWhtaxBcom { get; set; }
        public decimal? SettdateWhtaxtrade { get; set; }
        public byte? SettdateWhtaxmode { get; set; }
        public int? TaxTypeCode { get; set; }
        public decimal? SettDateBrkOtherCharges { get; set; }
        public byte? SettDateStatus { get; set; }
        public decimal? SettDateFedtax { get; set; }
        public decimal? SettDateCdccharges { get; set; }
        public decimal? SettDateFprratio { get; set; }
        public decimal? SettDateFpramount { get; set; }
        public decimal? SettDateMtsreleaseAmt { get; set; }

        public virtual PmsCalPeriod Cal { get; set; }
        public virtual PmsOrderExec PmsOrderExec { get; set; }
        public virtual ICollection<PmsTranMaster> PmsTranMasters { get; set; }
    }
}
