using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class OwnerRepository : GenericRepository<Owner>, IOwnerRepository
    {
        public OwnerRepository(GarageContext context) : base(context)
        {

        }
    }
}
