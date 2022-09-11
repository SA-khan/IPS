using System;
using System.Collections.Generic;

namespace IPS.Domain.Models
{
    public partial class OrderNotification
    {
        public int Id { get; set; }
        public string TableName { get; set; }
        public Guid? ChangeId { get; set; }
    }
}
