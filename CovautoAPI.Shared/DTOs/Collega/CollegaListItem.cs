using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CovautoAPI.Shared.DTOs.Collega
{
    public class CollegaListItem
    {
        [Key]
        [JsonPropertyName("Id")]
        public int Id { get; set; }
        [JsonPropertyName("Naam")]
        public string Naam { get; set; }

    }
}
