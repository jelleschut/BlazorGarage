using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Enums
{
    public enum MaintenanceEnum
    {
        [Display(Name = "MOT")]
        MOT,
        [Display(Name = "Repair")]
        REPAIR,
        [Display(Name = "Maintenance")]
        MAINTENANCE
    }
}
