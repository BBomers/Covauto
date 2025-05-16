using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CovautoAPI.Shared.DTOs.ReserveringData
{
    public class CreateReserveringData
    {
        [JsonPropertyName("AdresFrom")]
        public string AdresFrom { get; set; }
        [JsonPropertyName("AdresTo")]
        public string AdresTo { get; set; }
        [JsonPropertyName("KilometerStand")]
        public int KilometerStand { get; set; }
    }
}
