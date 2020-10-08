using System;
using System.Collections.Generic;

namespace WindowsFormsAppdb.Models
{
    public partial class CopyInsurance
    {
        public int? InsuranceTechPasportId { get; set; }
        public string InsuranceSerialnumber { get; set; }
        public DateTime? InsuranceFrom { get; set; }
        public DateTime? InsuranceBefore { get; set; }
        public int? InsuranceCivilianId { get; set; }
        public DateTime? ДатаИВремяМодификации { get; set; }
        public string ПользовательВнёсшийИзменения { get; set; }
        public string ТипМодификацииВставкаУдаление { get; set; }
    }
}
