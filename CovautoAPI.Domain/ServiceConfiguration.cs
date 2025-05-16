using CovautoAPI.Domain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovautoAPI.Domain
{
    public class ServiceConfiguration
    {
        public static void RegisterServices(IServiceCollection services, string ConnectionSting)
        {
            services.AddDbContext<CovautoContext>(options =>
                options.UseSqlite(ConnectionSting, sqliteOptions =>
                    sqliteOptions.MigrationsAssembly("CovautoAPI.Domain")));

        }
    }
}
