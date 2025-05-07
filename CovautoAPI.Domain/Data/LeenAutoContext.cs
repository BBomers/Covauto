using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovautoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CovautoAPI.Domain.Data
{
    public class LeenAutoContext : DbContext
    {
        public LeenAutoContext(DbContextOptions<LeenAutoContext> options) : base(options) { }

        public DbSet<LeenAuto> leenAutos { get; set; }
        public DbSet<Reserveringen> Reserveringen { get; set; }
        public DbSet<ReserveringData> ReserveringData { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<LeenAuto>().HasData(
                new LeenAuto
                {
                    Id = 1,
                    Kenteken = "HN-403-Z",
                    KilometerStand = 10
                },
                new LeenAuto
                {
                    Id = 2,
                    Kenteken = "HN-404-Z",
                    KilometerStand = 15
                }
            );

            modelBuilder.Entity<Reserveringen>().HasData(
                new Reserveringen
                {
                    Id = 1,
                    LeenAutoID = 1,
                    ReserveerDatum = new DateTime(2025, 3, 2),
                    BoekDatumVanaf = new DateTime(2025, 5, 5),
                    BoekDatumTot = new DateTime(2025, 4, 25),
                    Postcode = "4124CC",
                    Straat = "",
                    Stad = "Utrecht"
                }
            );
        }

    }
}
