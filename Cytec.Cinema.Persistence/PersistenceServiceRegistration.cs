using System;
using System.Collections.Generic;
using System.Text;
using Cytec.Cinema.Application.Contracts.Persistence;
using Cytec.Cinema.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Cytec.Cinema.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CinemaDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnectionString"))
            );
            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IShowRepository, ShowRepository>();
            services.AddScoped<IBookingRepository, BookingRepository>();
            return services;
        }
    }
}
