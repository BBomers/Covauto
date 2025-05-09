using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovautoAPI.Shared.DTOs.LeenAuto
{
    public class LeenAutoListItem
    {
        public int Id { get; set; }
        public string Kenteken { get; set; }
        public int KilometerStand { get; set; }
    }
}
