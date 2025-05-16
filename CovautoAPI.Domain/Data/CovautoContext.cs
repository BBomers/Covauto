using CovautoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace CovautoAPI.Domain.Data
{
    public class CovautoContext : DbContext
    {
        public CovautoContext(DbContextOptions<CovautoContext> options) : base(options) { }

        public DbSet<LeenAuto> leenAutos { get; set; }
        public DbSet<Reserveringen> Reserveringen { get; set; }
        public DbSet<ReserveringData> ReserveringData { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // LeenAutos
            modelBuilder.Entity<LeenAuto>().HasData(
                new LeenAuto { Id = 1, Kenteken = "AA-123-AA", KilometerStand = 10000 },
                new LeenAuto { Id = 2, Kenteken = "BB-234-BB", KilometerStand = 20000 },
                new LeenAuto { Id = 3, Kenteken = "CC-345-CC", KilometerStand = 30000 }
            );

            // Reserveringen (8 per LeenAuto)
            int reserveringId = 1;
            var boekStart = new DateTime(2024, 1, 1);
            for (int autoId = 1; autoId <= 3; autoId++)
            {
                for (int i = 0; i < 8; i++)
                {
                    modelBuilder.Entity<Reserveringen>().HasData(
                        new Reserveringen
                        {
                            Id = reserveringId,
                            LeenAutoID = autoId,
                            ReserveerDatum = boekStart.AddDays(reserveringId),
                            BoekDatumVanaf = boekStart.AddDays(reserveringId + 1),
                            BoekDatumTot = boekStart.AddDays(reserveringId + 3)
                        }
                    );

                    // ReserveringData (2 per reservering)
                    modelBuilder.Entity<ReserveringData>().HasData(
                        new ReserveringData
                        {
                            Id = reserveringId * 2 - 1,
                            ReserveringID = reserveringId,
                            StartStraat = $"Startstraat {reserveringId}-1",
                            StartPostcode = "1234AB",
                            StartStad = "StadA",
                            ToStraat = $"Tostraat {reserveringId}-1",
                            ToPostcode = "5678CD",
                            ToStad = "StadB",
                            KilometerStand = 10000 + reserveringId
                        },
                        new ReserveringData
                        {
                            Id = reserveringId * 2,
                            ReserveringID = reserveringId,
                            StartStraat = $"Startstraat {reserveringId}-2",
                            StartPostcode = "2233EF",
                            StartStad = "StadC",
                            ToStraat = $"Tostraat {reserveringId}-2",
                            ToPostcode = "8899GH",
                            ToStad = "StadD",
                            KilometerStand = 10000 + reserveringId + 10
                        }
                    );

                    reserveringId++;
                }
            }
        }
    }
}
