using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Maintenance
    {
        public int MaintenanceId { get; set; }
        public DateTime Date { get; set; }
        public int Milage { get; set; }
        public string Description { get; set; }
        public MaintenanceEnum MaintenanceType { get; set; }
        public StatusEnum Status { get; set; }
        public DateTime? InspectionDate { get; set; }

        //Foreign Keys
        public int CarId { get; set; }

        //Navigation Properties
        public virtual Car Car { get; set; }
    }
}
