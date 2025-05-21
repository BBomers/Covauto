using CovautoAPI.Shared.DTOs.ReserveringData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovautoAPI.Applicatie.Interfafes
{
    public interface IReserveringDataRepository
    {
        Task<IEnumerable<ReserveringDataListItem>> GeefAlleReserveringDataenAsync();
        Task<IEnumerable<ReserveringDataListItem>> GeefAlleReserveringDatabyReserevingIdAsync(int id);
        Task<ReserveringDataListItem?> GeefReserveringData(int id);
        Task<int> CreateBoekAsync(CreateReserveringData reserveringData);
        Task UpdateReserveringDataAsync(int id, ReserveringDataListItem ReserveringData);
        Task DeleteReserveringDataAsync(int id);


    }
}
