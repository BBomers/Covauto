using CovautoAPI.Applicatie.Interfafes;
using CovautoAPI.Domain.Data;
using CovautoAPI.Domain.Entities;
using CovautoAPI.Shared.DTOs.LeenAuto;
using CovautoAPI.Shared.DTOs.ReserveringData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CovautoAPI.Applicatie.Repositories
{
    public class ReserveringDataRepository : IReserveringDataRepository
    {
        private readonly CovautoContext covautoContext;

        public ReserveringDataRepository(CovautoContext covautoContext)
        {
            this.covautoContext = covautoContext;
        }

        public async Task<IEnumerable<ReserveringDataListItem>> GeefAlleReserveringDataenAsync()
        {
            return await covautoContext
                .reserveringData
                .Select(static b => new ReserveringDataListItem
                {
                    Id = b.Id,
                    ReserveringID = b.ReserveringID,
                    StartStraat = b.StartStraat,
                    StartPostcode = b.StartPostcode,
                    StartStad = b.StartStad,
                    ToStraat = b.ToStraat,
                    ToPostcode = b.ToPostcode,
                    ToStad = b.ToStad
                }).ToListAsync();
        }
        public async Task<IEnumerable<ReserveringDataListItem>> GeefAlleReserveringDatabyReserevingIdAsync(int id)
        {
            return await covautoContext
                .reserveringData
                .Where(b => b.ReserveringID == id)
                .Select(static b => new ReserveringDataListItem
                {
                    Id = b.Id,
                    ReserveringID = b.ReserveringID,
                    StartStraat = b.StartStraat,
                    StartPostcode = b.StartPostcode,
                    StartStad = b.StartStad,
                    ToStraat = b.ToStraat,
                    ToPostcode = b.ToPostcode,
                    ToStad = b.ToStad
                }).ToListAsync();
        }

        public async Task<ReserveringDataListItem?> GeefReserveringData(int id)
        {
            ReserveringData? ReserveringData = await covautoContext.reserveringData.SingleOrDefaultAsync(n => n.Id == id);
            return MapReserveringData(ReserveringData);
        }

        public async Task<int> CreateBoekAsync(CreateReserveringData reserveringData)
        {

            var XreserveringData = new ReserveringData
            {
                ReserveringID = reserveringData.ReserveringID,
                StartStraat = reserveringData.StartStraat,
                StartPostcode = reserveringData.StartPostcode,
                StartStad = reserveringData.StartStad,
                ToStraat = reserveringData.ToStraat,
                ToPostcode = reserveringData.ToPostcode,
                ToStad = reserveringData.ToStad
            };

            await covautoContext.reserveringData.AddAsync(XreserveringData);

            await covautoContext.SaveChangesAsync();
            return XreserveringData.Id;
        }


        public async Task UpdateReserveringDataAsync(int id, ReserveringDataListItem ReserveringData)
        {
            if (id != ReserveringData.Id)
            {
                throw new ValidationException("Ids are not corresponding");
            }

            ReserveringData? ReserveringDataEnt = await covautoContext.reserveringData.SingleOrDefaultAsync(n => n.Id == id);

            if (ReserveringDataEnt == null)
            {
                throw new Exception("No ReserveringData found");
            }
            MapReserveringData(ReserveringDataEnt, ReserveringData);

            await covautoContext.SaveChangesAsync();
        }

        public async Task DeleteReserveringDataAsync(int id)
        {
            var ReserveringData = await covautoContext.reserveringData.FindAsync(id);
            if (ReserveringData == null)
                throw new Exception("No ReserveringData found");
            covautoContext.reserveringData.Remove(ReserveringData);
            await covautoContext.SaveChangesAsync();
        }

        private static void MapReserveringData(ReserveringData reserveringDataEnt, ReserveringDataListItem ReserveringData)
            {
            reserveringDataEnt.Id = ReserveringData.Id;
            reserveringDataEnt.ReserveringID = ReserveringData.ReserveringID;
            reserveringDataEnt.StartStraat = ReserveringData.StartStraat;
            reserveringDataEnt.StartPostcode = ReserveringData.StartPostcode;
            reserveringDataEnt.StartStad = ReserveringData.StartStad;
            reserveringDataEnt.ToStraat = ReserveringData.ToStraat;
            reserveringDataEnt.ToPostcode = ReserveringData.ToPostcode;
            reserveringDataEnt.ToStad = ReserveringData.ToStad;
        }

        private static ReserveringDataListItem? MapReserveringData(ReserveringData? reserveringData)
        {
            if (reserveringData == null) return null;
            return new ReserveringDataListItem()
            {
                Id = reserveringData.Id,
                ReserveringID = reserveringData.ReserveringID,
                StartStraat = reserveringData.StartStraat,
                StartPostcode = reserveringData.StartPostcode,
                StartStad = reserveringData.StartStad,
                ToStraat = reserveringData.ToStraat,
                ToPostcode = reserveringData.ToPostcode,
                ToStad = reserveringData.ToStad
            };
        }
    }
}
