using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovautoAPI.Domain.Entities
{
    public class ReserveringData
    {
        public int Id { get; set; }
        public int ReserveringID { get; set; }
        public string AdresFrom {  get; set; }
        public string AdresTo { get; set; }
        public int KilometerStand { get; set; }
    }
}
