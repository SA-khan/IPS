using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsApproveTradingBroker
    {
        public int FundMasterCode { get; set; }
        public int BrokerCode { get; set; }
        public int TradInstTypeCode { get; set; }
        public DateTime? AppBrokerDate { get; set; }
        public byte? AppBrokerStatus { get; set; }
        public int? AppBrokerModifiedBy { get; set; }
        public DateTime? AppBrokerModifiedWhen { get; set; }
        public int? AppBrokerCreatedBy { get; set; }
        public DateTime? AppBrokerCreatedWhen { get; set; }
    }
}
