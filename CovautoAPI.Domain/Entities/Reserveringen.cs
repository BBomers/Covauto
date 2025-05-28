using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovautoAPI.Domain.Entities
{
    public class Reserveringen
    {
        public int Id { get; set; }
        public int LeenAutoID { get; set; }
        public int CollegaID { get; set; }
        public DateTime ReserveerDatum { get; set; } // Tijd van platsing van reservering
        public DateTime BoekDatumVanaf { get; set; }
        public DateTime BoekDatumTot { get; set; }
        public int? KilometerStand { get; set; }
    }
}
