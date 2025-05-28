using CovautoAPI.Shared.DTOs.Collega;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovautoAPI.Applicatie.Interfaces
{
    public interface ICollegaRepository
    {
        Task<IEnumerable<CollegaListItem>> GeefAlleCollegasAsync();
        Task<CollegaListItem?> GeefCollegaByIDAsync(int id);

    }
}
