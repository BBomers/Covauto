﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CovautoAPI.Shared.DTOs.LeenAuto
{
    public class LeenAutoListItem
    {
        [Key]
        [JsonPropertyName("Id")]
        public int Id { get; set; }
        [JsonPropertyName("Kenteken")]
        public string Kenteken { get; set; }
        [JsonPropertyName("KilometerStand")]
        public int KilometerStand { get; set; }
    }
}
