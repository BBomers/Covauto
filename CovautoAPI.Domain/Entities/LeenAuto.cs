using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovautoAPI.Domain.Entities
{
    public class LeenAuto
    {
        public int Id { get; set; }
        public string Kenteken { get; set; }
        public int KilometerStand { get; set; }
    }
}
