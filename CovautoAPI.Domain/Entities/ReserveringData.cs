using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CovautoAPI.Domain.Entities
{
    public class ReserveringData
    {
        public int Id { get; set; }
        public int ReserveringID { get; set; }
        public string StartStraat { get; set; }
        public string StartPostcode { get; set; }
        public string StartStad { get; set; }
        public string ToStraat { get; set; }
        public string ToPostcode { get; set; }
        public string ToStad { get; set; }
        public int Afstand { get; set; }
    }
}
