using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string Name { get; set; }

        //Navigation Properties
        public virtual List<CarModel> CarModels { get; set; }
    }
}
