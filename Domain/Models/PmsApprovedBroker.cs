using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsApprovedBroker
    {
        public int FundMasterCode { get; set; }
        public int BrokerCode { get; set; }
        public DateTime AppBrokerDate { get; set; }
        public decimal? AppBrokerLimit { get; set; }
        public DateTime? AppBrokerExdate { get; set; }
        public byte? AppBrokerStatus { get; set; }
        public int? AppBrokerModifiedBy { get; set; }
        public DateTime? AppBrokerModifiedWhen { get; set; }
        public int? AppBrokerCreatedBy { get; set; }
        public DateTime? AppBrokerCreatedWhen { get; set; }
        public int? AppBrokerFrequency { get; set; }
        public int? AppBrokerAmtType { get; set; }
        public int? AppBrokerType { get; set; }
    }
}
