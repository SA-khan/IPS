using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsCustomersAccount
    {
        public int CustomerCode { get; set; }
        public int FundMasterCode { get; set; }
        public int BrokerCode { get; set; }
        public string CityName { get; set; }
        public string CountryName { get; set; }
        public string CustomerName { get; set; }
        public string CustomerNationality { get; set; }
        public string CustomerPinCode { get; set; }
        public string CustomerCardNo { get; set; }
        public string CustomerAddress1 { get; set; }
        public string CustomerAddress2 { get; set; }
        public int? CustomerPostCode { get; set; }
        public string CustomerPhone1 { get; set; }
        public string CustomerPhone2 { get; set; }
        public string CustomerFaxes { get; set; }
        public string CustomerEmail { get; set; }
        public DateTime CustomerCreationDate { get; set; }

        public virtual PmsBroker BrokerCodeNavigation { get; set; }
        public virtual PmsFundMaster FundMasterCodeNavigation { get; set; }
    }
}
