using CovautoAPI.Shared.DTOs.LeenAuto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovautoAPI.Applicatie.Interfafes
{
    public interface ILeenAutoRepository
    {
        Task<IEnumerable<LeenAutoListItem>> GeefAlleLeenAutoenAsync();
        Task<LeenAutoListItem?> GeefLeenAuto(int id);
        Task UpdateLeenAutoAsync(int id, LeenAutoListItem LeenAuto);

    }
}
