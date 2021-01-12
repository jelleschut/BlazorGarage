using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Services
{
    interface IRDWService
    {
        Task<RDWDto> GetCarData(string licenseNumber);
        Task<DateTime?> GetInspection();
    }
}
