using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsTradingInstrumentType
    {
        public PmsTradingInstrumentType()
        {
            PmsBrokerageRates = new HashSet<PmsBrokerageRate>();
            PmsCallAndPutOptions = new HashSet<PmsCallAndPutOption>();
            PmsCertificates = new HashSet<PmsCertificate>();
            PmsClrCompanyRates = new HashSet<PmsClrCompanyRate>();
            PmsCois = new HashSet<PmsCoi>();
            PmsCoupons = new HashSet<PmsCoupon>();
            PmsEmpInvestments = new HashSet<PmsEmpInvestment>();
            PmsFoOrders = new HashSet<PmsFoOrder>();
            PmsInvBonds = new HashSet<PmsInvBond>();
            PmsInvCommOrdApps = new HashSet<PmsInvCommOrdApp>();
            PmsMmiannouncements = new HashSet<PmsMmiannouncement>();
            PmsOrders = new HashSet<PmsOrder>();
            PmsSecurityDmprices = new HashSet<PmsSecurityDmprice>();
            PmsTfcs = new HashSet<PmsTfc>();
        }

        public int TradInstTypeCode { get; set; }
        public string TradInstTypeName { get; set; }
        public string TradInstTypeDesc { get; set; }
        public string TradInstTypeCostCenter { get; set; }
        public bool? TradInstTypeForPkrv { get; set; }

        public virtual ICollection<PmsBrokerageRate> PmsBrokerageRates { get; set; }
        public virtual ICollection<PmsCallAndPutOption> PmsCallAndPutOptions { get; set; }
        public virtual ICollection<PmsCertificate> PmsCertificates { get; set; }
        public virtual ICollection<PmsClrCompanyRate> PmsClrCompanyRates { get; set; }
        public virtual ICollection<PmsCoi> PmsCois { get; set; }
        public virtual ICollection<PmsCoupon> PmsCoupons { get; set; }
        public virtual ICollection<PmsEmpInvestment> PmsEmpInvestments { get; set; }
        public virtual ICollection<PmsFoOrder> PmsFoOrders { get; set; }
        public virtual ICollection<PmsInvBond> PmsInvBonds { get; set; }
        public virtual ICollection<PmsInvCommOrdApp> PmsInvCommOrdApps { get; set; }
        public virtual ICollection<PmsMmiannouncement> PmsMmiannouncements { get; set; }
        public virtual ICollection<PmsOrder> PmsOrders { get; set; }
        public virtual ICollection<PmsSecurityDmprice> PmsSecurityDmprices { get; set; }
        public virtual ICollection<PmsTfc> PmsTfcs { get; set; }
    }
}
