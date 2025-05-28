using CovautoAPI.Applicatie.Interfafes;
using CovautoAPI.Domain.Data;
using CovautoAPI.Domain.Entities;
using CovautoAPI.Shared.DTOs.LeenAuto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovautoAPI.Applicatie.Repositories
{
    public class LeenAutoRepository : ILeenAutoRepository
    {
        private readonly CovautoContext covautoContext;

        public LeenAutoRepository(CovautoContext covautoContext)
        {
            this.covautoContext = covautoContext;
        }

        public async Task<IEnumerable<LeenAutoListItem>> GeefAlleLeenAutoenAsync()
        {
            return await covautoContext
                .leenAutos
                .Select(static b => new LeenAutoListItem
                {
                    Id = b.Id,
                    Kenteken = b.Kenteken,
                    KilometerStand = b.KilometerStand
                }).ToListAsync();
        }


        public async Task<LeenAutoListItem?> GeefLeenAuto(int id)
        {
            LeenAuto? leenAuto = await covautoContext.leenAutos.SingleOrDefaultAsync(n => n.Id == id);
            return FullMapLeenAuto(leenAuto);
        }

        public async Task UpdateLeenAutoAsync(int id, LeenAutoListItem LeenAuto)
        {
            if (id != LeenAuto.Id)
            {
                throw new ValidationException("Ids are not corresponding");
            }


            LeenAuto? LeenAutoEnt = await covautoContext.leenAutos.SingleOrDefaultAsync(n => n.Id == id);

            if (LeenAutoEnt == null)
            {
                throw new Exception("No LeenAuto found");
            }
            MapLeenAuto(LeenAutoEnt, LeenAuto);

            await covautoContext.SaveChangesAsync();
        }
        private static void MapLeenAuto(LeenAuto leenAutokEnt, LeenAutoListItem leenAuto)
        {
            leenAutokEnt.Kenteken = leenAuto.Kenteken;
            leenAutokEnt.KilometerStand = leenAuto.KilometerStand;
        }

        private static LeenAutoListItem? FullMapLeenAuto(LeenAuto? leenAuto)
        {
            if (leenAuto == null) return null;
            return new LeenAutoListItem()
            {
                Id = leenAuto.Id,
                Kenteken = leenAuto.Kenteken,
                KilometerStand = leenAuto.KilometerStand


            };
        }
    }
}
