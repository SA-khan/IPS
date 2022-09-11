using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsProcessCashflow
    {
        public int ProcessCfCode { get; set; }
        public int FundMasterCode { get; set; }
        public DateTime FInstTranDate { get; set; }
        public int? FInstTranCode { get; set; }
        public int? FInstTranType { get; set; }
        public int CashTypeCode { get; set; }
        public int? TradInstTypeCode { get; set; }
        public int? FinstTranMode { get; set; }
        public string FInstTranRefNo { get; set; }
        public DateTime? CfDateSettlement { get; set; }
        public DateTime? CfDateDelivery { get; set; }
        public decimal? ProcessCfRate { get; set; }
        public decimal? ProcessCfQuantity { get; set; }
        public decimal? ProcessCfAmount { get; set; }
        public string FInstName { get; set; }
        public string FInstTypeName { get; set; }
        public string BrokerName { get; set; }
        public int? FInstTranSettBank { get; set; }
        public string ProcessCfMode { get; set; }
        public string ProcessCfSymbol { get; set; }
        public string ProcessCfIsAllfund { get; set; }
        public DateTime? ProcessCfStartDate { get; set; }
        public DateTime? ProcessCfEndDate { get; set; }
        public int? ProcessCfCreatedBy { get; set; }
        public DateTime? ProcessCfCreatedWhen { get; set; }
        public int? ProcessCfModifyBy { get; set; }
        public DateTime? ProcessCfModifyWhen { get; set; }
        public int? ProductCode { get; set; }
        public int? ProcessCfIsActive { get; set; }
        public int? CashTypeValidityDate { get; set; }
        public DateTime? FundCapMaturityDate { get; set; }
        public int? FundCapReportType { get; set; }
        public int? FundCapAccuralMethod { get; set; }
    }
}
