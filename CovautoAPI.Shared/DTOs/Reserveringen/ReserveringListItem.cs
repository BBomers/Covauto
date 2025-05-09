using CovautoAPI.Shared.DTOs.LeenAuto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovautoAPI.Shared.DTOs.Reserveringen
{
    public class ReserveringListItem
    {

        public int Id { get; set; }
        public LeenAutoListItem LeenAuto { get; set; }
        public DateTime ReserveerDatum { get; set; } // Tijd van platsing van reservering
        public DateTime BoekDatumVanaf { get; set; }
        public DateTime BoekDatumTot { get; set; }

    }
}
