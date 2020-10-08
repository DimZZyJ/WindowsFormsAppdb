using System;
using System.Collections.Generic;

namespace WindowsFormsAppdb.Models
{
    public partial class CopyLicense
    {
        public long? LicenseId { get; set; }
        public int? OwnerId { get; set; }
        public DateTime? FromData { get; set; }
        public DateTime? BeforeData { get; set; }
        public DateTime? ДатаИВремяМодификации { get; set; }
        public string ПользовательВнёсшийИзменения { get; set; }
        public string ТипМодификацииВставкаУдаление { get; set; }
    }
}
