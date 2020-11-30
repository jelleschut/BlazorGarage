using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class MaintenanceRepository : GenericRepository<Maintenance>, IMaintenanceRepository
    {
        public MaintenanceRepository(GarageContext context) : base(context)
        {

        }
    }
}
