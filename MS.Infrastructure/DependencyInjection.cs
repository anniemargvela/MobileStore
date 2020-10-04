using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MS.Domain.Abstractions.Repositories;
using MS.Infrastructure.DAL.Context;
using MS.Infrastructure.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace MS.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastucture(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MSContext>(opts => opts.UseSqlServer(configuration["ConnectionString:MobilesStore"]));

            services.AddScoped<IMobilesRepository, MobileRepository>();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            return services;
        }
    }
}
