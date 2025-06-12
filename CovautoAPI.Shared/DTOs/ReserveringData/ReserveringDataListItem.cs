using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CovautoAPI.Shared.DTOs.ReserveringData
{
    public class ReserveringDataListItem
    {

        [Key]
        [JsonPropertyName("Id")]
        public int Id { get; set; }
        [JsonPropertyName("ReserveringID")]
        public int ReserveringID { get; set; }
        [JsonPropertyName("StartStraat")]
        public string StartStraat { get; set; }
        [JsonPropertyName("StartPostcode")]
        public string StartPostcode { get; set; }
        [JsonPropertyName("StartStad")]
        public string StartStad { get; set; }
        [JsonPropertyName("ToStraat")]
        public string ToStraat { get; set; }
        [JsonPropertyName("ToPostcode")]
        public string ToPostcode { get; set; }
        [JsonPropertyName("ToStad")]
        public string ToStad { get; set; }
        [JsonPropertyName("Afstand")]
        public int Afstand { get; set; }
    }
}
