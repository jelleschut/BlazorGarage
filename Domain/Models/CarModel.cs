using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class CarModel
    {
        public int CarModelId { get; set; }
        public string Name { get; set; }

        //Navigation Properties
        public virtual Brand Brand { get; set; }
        public virtual List<Car> Cars { get; set; }
    }
}
