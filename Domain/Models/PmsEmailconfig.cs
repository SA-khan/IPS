using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsEmailconfig
    {
        public int EmailconfigSno { get; set; }
        public string EmailconfigId { get; set; }
        public string EmailconfigPassword { get; set; }
        public string EmailconfigSmtpserver { get; set; }
        public int EmailconfigPort { get; set; }
        public string EmailconfigDomain { get; set; }
        public string EmailconfigDisplayname { get; set; }
        public int EmailconfigSsl { get; set; }
        public string CcemailconfigId { get; set; }
    }
}
