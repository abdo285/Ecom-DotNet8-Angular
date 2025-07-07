using Ecom.Core.Interfaces;
using Ecom.Infrastructure.Data;
using Ecom.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Infrastructure
{
    public static class InfrastructureReisteration
    {
       public static IServiceCollection infrastructureConfiguration(this IServiceCollection services,IConfiguration config)
        {

            //transient
            //scoped 
            //singilton 
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddDbContext<AppDbContext>(op =>
            {
                op.UseSqlServer(config.GetConnectionString("EcomDatabase"));
            }
            );

            return services;

        }
    }
}
