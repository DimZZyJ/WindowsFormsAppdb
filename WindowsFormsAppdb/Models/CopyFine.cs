using System;
using System.Collections.Generic;

namespace WindowsFormsAppdb.Models
{
    public partial class CopyFine
    {
        public int? VialatorId { get; set; }
        public int? Ammount { get; set; }
        public int? VialatorTechPasportId { get; set; }
        public int? Koap12 { get; set; }
        public DateTime? VialationDate { get; set; }
        public string VialationPlace { get; set; }
        public DateTime? ДатаИВремяМодификации { get; set; }
        public string ПользовательВнёсшийИзменения { get; set; }
        public string ТипМодификацииВставкаУдаление { get; set; }
    }
}
