using System;
using System.Collections.Generic;

namespace WindowsFormsAppdb.Models
{
    public partial class TechPasport
    {
        public TechPasport()
        {
            Insurance = new HashSet<Insurance>();
        }

        public int TechPassId { get; set; }
        public int? CivTechPassportId { get; set; }
        public string Color { get; set; }
        public string CarModel { get; set; }
        public string Vin { get; set; }

        public virtual Citizen CivTechPassport { get; set; }
        public virtual ICollection<Insurance> Insurance { get; set; }
    }
}
