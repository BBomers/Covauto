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

        public DbSet<LeenAuto> leenAuto { get; set; }
        public DbSet<Reserveringen> reserveringen { get; set; }
    }
}
