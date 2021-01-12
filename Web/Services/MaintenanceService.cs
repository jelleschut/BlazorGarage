using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Web.Services.Interfaces;
using Web.Utils;

namespace Web.Services
{
    public class MaintenanceService : IMaintenanceService
    {
        private readonly IMaintenanceRepository _maintenanceRepository;
        //private X509Encryptor encryptor;

        public MaintenanceService(IMaintenanceRepository maintenanceRepository)
        {
            _maintenanceRepository = maintenanceRepository;
            //encryptor = new X509Encryptor();
        }

        public async Task Add(Maintenance maintenance)
        {
            await _maintenanceRepository.AddAsync(maintenance);
        }

        public async Task Update(Maintenance maintenance)
        {
            await _maintenanceRepository.UpdateAsync(maintenance);
        }

        public async Task<Maintenance> Find(int id)
        {
            return await _maintenanceRepository.FindAsync(id);
        }

        public async Task<IEnumerable<Maintenance>> GetAll()
        {
            return await _maintenanceRepository.GetAllAsync();
        }

        public async Task<IEnumerable<Maintenance>> Where(Expression<Func<Maintenance, bool>> expression)
        {
            return await _maintenanceRepository.WhereAsync(expression);
        }

        public Maintenance EncryptMaintenance(Maintenance maintenance)
        {
            return maintenance;
        }

        public Maintenance DecryptMaintenance(Maintenance maintenance)
        {
            return maintenance;
        }
    }
}
