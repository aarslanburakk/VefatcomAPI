using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VefatcomAPI.Application.Repositories;
using VefatcomAPI.Persistence.Contexts;
using VefatcomAPI.Persistence.Repositories;

namespace VefatcomAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {

            

            services.AddDbContext<VefatcomAPIDbContext> (options =>options.UseSqlServer(Configuration.ConnectionString));
            services.AddScoped<IDeadReadRepository, DeadReadRepository>();
            services.AddScoped<IDeadWriteRepository, DeadWriteRepository>();
            services.AddScoped<ICityReadRepository, CityReadRepository>();
            services.AddScoped<ICityWriteRepository, CityWriteRepository>();
            services.AddScoped<IUserReadRepository, UserReadRepository>();
            services.AddScoped<IUserWriteRepository, UserWriteRepository>();
            

        }
    }
}
