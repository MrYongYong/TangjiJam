using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TangjinJam.Infrastructure.Ef;

namespace TangjinJam.API.Configuration
{
    public static class Configurations
    {
        public static void ConfigureMySqlContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["mysqlconnection:connectionString"];
            services.AddDbContext<TangjinJamDbContext>(o => o.UseMySQL(connectionString));
        }
    }
}
