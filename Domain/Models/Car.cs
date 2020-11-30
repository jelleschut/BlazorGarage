using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Domain.Models
{
    public class Car
    {
        public int CarId { get; set; }

        [DisplayName("Licensenumber")]
        public string LicenseNumber { get; set; }
        public StatusEnum? Status { get; set; }

        //Navigation Properties
        public virtual CarModel CarModel { get; set; }
        public virtual Owner Owner { get; set; }
        public virtual Owner Driver { get; set; }
        public virtual List<Maintenance> Maintenances { get; set; }
    }
}
