using System;
using System.Collections.Generic;

namespace WindowsFormsAppdb.Models
{
    public partial class Insurance
    {
        public int? InsuranceTechPasportId { get; set; }
        public string InsuranceSerialnumber { get; set; }
        public DateTime? InsuranceFrom { get; set; }
        public DateTime? InsuranceBefore { get; set; }
        public int? InsuranceCivilianId { get; set; }

        public virtual Citizen InsuranceCivilian { get; set; }
        public virtual TechPasport InsuranceTechPasport { get; set; }
    }
}
