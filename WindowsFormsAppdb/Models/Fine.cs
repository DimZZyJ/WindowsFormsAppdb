using System;
using System.Collections.Generic;

namespace WindowsFormsAppdb.Models
{
    public partial class Fine
    {
        public int? VialatorId { get; set; }
        public int? Ammount { get; set; }
        public int? VialatorTechPasportId { get; set; }
        public int? Koap12 { get; set; }
        public DateTime? VialationDate { get; set; }
        public string VialationPlace { get; set; }

        public virtual Citizen Vialator { get; set; }
        public virtual TechPasport VialatorTechPasport { get; set; }
    }
}
