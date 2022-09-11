using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class PmsSignatory
    {
        public int SignatoryCode { get; set; }
        public int FundMasterCode { get; set; }
        public int TradInstTypeCode { get; set; }
        public string SignatoryName1 { get; set; }
        public string SignatoryPhone1 { get; set; }
        public byte? SignatoryActive1 { get; set; }
        public byte? SignatoryPosition1 { get; set; }
        public string SignatoryName2 { get; set; }
        public string SignatoryPhone2 { get; set; }
        public byte? SignatoryActive2 { get; set; }
        public byte? SignatoryPosition2 { get; set; }
        public string SignatoryName3 { get; set; }
        public string SignatoryPhone3 { get; set; }
        public byte? SignatoryActive3 { get; set; }
        public byte? SignatoryPosition3 { get; set; }
        public string SignatoryName4 { get; set; }
        public string SignatoryPhone4 { get; set; }
        public byte? SignatoryActive4 { get; set; }
        public byte? SignatoryPosition4 { get; set; }
        public string SignatoryName5 { get; set; }
        public string SignatoryPhone5 { get; set; }
        public byte? SignatoryActive5 { get; set; }
        public byte? SignatoryPosition5 { get; set; }
        public int? SignatoryModifiedBy { get; set; }
        public DateTime? SignatoryModifiedWhen { get; set; }
        public int? SignatoryCreatedBy { get; set; }
        public DateTime? SignatoryCreatedWhen { get; set; }
    }
}
