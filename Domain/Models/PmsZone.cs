using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsZone
    {
        public int ZoneCode { get; set; }
        public string ZoneName { get; set; }
        public string ZoneDesc { get; set; }
        public int? ZoneModifiedBy { get; set; }
        public DateTime? ZoneModifiedWhen { get; set; }
        public int? ZoneCreatedBy { get; set; }
        public DateTime? ZoneCreatedWhen { get; set; }
    }
}
