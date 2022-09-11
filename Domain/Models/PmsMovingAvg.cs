using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsMovingAvg
    {
        public int MovAvgCode { get; set; }
        public int FundCode { get; set; }
        public int TradInstTypeCode { get; set; }
        public int TradInstCode { get; set; }
        public int? TranMasterType { get; set; }
        public int? OrdExecCode { get; set; }
        public int? OrderCode { get; set; }
        public int? OrderMode { get; set; }
        public int? BrokerCode { get; set; }
        public DateTime? MovAvgTranDate { get; set; }
        public DateTime? MovAvgModifiedDate { get; set; }
        public decimal? MovAvgAverage { get; set; }
        public decimal? MovAvgQty { get; set; }
        public decimal? MovAvgPrice { get; set; }
        public int? OrderSubtype { get; set; }
        public decimal? MovAvgCarryCost { get; set; }
        public DateTime? DmpDate { get; set; }
        public decimal? MovAvgAmtMov { get; set; }
        public decimal? MovAvgAmtCarr { get; set; }
        public decimal? MovAvgExFqty { get; set; }
        public decimal? MovAvgExFamt { get; set; }
        public decimal? MovAvgExFamtCarr { get; set; }
        public decimal? MovAvgExFaverage { get; set; }
        public decimal? MovAvgExFcarryCost { get; set; }
        public DateTime? MovAvgProcDate { get; set; }
        public DateTime? MovAvgSettDate { get; set; }
        public string OrdExecDealTickNo { get; set; }
        public int? OrderOpenCloseFlag { get; set; }
        public decimal? SettDateMovFedtax { get; set; }
        public decimal? SettDateMovBrokerCommission { get; set; }
        public decimal? SettdateMovWhtaxtrade { get; set; }
        public decimal? MovAvgMovCapGainlLoss { get; set; }
        public decimal? MovAvgCarrCapGainlLoss { get; set; }
        public int? SettModeCode { get; set; }
        public int? SubProductType { get; set; }
    }
}
