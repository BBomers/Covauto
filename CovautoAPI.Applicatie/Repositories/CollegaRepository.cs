using CovautoAPI.Applicatie.Interfaces;
using CovautoAPI.Applicatie.Interfafes;
using CovautoAPI.Domain.Data;
using CovautoAPI.Domain.Entities;
using CovautoAPI.Shared.DTOs.Collega;
using CovautoAPI.Shared.DTOs.LeenAuto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovautoAPI.Applicatie.Repositories
{
    public class CollegaRepository : ICollegaRepository
    {
        private readonly CovautoContext covautoContext;

        public CollegaRepository(CovautoContext covautoContext)
        {
            this.covautoContext = covautoContext;
        }
        public async Task<IEnumerable<CollegaListItem>> GeefAlleCollegasAsync()
        {
            return await covautoContext
                .collega
                .Select(static b => new CollegaListItem
                {
                    Id = b.Id,
                    Naam = b.Naam,
                }).ToListAsync();
        }


        public async Task<CollegaListItem?> GeefCollegaByIDAsync(int id)
        {
            Collega? collega = await covautoContext.collega.SingleOrDefaultAsync(n => n.Id == id);
            return FullMapCollega(collega);
        }
        private static CollegaListItem? FullMapCollega(Collega? collega)
        {
            if (collega == null) return null;
            return new CollegaListItem()
            {
                Id = collega.Id,
                Naam = collega.Naam


            };
        }
    }
}
