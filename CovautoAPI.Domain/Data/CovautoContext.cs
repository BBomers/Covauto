﻿using CovautoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace CovautoAPI.Domain.Data
{
    public class CovautoContext : DbContext
    {
        public CovautoContext(DbContextOptions<CovautoContext> options) : base(options) { }

        public DbSet<LeenAuto> leenAutos { get; set; }
        public DbSet<Reserveringen> reserveringen { get; set; }
        public DbSet<ReserveringData> reserveringData { get; set; }
        public DbSet<Collega> collega { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Collega>().HasData(
                new Collega { Id = 1, Naam = "Sophie Janssen" },
                new Collega { Id = 2, Naam = "Tom Vermeer" },
                new Collega { Id = 3, Naam = "Lotte de Vries" }
            );

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
                            CollegaID = 1,
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
                            Afstand = 15
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
                            Afstand = 5
                        }
                    );

                    reserveringId++;
                }
            }
        }
    }
}
