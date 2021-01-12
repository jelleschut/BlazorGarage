using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Services
{
    public class RDWService : IRDWService
    {
        public async Task<RDWDto> GetCarData(string licenseNumber)
        {
            RDWCommunicationReference.RDWCommunicationClient _client = new RDWCommunicationReference.RDWCommunicationClient();
            var result = await _client.GetCarDataAsync(licenseNumber);

            RDWDto returnDTO = new RDWDto
            {
                LicenseNumber = licenseNumber,
                Brand = string.Empty,
                Model = string.Empty,
            };

            if (result != null)
            {
                returnDTO.LicenseNumber = result.LicenseNumber;
                returnDTO.Brand = result.Brand;
                returnDTO.Model = result.Model;
            }

            return returnDTO;
        }

        public async Task<DateTime?> GetInspection()
        {
            RDWCommunicationReference.RDWCommunicationClient _client = new RDWCommunicationReference.RDWCommunicationClient();
            return await _client.GetInspectionAsync();
        }
    }
}
