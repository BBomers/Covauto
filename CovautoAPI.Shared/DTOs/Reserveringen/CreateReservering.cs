using CovautoAPI.Shared.DTOs.LeenAuto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CovautoAPI.Shared.DTOs.Reserveringen
{
    public class CreateReservering
    {

        [JsonPropertyName("LeenAutoID")]
        public int LeenAutoID { get; set; }
        [JsonPropertyName("LeenAutoID")]
        public int CollegaID { get; set; }
        [JsonPropertyName("ReserveerDatum")]
        public DateTime ReserveerDatum { get; set; } // Tijd van platsing van reservering
        [JsonPropertyName("BoekDatumVanaf")]
        public DateTime BoekDatumVanaf { get; set; }
        [JsonPropertyName("BoekDatumTot")]
        public DateTime BoekDatumTot { get; set; }

    }
}
