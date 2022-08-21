using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen.DataAccess.Data;

namespace Lec10.Infrastructure
{
    public static class Injection2
    {
        public static IServiceCollection RegisterInfrastructureServices
            (this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContextPool<ApplicationDbContext>
                (options => options.UseSqlServer(configuration.GetConnectionString("Default")));

            

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddTokenProvider<DataProtectorTokenProvider<IdentityUser>>
                    (TokenOptions.DefaultProvider);

            return services;
        }
    }
}
