using System;
using System.Collections.Generic;

namespace WindowsFormsAppdb.Models
{
    public partial class Citizen
    {
        public Citizen()
        {
            Insurance = new HashSet<Insurance>();
            License = new HashSet<License>();
            TechPasport = new HashSet<TechPasport>();
        }

        public int CitizenId { get; set; }
        public string CitizenFio { get; set; }

        public virtual ICollection<Insurance> Insurance { get; set; }
        public virtual ICollection<License> License { get; set; }
        public virtual ICollection<TechPasport> TechPasport { get; set; }
    }
}
