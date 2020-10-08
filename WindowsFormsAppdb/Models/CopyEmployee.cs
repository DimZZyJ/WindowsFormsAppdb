using System;
using System.Collections.Generic;

namespace WindowsFormsAppdb.Models
{
    public partial class CopyEmployee
    {
        public long? EmpId { get; set; }
        public string EmpFio { get; set; }
        public DateTime? WorkDate { get; set; }
        public string WorkStatus { get; set; }
        public DateTime? LeaveDate { get; set; }
        public int? EmpPosition { get; set; }
        public DateTime? ДатаИВремяМодификации { get; set; }
        public string ПользовательВнёсшийИзменения { get; set; }
        public string ТипМодификацииВставкаУдаление { get; set; }
    }
}
