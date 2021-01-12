using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DTO;
using Newtonsoft.Json;

namespace GarageWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class RDWCommunication : IRDWCommunication
    {
        private readonly HttpClient _client;
        public RDWCommunication()
        {
            _client = new HttpClient();
        }

        public async Task<RDWDto> GetCarData(string licenseNumber)
        {
            licenseNumber = Regex.Replace(licenseNumber, @"[- ]", "").ToUpper();
            HttpResponseMessage response = await _client.GetAsync($"https://opendata.rdw.nl/resource/m9d7-ebf2.json?kenteken={licenseNumber}");
            RDWDto carInfo = new RDWDto();
            
            if(response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                if(result != null)
                {
                    carInfo = JsonConvert.DeserializeObject<List<RDWDto>>(result).FirstOrDefault();
                }
            }

            return carInfo;
        }

        public DateTime? GetInspection()
        {
            DateTime? inspectionDate = null;
            Random r = new Random();
            if(r.Next(10) < 3) {
                inspectionDate = DateTime.Now.AddDays(r.Next(1,7));
            }
            return inspectionDate;
        }
    }
}
