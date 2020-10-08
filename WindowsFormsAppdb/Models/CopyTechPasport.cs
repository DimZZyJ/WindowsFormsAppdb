using System;
using System.Collections.Generic;

namespace WindowsFormsAppdb.Models
{
    public partial class CopyTechPasport
    {
        public int? TechPassId { get; set; }
        public int? CivTechPassportId { get; set; }
        public string Color { get; set; }
        public string CarModel { get; set; }
        public string Vin { get; set; }
        public DateTime? ДатаИВремяМодификации { get; set; }
        public string ПользовательВнёсшийИзменения { get; set; }
        public string ТипМодификацииВставкаУдаление { get; set; }
    }
}
