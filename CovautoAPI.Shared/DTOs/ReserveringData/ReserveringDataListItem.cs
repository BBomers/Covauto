using CovautoAPI.Shared.DTOs.Reserveringen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovautoAPI.Shared.DTOs.ReserveringData
{
    public class ReserveringDataListItem
    {
        public int Id { get; set; }
        public ReserveringListItem Reservering { get; set; }
        public string AdresFrom { get; set; }
        public string AdresTo { get; set; }
        public int KilometerStand { get; set; }
    }
}
