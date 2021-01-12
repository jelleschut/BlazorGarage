using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Web.Services.Interfaces
{
    public interface IMaintenanceService
    {
        Task Add(Maintenance maintenance);
        Task Update(Maintenance maintenance);
        Task<Maintenance> Find(int id);
        Task<IEnumerable<Maintenance>> GetAll();
        Task<IEnumerable<Maintenance>> Where(Expression<Func<Maintenance, bool>> expression);
        Maintenance EncryptMaintenance(Maintenance maintenance);
        Maintenance DecryptMaintenance(Maintenance maintenance);

    }
}
