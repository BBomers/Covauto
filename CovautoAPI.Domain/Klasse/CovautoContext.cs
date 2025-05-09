using CovautoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovautoAPI.Domain.Klasse
{
    public class CovautoContext : DbContext
    {

        public CovautoContext(DbContextOptions<CovautoContext> options) : base(options) { }
        public DbSet<LeenAuto> LeenAuto { get; set; }
        public DbSet<ReserveringData> ReserveringData { get; set; }
        public DbSet<Reserveringen> Reservingen { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<LeenAuto>().HasData(
                new LeenAuto { Id = 1, Kenteken = "XX-123-X", KilometerStand = 50000 },
                new LeenAuto { Id = 2, Kenteken = "YY-456-Y", KilometerStand = 35000 }
            );

            modelBuilder.Entity<Reserveringen>().HasData(
                new Reserveringen
                {
                    Id = 1,
                    LeenAutoID = 1,
                    ReserveerDatum = new DateTime(2024, 5, 1, 10, 0, 0),
                    BoekDatumVanaf = new DateTime(2024, 5, 2),
                    BoekDatumTot = new DateTime(2024, 5, 4)
                },
                new Reserveringen
                {
                    Id = 2,
                    LeenAutoID = 2,
                    ReserveerDatum = new DateTime(2024, 5, 3, 15, 0, 0),
                    BoekDatumVanaf = new DateTime(2024, 5, 5),
                    BoekDatumTot = new DateTime(2024, 5, 6)
                }
            );

            modelBuilder.Entity<ReserveringData>().HasData(
                new ReserveringData
                {
                    Id = 1,
                    ReserveringID = 1,
                    StartStraat = "Startstraat 1",
                    StartPostcode = "1234AB",
                    StartStad = "Utrecht",
                    ToStraat = "Eindstraat 5",
                    ToPostcode = "5678CD",
                    ToStad = "Amsterdam",
                    KilometerStand = 50200
                }
            );
        }

    }


}
