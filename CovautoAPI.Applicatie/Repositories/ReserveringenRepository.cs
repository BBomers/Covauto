using CovautoAPI.Applicatie.Interfafes;
using CovautoAPI.Domain.Data;
using CovautoAPI.Domain.Entities;
using CovautoAPI.Shared.DTOs.Reserveringen;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CovautoAPI.Applicatie.Repositories
{
    public class ReserveringenRepository : IReserveringenRepository
    {
        private readonly CovautoContext covautoContext;

        public ReserveringenRepository(CovautoContext covautoContext)
        {
            this.covautoContext = covautoContext;
        }


        public async Task<IEnumerable<ReserveringListItem>> GeefAlleReserveringenAsync()
        {
            return await covautoContext
                .reserveringen
                .Select(static b => new ReserveringListItem
                {
                    Id = b.Id,
                    LeenAutoID = b.LeenAutoID,
                    ReserveerDatum = b.ReserveerDatum,
                    BoekDatumVanaf = b.BoekDatumVanaf,
                    BoekDatumTot = b.BoekDatumTot,
                    KilometerStand = b.KilometerStand,
                }).ToListAsync();
        }

        public async Task<ReserveringListItem?> GeefReservering(int id)
        {
            Reserveringen? reservering = await covautoContext.reserveringen.SingleOrDefaultAsync(n => n.Id == id);
            return MapReservering(reservering);
        }

        public async Task<int> CreateBoekAsync(CreateReservering reservering)
            {

                var Xreservering = new Reserveringen
                {
                    LeenAutoID = reservering.LeenAutoID,
                    ReserveerDatum = reservering.ReserveerDatum,
                    BoekDatumVanaf = reservering.BoekDatumVanaf,
                    BoekDatumTot = reservering.BoekDatumTot
                };

                await covautoContext.reserveringen.AddAsync(Xreservering);

                await covautoContext.SaveChangesAsync();
                return Xreservering.Id;
            }


        public async Task UpdateReserveringAsync(int id, ReserveringListItem Reservering)
        {
            if (id != Reservering.Id)
            {
                throw new ValidationException("Ids are not corresponding");
            }

            Reserveringen? reserveringEnt = await covautoContext.reserveringen.SingleOrDefaultAsync(n => n.Id == id);

            if (reserveringEnt == null)
            {
                throw new Exception("No Reservering found");
            }
            MapReservering(reserveringEnt, Reservering);

            await covautoContext.SaveChangesAsync();
        }

        public async Task DeleteReserveringAsync(int id)
        {
            var Reservering = await covautoContext.reserveringen.FindAsync(id);
            if (Reservering == null)
                throw new Exception("No Reservering found");
            covautoContext.reserveringen.Remove(Reservering);
            await covautoContext.SaveChangesAsync();
        }

        private static void MapReservering(Reserveringen reserveringEnt, ReserveringListItem reservering)
            {
            reserveringEnt.Id = reservering.Id;
            reserveringEnt.LeenAutoID = reservering.LeenAutoID;
            reserveringEnt.ReserveerDatum = reservering.ReserveerDatum;
            reserveringEnt.BoekDatumVanaf = reservering.BoekDatumVanaf;
            reserveringEnt.BoekDatumTot = reservering.BoekDatumTot;
            reserveringEnt.KilometerStand = reservering.KilometerStand;
        }

        private static ReserveringListItem? MapReservering(Reserveringen? reservering)
        {
            if (reservering == null) return null;
            return new ReserveringListItem()
            {
                Id = reservering.Id,
                LeenAutoID = reservering.LeenAutoID,
                ReserveerDatum = reservering.ReserveerDatum,
                BoekDatumVanaf = reservering.BoekDatumVanaf,
                BoekDatumTot = reservering.BoekDatumTot,
                KilometerStand = reservering.KilometerStand,
            };
        }
    }
}
