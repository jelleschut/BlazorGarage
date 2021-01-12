using Newtonsoft.Json;
using System;

namespace DTO
{
    public class RDWDto
    {
        [JsonProperty("kenteken")]
        public string LicenseNumber { get; set; }

        [JsonProperty("merk")]
        public string Brand { get; set; }

        [JsonProperty("handelsbenaming")]
        public string Model { get; set; }
    }
}
