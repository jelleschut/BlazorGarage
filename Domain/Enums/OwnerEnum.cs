using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Enums
{
    public enum OwnerEnum
    {
        [Display(Name = "Lease Company")]
        LEASECOMPANY,
        [Display(Name = "Driver")]
        DRIVER
    }
}
