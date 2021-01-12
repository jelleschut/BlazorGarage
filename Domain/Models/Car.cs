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
        public string Brand { get; set; }
        public string Model { get; set; }

        //Foreign Keys
        public int OwnerId { get; set; }
        public int DriverId { get; set; }

        //Navigation Properties
        public virtual Owner Owner { get; set; }
        public virtual Owner Driver { get; set; }
        public virtual List<Maintenance> Maintenances { get; set; }
    }
}
