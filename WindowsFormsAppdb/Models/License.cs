using System;
using System.Collections.Generic;

namespace WindowsFormsAppdb.Models
{
    public partial class License
    {
        public long LicenseId { get; set; }
        public int? OwnerId { get; set; }
        public DateTime? FromData { get; set; }
        public DateTime? BeforeData { get; set; }

        public virtual Citizen Owner { get; set; }
    }
}
