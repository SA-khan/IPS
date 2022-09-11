using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsDtschema
    {
        public decimal DtschemaCode { get; set; }
        public string FInstTranRefNo { get; set; }
        public DateTime? DtschemaDate { get; set; }
        public int? DtschemaType { get; set; }
        public int? DtschemaCreatedBy { get; set; }
        public DateTime? DtschemaCreatedWhen { get; set; }
        public int? DtschemaModifiedBy { get; set; }
        public DateTime? DtschemaModifiedWhen { get; set; }
        public int? DtschemaState { get; set; }
        public int FundCode { get; set; }
    }
}
