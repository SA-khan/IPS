using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsBroker
    {
        public PmsBroker()
        {
            PmsBrokerageRates = new HashSet<PmsBrokerageRate>();
            PmsCois = new HashSet<PmsCoi>();
            PmsCustomersAccounts = new HashSet<PmsCustomersAccount>();
            PmsFoOrders = new HashSet<PmsFoOrder>();
            PmsOrders = new HashSet<PmsOrder>();
        }

        public int BrokerCode { get; set; }
        public string BrokerName { get; set; }
        public decimal? BrokerCotlimit { get; set; }
        public bool? BrokerIsActive { get; set; }
        public bool? BrokerIsPrimaryDealer { get; set; }
        public decimal? BrokerBrokerCommTax { get; set; }
        public string BrokerPhone { get; set; }
        public string BrokerFax { get; set; }
        public string BrokerEmail { get; set; }
        public string BrokerAddress { get; set; }
        public string BrokerAccNo { get; set; }
        public string BrokerDesc { get; set; }
        public string BrokerMnemonic { get; set; }
        public int? BrokerForPkrv { get; set; }
        public int? BrokerIssalecomm { get; set; }
        public int? BrokerOldCode { get; set; }
        public byte? BrokerSetFor { get; set; }
        public bool? BrokerIsAssosiated { get; set; }
        public string BrokerCfsdefTradeId { get; set; }
        public byte? BrokerIsTfclisted { get; set; }
        public int? BrokerCreatedBy { get; set; }
        public DateTime? BrokerCreatedWhen { get; set; }
        public int? BrokerModifiedBy { get; set; }
        public DateTime? BrokerModifiedWhen { get; set; }
        public int? BrokerIsAuthorized { get; set; }
        public string BrokerReason { get; set; }
        public int? BrokerAuthorizedBy { get; set; }
        public DateTime? BrokerAuthorizedWhen { get; set; }
        public string BrokerSubLedgerType { get; set; }
        public string BrokerSubLedgerAc { get; set; }
        public int? BrokerFundCode { get; set; }
        public int? BrokerFundmasterCode { get; set; }

        public virtual ICollection<PmsBrokerageRate> PmsBrokerageRates { get; set; }
        public virtual ICollection<PmsCoi> PmsCois { get; set; }
        public virtual ICollection<PmsCustomersAccount> PmsCustomersAccounts { get; set; }
        public virtual ICollection<PmsFoOrder> PmsFoOrders { get; set; }
        public virtual ICollection<PmsOrder> PmsOrders { get; set; }
    }
}
