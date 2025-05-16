using CovautoAPI.Shared.DTOs.Reserveringen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovautoAPI.Applicatie.Interfafes
{
    public interface IReserveringenRepository
    {
        Task<IEnumerable<ReserveringListItem>> GeefAlleReserveringenAsync();
        Task<ReserveringListItem?> GeefReservering(int id);
        Task<int> CreateBoekAsync(CreateReservering reservering);
        Task UpdateReserveringAsync(int id, ReserveringListItem Reservering);
        Task DeleteReserveringAsync(int id);
    }
}
